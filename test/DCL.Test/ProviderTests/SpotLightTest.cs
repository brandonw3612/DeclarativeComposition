using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class SpotLightTest() : TestBase("ProviderTests/SpotLightTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("SpotLight", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(18, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("\"SpotLight\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("isEnabled", firstChild.Properties[1].Name);
        Assert.Equal("true", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("constantAttenuation", firstChild.Properties[2].Name);
        Assert.Equal("1.0f", (firstChild.Properties[2].Value as SharpCodeNode)?.Code);
        Assert.Equal("coordinateSpace", firstChild.Properties[3].Name);
        Assert.Equal("_compositor.CreateSpriteVisual()", (firstChild.Properties[3].Value as SharpCodeNode)?.Code);
        Assert.Equal("direction", firstChild.Properties[4].Name);
        Assert.Equal("new(0.0f, 0.0f, -1.0f)", (firstChild.Properties[4].Value as SharpCodeNode)?.Code);
        Assert.Equal("innerConeAngle", firstChild.Properties[5].Name);
        Assert.Equal("0.0f", (firstChild.Properties[5].Value as SharpCodeNode)?.Code);
        Assert.Equal("innerConeAngleInDegrees", firstChild.Properties[6].Name);
        Assert.Equal("0.0f", (firstChild.Properties[6].Value as SharpCodeNode)?.Code);
        Assert.Equal("innerConeColor", firstChild.Properties[7].Name);
        Assert.Equal("Microsoft.UI.Colors.White", (firstChild.Properties[7].Value as SharpCodeNode)?.Code);
        Assert.Equal("innerConeIntensity", firstChild.Properties[8].Name);
        Assert.Equal("1.0f", (firstChild.Properties[8].Value as SharpCodeNode)?.Code);
        Assert.Equal("linearAttenuation", firstChild.Properties[9].Name);
        Assert.Equal("0.0f", (firstChild.Properties[9].Value as SharpCodeNode)?.Code);
        Assert.Equal("maxAttenuationCutoff", firstChild.Properties[10].Name);
        Assert.Equal("1.0f", (firstChild.Properties[10].Value as SharpCodeNode)?.Code);
        Assert.Equal("minAttenuationCutoff", firstChild.Properties[11].Name);
        Assert.Equal("0.0f", (firstChild.Properties[11].Value as SharpCodeNode)?.Code);
        Assert.Equal("offset", firstChild.Properties[12].Name);
        Assert.Equal("new(0.0f, 0.0f, 0.0f)", (firstChild.Properties[12].Value as SharpCodeNode)?.Code);
        Assert.Equal("outerConeAngle", firstChild.Properties[13].Name);
        Assert.Equal("0.0f", (firstChild.Properties[13].Value as SharpCodeNode)?.Code);
        Assert.Equal("outerConeAngleInDegrees", firstChild.Properties[14].Name);
        Assert.Equal("0.0f", (firstChild.Properties[14].Value as SharpCodeNode)?.Code);
        Assert.Equal("outerConeColor", firstChild.Properties[15].Name);
        Assert.Equal("Microsoft.UI.Colors.White", (firstChild.Properties[15].Value as SharpCodeNode)?.Code);
        Assert.Equal("outerConeIntensity", firstChild.Properties[16].Name);
        Assert.Equal("1.0f", (firstChild.Properties[16].Value as SharpCodeNode)?.Code);
        Assert.Equal("quadraticAttenuation", firstChild.Properties[17].Name);
        Assert.Equal("0.0f", (firstChild.Properties[17].Value as SharpCodeNode)?.Code);
    }
}