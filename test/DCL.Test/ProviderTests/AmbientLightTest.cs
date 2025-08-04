using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class AmbientLightTest() : TestBase("ProviderTests/AmbientLightTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("AmbientLight", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(4, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("AmbientLight", (firstChild.Properties[0].Value as StringLiteralNode)?.Content);
        Assert.Equal("isEnabled", firstChild.Properties[1].Name);
        Assert.Equal("true", (firstChild.Properties[1].Value as StringLiteralNode)?.Content);
        Assert.Equal("color", firstChild.Properties[2].Name);
        Assert.Equal("White", (firstChild.Properties[2].Value as StringLiteralNode)?.Content);
        Assert.Equal("intensity", firstChild.Properties[3].Name);
        Assert.Equal("1", (firstChild.Properties[3].Value as StringLiteralNode)?.Content);
    }
}