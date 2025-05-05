using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class ProjectedShadowCasterTest() : TestBase("ProviderTests/ProjectedShadowCasterTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("ProjectedShadowCaster", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(3, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("\"ProjectedShadowCaster\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("brush", firstChild.Properties[1].Name);
        Assert.Equal("_compositor.CreateColorBrush()", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("castingVisual", firstChild.Properties[2].Name);
        Assert.Equal("_compositor.CreateSpriteVisual()", (firstChild.Properties[2].Value as SharpCodeNode)?.Code);
    }
}