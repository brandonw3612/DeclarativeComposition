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
        Assert.Equal("\"SurfaceBrush\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("anchorPoint", firstChild.Properties[1].Name);
        Assert.Equal("new(0f, 0f)", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("bitmapInterpolationMode", firstChild.Properties[2].Name);
        Assert.Equal("Microsoft.UI.Composition.CompositionBitmapInterpolationMode.Linear", (firstChild.Properties[2].Value as SharpCodeNode)?.Code);
        Assert.Equal("centerPoint", firstChild.Properties[3].Name);
        Assert.Equal("new(0f, 0f)", (firstChild.Properties[3].Value as SharpCodeNode)?.Code);
        Assert.Equal("horizontalAlignmentRatio", firstChild.Properties[4].Name);
        Assert.Equal("0.5f", (firstChild.Properties[4].Value as SharpCodeNode)?.Code);
        Assert.Equal("offset", firstChild.Properties[5].Name);
        Assert.Equal("new(0f, 0f)", (firstChild.Properties[5].Value as SharpCodeNode)?.Code);
        Assert.Equal("rotationAngle", firstChild.Properties[6].Name);
        Assert.Equal("0f", (firstChild.Properties[6].Value as SharpCodeNode)?.Code);
        Assert.Equal("rotationAngleInDegrees", firstChild.Properties[7].Name);
        Assert.Equal("0f", (firstChild.Properties[7].Value as SharpCodeNode)?.Code);
        Assert.Equal("scale", firstChild.Properties[8].Name);
        Assert.Equal("new(1f, 1f)", (firstChild.Properties[8].Value as SharpCodeNode)?.Code);
        Assert.Equal("snapToPixels", firstChild.Properties[9].Name);
        Assert.Equal("false", (firstChild.Properties[9].Value as SharpCodeNode)?.Code);
        Assert.Equal("stretch", firstChild.Properties[10].Name);
        Assert.Equal("Microsoft.UI.Composition.CompositionStretch.None", (firstChild.Properties[10].Value as SharpCodeNode)?.Code);
        Assert.Equal("surface", firstChild.Properties[11].Name);
        Assert.Equal("_compositor.CreateVisualSurface()", (firstChild.Properties[11].Value as SharpCodeNode)?.Code);
        Assert.Equal("transformMatrix", firstChild.Properties[12].Name);
        Assert.Equal("new(1f, 0f, 0f, 1f, 0f, 0f)", (firstChild.Properties[12].Value as SharpCodeNode)?.Code);
        Assert.Equal("verticalAlignmentRatio", firstChild.Properties[13].Name);
        Assert.Equal("0.5f", (firstChild.Properties[13].Value as SharpCodeNode)?.Code);
    }
}