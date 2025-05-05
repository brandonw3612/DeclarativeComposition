using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class DistantLightTest() : TestBase("ProviderTests/DistantLightTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("DistantLight", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(6, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("\"DistantLight\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("isEnabled", firstChild.Properties[1].Name);
        Assert.Equal("true", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("color", firstChild.Properties[2].Name);
        Assert.Equal("Microsoft.UI.Colors.White", (firstChild.Properties[2].Value as SharpCodeNode)?.Code);
        Assert.Equal("coordinateSpace", firstChild.Properties[3].Name);
        Assert.Equal("_compositor.CreateSpriteVisual()", (firstChild.Properties[3].Value as SharpCodeNode)?.Code);
        Assert.Equal("direction", firstChild.Properties[4].Name);
        Assert.Equal("new(0f, 0f, 1f)", (firstChild.Properties[4].Value as SharpCodeNode)?.Code);
        Assert.Equal("intensity", firstChild.Properties[5].Name);
        Assert.Equal("1f", (firstChild.Properties[5].Value as SharpCodeNode)?.Code);
    }
}