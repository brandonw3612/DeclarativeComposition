using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class ViewBoxTest() : TestBase("ProviderTests/ViewBoxTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("ViewBox", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(6, firstChild.Properties.Count);

        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("ViewBox", (firstChild.Properties[0].Value as StringLiteralNode)?.Content);
        Assert.Equal("horizontalAlignmentRatio", firstChild.Properties[1].Name);
        Assert.Equal("0.5", (firstChild.Properties[1].Value as StringLiteralNode)?.Content);
        Assert.Equal("offset", firstChild.Properties[2].Name);
        Assert.Equal("0", (firstChild.Properties[2].Value as StringLiteralNode)?.Content);
        Assert.Equal("size", firstChild.Properties[3].Name);
        Assert.Equal("0", (firstChild.Properties[3].Value as StringLiteralNode)?.Content);
        Assert.Equal("stretch", firstChild.Properties[4].Name);
        Assert.Equal("None", (firstChild.Properties[4].Value as StringLiteralNode)?.Content);
        Assert.Equal("verticalAlignmentRatio", firstChild.Properties[5].Name);
        Assert.Equal("0.5", (firstChild.Properties[5].Value as StringLiteralNode)?.Content);
    }
}