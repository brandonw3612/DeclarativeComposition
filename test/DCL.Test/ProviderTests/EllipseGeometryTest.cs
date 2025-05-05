using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class EllipseGeometryTest() : TestBase("ProviderTests/EllipseGeometryTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("EllipseGeometry", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(6, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("\"EllipseGeometry\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("trimEnd", firstChild.Properties[1].Name);
        Assert.Equal("0f", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("trimOffset", firstChild.Properties[2].Name);
        Assert.Equal("0f", (firstChild.Properties[2].Value as SharpCodeNode)?.Code);
        Assert.Equal("trimStart", firstChild.Properties[3].Name);
        Assert.Equal("0f", (firstChild.Properties[3].Value as SharpCodeNode)?.Code);
        Assert.Equal("center", firstChild.Properties[4].Name);
        Assert.Equal("new(50f, 50f)", (firstChild.Properties[4].Value as SharpCodeNode)?.Code);
        Assert.Equal("radius", firstChild.Properties[5].Name);
        Assert.Equal("new(10f, 10f)", (firstChild.Properties[5].Value as SharpCodeNode)?.Code);
    }
}