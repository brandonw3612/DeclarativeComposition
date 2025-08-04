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
        Assert.Equal("SpriteShape", (firstChild.Properties[0].Value as StringLiteralNode)?.Content);
        Assert.Equal("centerPoint", firstChild.Properties[1].Name);
        Assert.Equal("0", (firstChild.Properties[1].Value as StringLiteralNode)?.Content);
        Assert.Equal("offset", firstChild.Properties[2].Name);
        Assert.Equal("0", (firstChild.Properties[2].Value as StringLiteralNode)?.Content);
        Assert.Equal("rotationAngle", firstChild.Properties[3].Name);
        Assert.Equal("0", (firstChild.Properties[3].Value as StringLiteralNode)?.Content);
        Assert.Equal("rotationAngleInDegrees", firstChild.Properties[4].Name);
        Assert.Equal("0", (firstChild.Properties[4].Value as StringLiteralNode)?.Content);
        Assert.Equal("scale", firstChild.Properties[5].Name);
        Assert.Equal("1", (firstChild.Properties[5].Value as StringLiteralNode)?.Content);
        Assert.Equal("transformMatrix", firstChild.Properties[6].Name);
        Assert.Equal("1 0 0, 1 0 0", (firstChild.Properties[6].Value as StringLiteralNode)?.Content);
        Assert.Equal("fillBrush", firstChild.Properties[7].Name);
        Assert.Equal("_compositor.CreateColorBrush()", (firstChild.Properties[7].Value as SharpCodeNode)?.Code);
        Assert.Equal("geometry", firstChild.Properties[8].Name);
        Assert.Equal("_compositor.CreateRectangleGeometry()", (firstChild.Properties[8].Value as SharpCodeNode)?.Code);
        Assert.Equal("isStrokeNonScaling", firstChild.Properties[9].Name);
        Assert.Equal("true", (firstChild.Properties[9].Value as StringLiteralNode)?.Content);
        Assert.Equal("strokeBrush", firstChild.Properties[10].Name);
        Assert.Equal("_compositor.CreateColorBrush()", (firstChild.Properties[10].Value as SharpCodeNode)?.Code);
        Assert.Equal("strokeDashArray", firstChild.Properties[11].Name);
        Assert.IsType<CollectionNode>(firstChild.Properties[11].Value);
        var collection = (firstChild.Properties[11].Value as CollectionNode)!;
        Assert.Single(collection.Items);
        Assert.Equal("1", (collection.Items[0] as StringLiteralNode)?.Content);
        Assert.Equal("strokeDashCap", firstChild.Properties[12].Name);
        Assert.Equal("Flat", (firstChild.Properties[12].Value as StringLiteralNode)?.Content);
        Assert.Equal("strokeDashOffset", firstChild.Properties[13].Name);
        Assert.Equal("0", (firstChild.Properties[13].Value as StringLiteralNode)?.Content);
        Assert.Equal("strokeEndCap", firstChild.Properties[14].Name);
        Assert.Equal("Flat", (firstChild.Properties[14].Value as StringLiteralNode)?.Content);
        Assert.Equal("strokeLineJoin", firstChild.Properties[15].Name);
        Assert.Equal("Miter", (firstChild.Properties[15].Value as StringLiteralNode)?.Content);
        Assert.Equal("strokeMiterLimit", firstChild.Properties[16].Name);
        Assert.Equal("0", (firstChild.Properties[16].Value as StringLiteralNode)?.Content);
        Assert.Equal("strokeStartCap", firstChild.Properties[17].Name);
        Assert.Equal("Flat", (firstChild.Properties[17].Value as StringLiteralNode)?.Content);
        Assert.Equal("strokeThickness", firstChild.Properties[18].Name);
        Assert.Equal("1", (firstChild.Properties[18].Value as StringLiteralNode)?.Content);
    }
}