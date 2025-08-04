using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class SurfaceBrushTest() : TestBase("ProviderTests/SurfaceBrushTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("SurfaceBrush", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(14, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("SurfaceBrush", (firstChild.Properties[0].Value as StringLiteralNode)?.Content);
        Assert.Equal("anchorPoint", firstChild.Properties[1].Name);
        Assert.Equal("0", (firstChild.Properties[1].Value as StringLiteralNode)?.Content);
        Assert.Equal("bitmapInterpolationMode", firstChild.Properties[2].Name);
        Assert.Equal("Linear", (firstChild.Properties[2].Value as StringLiteralNode)?.Content);
        Assert.Equal("centerPoint", firstChild.Properties[3].Name);
        Assert.Equal("0", (firstChild.Properties[3].Value as StringLiteralNode)?.Content);
        Assert.Equal("horizontalAlignmentRatio", firstChild.Properties[4].Name);
        Assert.Equal("0.5", (firstChild.Properties[4].Value as StringLiteralNode)?.Content);
        Assert.Equal("offset", firstChild.Properties[5].Name);
        Assert.Equal("0", (firstChild.Properties[5].Value as StringLiteralNode)?.Content);
        Assert.Equal("rotationAngle", firstChild.Properties[6].Name);
        Assert.Equal("0", (firstChild.Properties[6].Value as StringLiteralNode)?.Content);
        Assert.Equal("rotationAngleInDegrees", firstChild.Properties[7].Name);
        Assert.Equal("0", (firstChild.Properties[7].Value as StringLiteralNode)?.Content);
        Assert.Equal("scale", firstChild.Properties[8].Name);
        Assert.Equal("1", (firstChild.Properties[8].Value as StringLiteralNode)?.Content);
        Assert.Equal("snapToPixels", firstChild.Properties[9].Name);
        Assert.Equal("false", (firstChild.Properties[9].Value as StringLiteralNode)?.Content);
        Assert.Equal("stretch", firstChild.Properties[10].Name);
        Assert.Equal("None", (firstChild.Properties[10].Value as StringLiteralNode)?.Content);
        Assert.Equal("surface", firstChild.Properties[11].Name);
        Assert.Equal("_compositor.CreateVisualSurface()", (firstChild.Properties[11].Value as SharpCodeNode)?.Code);
        Assert.Equal("transformMatrix", firstChild.Properties[12].Name);
        Assert.Equal("1,0,0 1,0,0", (firstChild.Properties[12].Value as StringLiteralNode)?.Content);
        Assert.Equal("verticalAlignmentRatio", firstChild.Properties[13].Name);
        Assert.Equal("0.5", (firstChild.Properties[13].Value as StringLiteralNode)?.Content);
    }
}