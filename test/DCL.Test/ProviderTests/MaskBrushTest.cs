using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class MaskBrushTest() : TestBase("ProviderTests/MaskBrushTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("MaskBrush", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(3, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("MaskBrush", (firstChild.Properties[0].Value as StringLiteralNode)?.Content);
        Assert.Equal("mask", firstChild.Properties[1].Name);
        Assert.Equal("_compositor.CreateColorBrush()", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("source", firstChild.Properties[2].Name);
        Assert.Equal("_compositor.CreateColorBrush()", (firstChild.Properties[2].Value as SharpCodeNode)?.Code);
    }
}