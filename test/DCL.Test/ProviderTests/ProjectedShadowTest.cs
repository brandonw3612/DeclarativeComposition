using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class ProjectedShadowTest() : TestBase("ProviderTests/ProjectedShadowTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("ProjectedShadow", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(7, firstChild.Properties.Count);

        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("\"ProjectedShadow\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("blurRadiusMultiplier", firstChild.Properties[1].Name);
        Assert.Equal("1f", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("casters", firstChild.Properties[2].Name);
        Assert.Equal("new()", (firstChild.Properties[2].Value as SharpCodeNode)?.Code);
        Assert.Equal("lightSource", firstChild.Properties[3].Name);
        Assert.Equal("_compositor.CreateAmbientLight()", (firstChild.Properties[3].Value as SharpCodeNode)?.Code);
        Assert.Equal("maxBlurRadius", firstChild.Properties[4].Name);
        Assert.Equal("20f", (firstChild.Properties[4].Value as SharpCodeNode)?.Code);
        Assert.Equal("minBlurRadius", firstChild.Properties[5].Name);
        Assert.Equal("10f", (firstChild.Properties[5].Value as SharpCodeNode)?.Code);
        Assert.Equal("receivers", firstChild.Properties[6].Name);
        Assert.Equal("new()", (firstChild.Properties[6].Value as SharpCodeNode)?.Code);
    }
}