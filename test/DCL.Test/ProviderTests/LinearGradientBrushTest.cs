using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class LinearGradientBrushTest() : TestBase("ProviderTests/LinearGradientBrushTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("LinearGradientBrush", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(14, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("\"LinearGradientBrush\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("anchorPoint", firstChild.Properties[1].Name);
        Assert.Equal("new(0f, 0f)", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("centerPoint", firstChild.Properties[2].Name);
        Assert.Equal("new(0f, 0f)", (firstChild.Properties[2].Value as SharpCodeNode)?.Code);
        Assert.Equal("colorStops", firstChild.Properties[3].Name);
        Assert.Equal("new()", (firstChild.Properties[3].Value as SharpCodeNode)?.Code);
        Assert.Equal("extendMode", firstChild.Properties[4].Name);
        Assert.Equal("Microsoft.UI.Composition.CompositionGradientExtendMode.Clamp", (firstChild.Properties[4].Value as SharpCodeNode)?.Code);
        Assert.Equal("interpolationSpace", firstChild.Properties[5].Name);
        Assert.Equal("Microsoft.UI.Composition.CompositionColorSpace.Auto", (firstChild.Properties[5].Value as SharpCodeNode)?.Code);
        Assert.Equal("mappingMode", firstChild.Properties[6].Name);
        Assert.Equal("Microsoft.UI.Composition.CompositionMappingMode.Absolute", (firstChild.Properties[6].Value as SharpCodeNode)?.Code);
        Assert.Equal("offset", firstChild.Properties[7].Name);
        Assert.Equal("new(0f, 0f)", (firstChild.Properties[7].Value as SharpCodeNode)?.Code);
        Assert.Equal("rotationAngle", firstChild.Properties[8].Name);
        Assert.Equal("0f", (firstChild.Properties[8].Value as SharpCodeNode)?.Code);
        Assert.Equal("rotationAngleInDegrees", firstChild.Properties[9].Name);
        Assert.Equal("0f", (firstChild.Properties[9].Value as SharpCodeNode)?.Code);
        Assert.Equal("scale", firstChild.Properties[10].Name);
        Assert.Equal("new(1f, 1f)", (firstChild.Properties[10].Value as SharpCodeNode)?.Code);
        Assert.Equal("transformMatrix", firstChild.Properties[11].Name);
        Assert.Equal("new(0f, 0f, 0f, 0f, 0f, 0f)", (firstChild.Properties[11].Value as SharpCodeNode)?.Code);
        Assert.Equal("endPoint", firstChild.Properties[12].Name);
        Assert.Equal("new(1f, 1f)", (firstChild.Properties[12].Value as SharpCodeNode)?.Code);
        Assert.Equal("startPoint", firstChild.Properties[13].Name);
        Assert.Equal("new(0f, 0f)", (firstChild.Properties[13].Value as SharpCodeNode)?.Code);
    }
}