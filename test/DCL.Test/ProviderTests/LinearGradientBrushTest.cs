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
        Assert.Equal("LinearGradientBrush", (firstChild.Properties[0].Value as StringLiteralNode)?.Content);
        Assert.Equal("anchorPoint", firstChild.Properties[1].Name);
        Assert.Equal("0", (firstChild.Properties[1].Value as StringLiteralNode)?.Content);
        Assert.Equal("centerPoint", firstChild.Properties[2].Name);
        Assert.Equal("0", (firstChild.Properties[2].Value as StringLiteralNode)?.Content);
        Assert.Equal("colorStops", firstChild.Properties[3].Name);
        Assert.IsType<CollectionNode>(firstChild.Properties[3].Value);
        var colorStops = (firstChild.Properties[3].Value as CollectionNode)!;
        Assert.Single(colorStops.Items);
        Assert.Equal("_compositor.CreateColorGradientStop()", (colorStops.Items[0] as SharpCodeNode)?.Code);
        Assert.Equal("extendMode", firstChild.Properties[4].Name);
        Assert.Equal("Clamp", (firstChild.Properties[4].Value as StringLiteralNode)?.Content);
        Assert.Equal("interpolationSpace", firstChild.Properties[5].Name);
        Assert.Equal("Auto", (firstChild.Properties[5].Value as StringLiteralNode)?.Content);
        Assert.Equal("mappingMode", firstChild.Properties[6].Name);
        Assert.Equal("Absolute", (firstChild.Properties[6].Value as StringLiteralNode)?.Content);
        Assert.Equal("offset", firstChild.Properties[7].Name);
        Assert.Equal("0", (firstChild.Properties[7].Value as StringLiteralNode)?.Content);
        Assert.Equal("rotationAngle", firstChild.Properties[8].Name);
        Assert.Equal("0", (firstChild.Properties[8].Value as StringLiteralNode)?.Content);
        Assert.Equal("rotationAngleInDegrees", firstChild.Properties[9].Name);
        Assert.Equal("0", (firstChild.Properties[9].Value as StringLiteralNode)?.Content);
        Assert.Equal("scale", firstChild.Properties[10].Name);
        Assert.Equal("1", (firstChild.Properties[10].Value as StringLiteralNode)?.Content);
        Assert.Equal("transformMatrix", firstChild.Properties[11].Name);
        Assert.Equal("1,0,0 1,0,0", (firstChild.Properties[11].Value as StringLiteralNode)?.Content);
        Assert.Equal("endPoint", firstChild.Properties[12].Name);
        Assert.Equal("1", (firstChild.Properties[12].Value as StringLiteralNode)?.Content);
        Assert.Equal("startPoint", firstChild.Properties[13].Name);
        Assert.Equal("0", (firstChild.Properties[13].Value as StringLiteralNode)?.Content);
    }
}