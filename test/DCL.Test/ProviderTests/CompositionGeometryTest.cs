using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class CompositionGeometryTest() : TestBase("ProviderTests/CompositionGeometryTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("CompositionGeometry", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Empty(firstChild.Properties);
    }
}