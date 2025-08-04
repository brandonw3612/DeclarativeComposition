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
        Assert.Equal("ProjectedShadow", (firstChild.Properties[0].Value as StringLiteralNode)?.Content);
        Assert.Equal("blurRadiusMultiplier", firstChild.Properties[1].Name);
        Assert.Equal("1", (firstChild.Properties[1].Value as StringLiteralNode)?.Content);
        Assert.Equal("casters", firstChild.Properties[2].Name);
        Assert.IsType<CollectionNode>(firstChild.Properties[2].Value);
        var casters = (firstChild.Properties[2].Value as CollectionNode)!;
        Assert.Single(casters.Items);
        Assert.Equal("_compositor.CreateProjectedShadowCaster()", (casters.Items[0] as SharpCodeNode)?.Code);
        Assert.Equal("lightSource", firstChild.Properties[3].Name);
        Assert.Equal("_compositor.CreateAmbientLight()", (firstChild.Properties[3].Value as SharpCodeNode)?.Code);
        Assert.Equal("maxBlurRadius", firstChild.Properties[4].Name);
        Assert.Equal("20", (firstChild.Properties[4].Value as StringLiteralNode)?.Content);
        Assert.Equal("minBlurRadius", firstChild.Properties[5].Name);
        Assert.Equal("10", (firstChild.Properties[5].Value as StringLiteralNode)?.Content);
        Assert.Equal("receivers", firstChild.Properties[6].Name);
        Assert.IsType<CollectionNode>(firstChild.Properties[6].Value);
        var receivers = (firstChild.Properties[6].Value as CollectionNode)!;
        Assert.Single(receivers.Items);
        Assert.Equal("_compositor.CreateProjectedShadowReceiver()", (receivers.Items[0] as SharpCodeNode)?.Code);
    }
}