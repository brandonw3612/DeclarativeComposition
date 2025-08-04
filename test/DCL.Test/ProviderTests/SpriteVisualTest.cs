using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class SpriteVisualTest() : TestBase("ProviderTests/SpriteVisualTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("SpriteVisual", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Equal(24, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("SpriteVisual", (firstChild.Properties[0].Value as StringLiteralNode)?.Content);
        Assert.Equal("anchorPoint", firstChild.Properties[1].Name);
        Assert.Equal("0", (firstChild.Properties[1].Value as StringLiteralNode)?.Content);
        Assert.Equal("backfaceVisibility", firstChild.Properties[2].Name);
        Assert.Equal("Inherit", (firstChild.Properties[2].Value as StringLiteralNode)?.Content);
        Assert.Equal("borderMode", firstChild.Properties[3].Name);
        Assert.Equal("Inherit", (firstChild.Properties[3].Value as StringLiteralNode)?.Content);
        Assert.Equal("centerPoint", firstChild.Properties[4].Name);
        Assert.Equal("0", (firstChild.Properties[4].Value as StringLiteralNode)?.Content);
        Assert.Equal("clip", firstChild.Properties[5].Name);
        Assert.Equal("_compositor.CreateRectangleClip()", (firstChild.Properties[5].Value as SharpCodeNode)?.Code);
        Assert.Equal("compositeMode", firstChild.Properties[6].Name);
        Assert.Equal("Inherit", (firstChild.Properties[6].Value as StringLiteralNode)?.Content);
        Assert.Equal("isHitTestVisible", firstChild.Properties[7].Name);
        Assert.Equal("false", (firstChild.Properties[7].Value as StringLiteralNode)?.Content);
        Assert.Equal("isPixelSnappingEnabled", firstChild.Properties[8].Name);
        Assert.Equal("false", (firstChild.Properties[8].Value as StringLiteralNode)?.Content);
        Assert.Equal("isVisible", firstChild.Properties[9].Name);
        Assert.Equal("true", (firstChild.Properties[9].Value as StringLiteralNode)?.Content);
        Assert.Equal("offset", firstChild.Properties[10].Name);
        Assert.Equal("0", (firstChild.Properties[10].Value as StringLiteralNode)?.Content);
        Assert.Equal("opacity", firstChild.Properties[11].Name);
        Assert.Equal("1", (firstChild.Properties[11].Value as StringLiteralNode)?.Content);
        Assert.Equal("orientation", firstChild.Properties[12].Name);
        Assert.Equal("0", (firstChild.Properties[12].Value as StringLiteralNode)?.Content);
        Assert.Equal("parentForTransform", firstChild.Properties[13].Name);
        Assert.Equal("_compositor.CreateSpriteVisual()", (firstChild.Properties[13].Value as SharpCodeNode)?.Code);
        Assert.Equal("relativeOffsetAdjustment", firstChild.Properties[14].Name);
        Assert.Equal("0", (firstChild.Properties[14].Value as StringLiteralNode)?.Content);
        Assert.Equal("relativeSizeAdjustment", firstChild.Properties[15].Name);
        Assert.Equal("1", (firstChild.Properties[15].Value as StringLiteralNode)?.Content);
        Assert.Equal("rotationAngle", firstChild.Properties[16].Name);
        Assert.Equal("0", (firstChild.Properties[16].Value as StringLiteralNode)?.Content);
        Assert.Equal("rotationAngleInDegrees", firstChild.Properties[17].Name);
        Assert.Equal("0", (firstChild.Properties[17].Value as StringLiteralNode)?.Content);
        Assert.Equal("rotationAxis", firstChild.Properties[18].Name);
        Assert.Equal("0 0 1", (firstChild.Properties[18].Value as StringLiteralNode)?.Content);
        Assert.Equal("scale", firstChild.Properties[19].Name);
        Assert.Equal("1", (firstChild.Properties[19].Value as StringLiteralNode)?.Content);
        Assert.Equal("size", firstChild.Properties[20].Name);
        Assert.Equal("1000 800", (firstChild.Properties[20].Value as StringLiteralNode)?.Content);
        Assert.Equal("transformMatrix", firstChild.Properties[21].Name);
        Assert.Equal("1,0,0 1,0,0", (firstChild.Properties[21].Value as StringLiteralNode)?.Content);
        Assert.Equal("brush", firstChild.Properties[22].Name);
        Assert.Equal("_compositor.CreateColorBrush()", (firstChild.Properties[22].Value as SharpCodeNode)?.Code);
        Assert.Equal("shadow", firstChild.Properties[23].Name);
        Assert.Equal("_compositor.CreateDropShadow()", (firstChild.Properties[23].Value as SharpCodeNode)?.Code);
        
        // Verify the children of the first child node
        Assert.Equal(2, firstChild.Children.Count);
        Assert.Equal("SpriteVisual", firstChild.Children[0].Type);
        Assert.Null(firstChild.Children[0].Name);
        Assert.Equal("SpriteVisual", firstChild.Children[1].Type);
        Assert.Null(firstChild.Children[1].Name);
    }
}