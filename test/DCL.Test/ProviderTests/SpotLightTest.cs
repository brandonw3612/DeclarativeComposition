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
        Assert.Equal("SpotLight", (firstChild.Properties[0].Value as StringLiteralNode)?.Content);
        Assert.Equal("isEnabled", firstChild.Properties[1].Name);
        Assert.Equal("true", (firstChild.Properties[1].Value as StringLiteralNode)?.Content);
        Assert.Equal("constantAttenuation", firstChild.Properties[2].Name);
        Assert.Equal("1", (firstChild.Properties[2].Value as StringLiteralNode)?.Content);
        Assert.Equal("coordinateSpace", firstChild.Properties[3].Name);
        Assert.Equal("_compositor.CreateSpriteVisual()", (firstChild.Properties[3].Value as SharpCodeNode)?.Code);
        Assert.Equal("direction", firstChild.Properties[4].Name);
        Assert.Equal("0 0 -1", (firstChild.Properties[4].Value as StringLiteralNode)?.Content);
        Assert.Equal("innerConeAngle", firstChild.Properties[5].Name);
        Assert.Equal("0", (firstChild.Properties[5].Value as StringLiteralNode)?.Content);
        Assert.Equal("innerConeAngleInDegrees", firstChild.Properties[6].Name);
        Assert.Equal("0", (firstChild.Properties[6].Value as StringLiteralNode)?.Content);
        Assert.Equal("innerConeColor", firstChild.Properties[7].Name);
        Assert.Equal("White", (firstChild.Properties[7].Value as StringLiteralNode)?.Content);
        Assert.Equal("innerConeIntensity", firstChild.Properties[8].Name);
        Assert.Equal("1", (firstChild.Properties[8].Value as StringLiteralNode)?.Content);
        Assert.Equal("linearAttenuation", firstChild.Properties[9].Name);
        Assert.Equal("0", (firstChild.Properties[9].Value as StringLiteralNode)?.Content);
        Assert.Equal("maxAttenuationCutoff", firstChild.Properties[10].Name);
        Assert.Equal("1", (firstChild.Properties[10].Value as StringLiteralNode)?.Content);
        Assert.Equal("minAttenuationCutoff", firstChild.Properties[11].Name);
        Assert.Equal("0", (firstChild.Properties[11].Value as StringLiteralNode)?.Content);
        Assert.Equal("offset", firstChild.Properties[12].Name);
        Assert.Equal("0", (firstChild.Properties[12].Value as StringLiteralNode)?.Content);
        Assert.Equal("outerConeAngle", firstChild.Properties[13].Name);
        Assert.Equal("0", (firstChild.Properties[13].Value as StringLiteralNode)?.Content);
        Assert.Equal("outerConeAngleInDegrees", firstChild.Properties[14].Name);
        Assert.Equal("0", (firstChild.Properties[14].Value as StringLiteralNode)?.Content);
        Assert.Equal("outerConeColor", firstChild.Properties[15].Name);
        Assert.Equal("White", (firstChild.Properties[15].Value as StringLiteralNode)?.Content);
        Assert.Equal("outerConeIntensity", firstChild.Properties[16].Name);
        Assert.Equal("1", (firstChild.Properties[16].Value as StringLiteralNode)?.Content);
        Assert.Equal("quadraticAttenuation", firstChild.Properties[17].Name);
        Assert.Equal("0", (firstChild.Properties[17].Value as StringLiteralNode)?.Content);
    }
}