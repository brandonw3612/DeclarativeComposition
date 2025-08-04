using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class PathGeometryTest() : TestBase("ProviderTests/PathGeometryTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("PathGeometry", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(4, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("PathGeometry", (firstChild.Properties[0].Value as StringLiteralNode)?.Content);
        Assert.Equal("trimEnd", firstChild.Properties[1].Name);
        Assert.Equal("0", (firstChild.Properties[1].Value as StringLiteralNode)?.Content);
        Assert.Equal("trimOffset", firstChild.Properties[2].Name);
        Assert.Equal("0", (firstChild.Properties[2].Value as StringLiteralNode)?.Content);
        Assert.Equal("trimStart", firstChild.Properties[3].Name);
        Assert.Equal("0", (firstChild.Properties[3].Value as StringLiteralNode)?.Content);
        // Assert.Equal("path", firstChild.Properties[4].Name);
        // Assert.Equal("new Microsoft.UI.Composition.CompositionPath()", (firstChild.Properties[4].Value as SharpCodeNode)?.Code);
        
    }
}