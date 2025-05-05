using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class DropShadowTest() : TestBase("ProviderTests/DropShadowTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("DropShadow", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(7, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("\"DropShadow\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("blurRadius", firstChild.Properties[1].Name);
        Assert.Equal("4f", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("color", firstChild.Properties[2].Name);
        Assert.Equal("Microsoft.UI.Colors.White", (firstChild.Properties[2].Value as SharpCodeNode)?.Code);
        Assert.Equal("mask", firstChild.Properties[3].Name);
        Assert.Equal("_compositor.CreateColorBrush()", (firstChild.Properties[3].Value as SharpCodeNode)?.Code);
        Assert.Equal("offset", firstChild.Properties[4].Name);
        Assert.Equal("new(0f, 0f, 0f)", (firstChild.Properties[4].Value as SharpCodeNode)?.Code);
        Assert.Equal("opacity", firstChild.Properties[5].Name);
        Assert.Equal("1f", (firstChild.Properties[5].Value as SharpCodeNode)?.Code);
        Assert.Equal("sourcePolicy", firstChild.Properties[6].Name);
        Assert.Equal("Microsoft.UI.Composition.CompositionDropShadowSourcePolicy.Default", (firstChild.Properties[6].Value as SharpCodeNode)?.Code);
    }
}