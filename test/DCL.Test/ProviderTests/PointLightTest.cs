using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class PointLightTest() : TestBase("ProviderTests/PointLightTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("PointLight", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(11, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("\"PointLight\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("isEnabled", firstChild.Properties[1].Name);
        Assert.Equal("true", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("color", firstChild.Properties[2].Name);
        Assert.Equal("Microsoft.UI.Colors.White", (firstChild.Properties[2].Value as SharpCodeNode)?.Code);
        Assert.Equal("constantAttenuation", firstChild.Properties[3].Name);
        Assert.Equal("0.0f", (firstChild.Properties[3].Value as SharpCodeNode)?.Code);
        Assert.Equal("coordinateSpace", firstChild.Properties[4].Name);
        Assert.Equal("_compositor.CreateSpriteVisual()", (firstChild.Properties[4].Value as SharpCodeNode)?.Code);
        Assert.Equal("intensity", firstChild.Properties[5].Name);
        Assert.Equal("1.0f", (firstChild.Properties[5].Value as SharpCodeNode)?.Code);
        Assert.Equal("linearAttenuation", firstChild.Properties[6].Name);
        Assert.Equal("0.0f", (firstChild.Properties[6].Value as SharpCodeNode)?.Code);
        Assert.Equal("maxAttenuationCutoff", firstChild.Properties[7].Name);
        Assert.Equal("1.0f", (firstChild.Properties[7].Value as SharpCodeNode)?.Code);
        Assert.Equal("minAttenuationCutoff", firstChild.Properties[8].Name);
        Assert.Equal("0.0f", (firstChild.Properties[8].Value as SharpCodeNode)?.Code);
        Assert.Equal("offset", firstChild.Properties[9].Name);
        Assert.Equal("new(0.0f, 0.0f, 0.0f)", (firstChild.Properties[9].Value as SharpCodeNode)?.Code);
        Assert.Equal("quadraticAttenuation", firstChild.Properties[10].Name);
        Assert.Equal("0.0f", (firstChild.Properties[10].Value as SharpCodeNode)?.Code);
    }
}