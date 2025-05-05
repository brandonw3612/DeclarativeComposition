using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class VisualSurfaceTest() : TestBase("ProviderTests/VisualSurfaceTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("VisualSurface", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(4, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("\"VisualSurface\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("sourceOffset", firstChild.Properties[1].Name);
        Assert.Equal("new(0.0f, 0.0f)", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("sourceSize", firstChild.Properties[2].Name);
        Assert.Equal("new(0.0f, 0.0f)", (firstChild.Properties[2].Value as SharpCodeNode)?.Code);
        Assert.Equal("sourceVisual", firstChild.Properties[3].Name);
        Assert.Equal("_compositor.CreateSpriteVisual()", (firstChild.Properties[3].Value as SharpCodeNode)?.Code);
    }
}