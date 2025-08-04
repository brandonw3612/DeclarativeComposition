using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class ProjectedShadowReceiverTest() : TestBase("ProviderTests/ProjectedShadowReceiverTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("ProjectedShadowReceiver", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(2, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("ProjectedShadowReceiver", (firstChild.Properties[0].Value as StringLiteralNode)?.Content);
        Assert.Equal("receivingVisual", firstChild.Properties[1].Name);
        Assert.Equal("_compositor.CreateSpriteVisual()", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
    }
}