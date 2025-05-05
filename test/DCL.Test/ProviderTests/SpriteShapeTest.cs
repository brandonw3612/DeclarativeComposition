using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class SpriteShapeTest() : TestBase("ProviderTests/SpriteShapeTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("SpriteShape", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(19, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("\"SpriteShape\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("centerPoint", firstChild.Properties[1].Name);
        Assert.Equal("new(0f, 0f)", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("offset", firstChild.Properties[2].Name);
        Assert.Equal("new(0f, 0f)", (firstChild.Properties[2].Value as SharpCodeNode)?.Code);
        Assert.Equal("rotationAngle", firstChild.Properties[3].Name);
        Assert.Equal("0f", (firstChild.Properties[3].Value as SharpCodeNode)?.Code);
        Assert.Equal("rotationAngleInDegrees", firstChild.Properties[4].Name);
        Assert.Equal("0f", (firstChild.Properties[4].Value as SharpCodeNode)?.Code);
        Assert.Equal("scale", firstChild.Properties[5].Name);
        Assert.Equal("new(1f, 1f)", (firstChild.Properties[5].Value as SharpCodeNode)?.Code);
        Assert.Equal("transformMatrix", firstChild.Properties[6].Name);
        Assert.Equal("new(1f, 0f, 0f, 1f, 0f, 0f)", (firstChild.Properties[6].Value as SharpCodeNode)?.Code);
        Assert.Equal("fillBrush", firstChild.Properties[7].Name);
        Assert.Equal("_compositor.CreateColorBrush()", (firstChild.Properties[7].Value as SharpCodeNode)?.Code);
        Assert.Equal("geometry", firstChild.Properties[8].Name);
        Assert.Equal("_compositor.CreateRectangleGeometry()", (firstChild.Properties[8].Value as SharpCodeNode)?.Code);
        Assert.Equal("isStrokeNonScaling", firstChild.Properties[9].Name);
        Assert.Equal("true", (firstChild.Properties[9].Value as SharpCodeNode)?.Code);
        Assert.Equal("strokeBrush", firstChild.Properties[10].Name);
        Assert.Equal("_compositor.CreateColorBrush()", (firstChild.Properties[10].Value as SharpCodeNode)?.Code);
        Assert.Equal("strokeDashArray", firstChild.Properties[11].Name);
        Assert.Equal("new()", (firstChild.Properties[11].Value as SharpCodeNode)?.Code);
        Assert.Equal("strokeDashCap", firstChild.Properties[12].Name);
        Assert.Equal("Microsoft.UI.Composition.CompositionStrokeCap.Flat", (firstChild.Properties[12].Value as SharpCodeNode)?.Code);
        Assert.Equal("strokeDashOffset", firstChild.Properties[13].Name);
        Assert.Equal("0f", (firstChild.Properties[13].Value as SharpCodeNode)?.Code);
        Assert.Equal("strokeEndCap", firstChild.Properties[14].Name);
        Assert.Equal("Microsoft.UI.Composition.CompositionStrokeCap.Flat", (firstChild.Properties[14].Value as SharpCodeNode)?.Code);
        Assert.Equal("strokeLineJoin", firstChild.Properties[15].Name);
        Assert.Equal("Microsoft.UI.Composition.CompositionStrokeLineJoin.Miter", (firstChild.Properties[15].Value as SharpCodeNode)?.Code);
        Assert.Equal("strokeMiterLimit", firstChild.Properties[16].Name);
        Assert.Equal("0f", (firstChild.Properties[16].Value as SharpCodeNode)?.Code);
        Assert.Equal("strokeStartCap", firstChild.Properties[17].Name);
        Assert.Equal("Microsoft.UI.Composition.CompositionStrokeCap.Flat", (firstChild.Properties[17].Value as SharpCodeNode)?.Code);
        Assert.Equal("strokeThickness", firstChild.Properties[18].Name);
        Assert.Equal("1f", (firstChild.Properties[18].Value as SharpCodeNode)?.Code);
    }
}