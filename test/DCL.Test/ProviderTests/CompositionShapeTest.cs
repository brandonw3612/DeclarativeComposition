using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class CompositionShapeTest() : TestBase("ProviderTests/CompositionShapeTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("CompositionShape", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Empty(firstChild.Properties);
    }
}