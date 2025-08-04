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
        Assert.Equal("DropShadow", (firstChild.Properties[0].Value as StringLiteralNode)?.Content);
        Assert.Equal("blurRadius", firstChild.Properties[1].Name);
        Assert.Equal("4", (firstChild.Properties[1].Value as StringLiteralNode)?.Content);
        Assert.Equal("color", firstChild.Properties[2].Name);
        Assert.Equal("White", (firstChild.Properties[2].Value as StringLiteralNode)?.Content);
        Assert.Equal("mask", firstChild.Properties[3].Name);
        Assert.Equal("_compositor.CreateColorBrush()", (firstChild.Properties[3].Value as SharpCodeNode)?.Code);
        Assert.Equal("offset", firstChild.Properties[4].Name);
        Assert.Equal("0", (firstChild.Properties[4].Value as StringLiteralNode)?.Content);
        Assert.Equal("opacity", firstChild.Properties[5].Name);
        Assert.Equal("1", (firstChild.Properties[5].Value as StringLiteralNode)?.Content);
        Assert.Equal("sourcePolicy", firstChild.Properties[6].Name);
        Assert.Equal("Default", (firstChild.Properties[6].Value as StringLiteralNode)?.Content);
    }
}