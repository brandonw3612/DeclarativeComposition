using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class SceneVisualTest() : TestBase("ProviderTests/SceneVisualTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("SceneVisual", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(23, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("\"SceneVisual\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("anchorPoint", firstChild.Properties[1].Name);
        Assert.Equal("new(0f, 0f)", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("backfaceVisibility", firstChild.Properties[2].Name);
        Assert.Equal("Microsoft.UI.Composition.CompositionBackfaceVisibility.Inherit", (firstChild.Properties[2].Value as SharpCodeNode)?.Code);
        Assert.Equal("borderMode", firstChild.Properties[3].Name);
        Assert.Equal("Microsoft.UI.Composition.CompositionBorderMode.Inherit", (firstChild.Properties[3].Value as SharpCodeNode)?.Code);
        Assert.Equal("centerPoint", firstChild.Properties[4].Name);
        Assert.Equal("new(0f, 0f, 0f)", (firstChild.Properties[4].Value as SharpCodeNode)?.Code);
        Assert.Equal("clip", firstChild.Properties[5].Name);
        Assert.Equal("_compositor.CreateRectangleClip()", (firstChild.Properties[5].Value as SharpCodeNode)?.Code);
        Assert.Equal("compositeMode", firstChild.Properties[6].Name);
        Assert.Equal("Microsoft.UI.Composition.CompositionCompositeMode.Inherit", (firstChild.Properties[6].Value as SharpCodeNode)?.Code);
        Assert.Equal("isHitTestVisible", firstChild.Properties[7].Name);
        Assert.Equal("false", (firstChild.Properties[7].Value as SharpCodeNode)?.Code);
        Assert.Equal("isPixelSnappingEnabled", firstChild.Properties[8].Name);
        Assert.Equal("false", (firstChild.Properties[8].Value as SharpCodeNode)?.Code);
        Assert.Equal("isVisible", firstChild.Properties[9].Name);
        Assert.Equal("true", (firstChild.Properties[9].Value as SharpCodeNode)?.Code);
        Assert.Equal("offset", firstChild.Properties[10].Name);
        Assert.Equal("new(0f, 0f, 0f)", (firstChild.Properties[10].Value as SharpCodeNode)?.Code);
        Assert.Equal("opacity", firstChild.Properties[11].Name);
        Assert.Equal("1f", (firstChild.Properties[11].Value as SharpCodeNode)?.Code);
        Assert.Equal("orientation", firstChild.Properties[12].Name);
        Assert.Equal("new(0f, 0f, 0f, 0f)", (firstChild.Properties[12].Value as SharpCodeNode)?.Code);
        Assert.Equal("parentForTransform", firstChild.Properties[13].Name);
        Assert.Equal("_compositor.CreateSpriteVisual()", (firstChild.Properties[13].Value as SharpCodeNode)?.Code);
        Assert.Equal("relativeOffsetAdjustment", firstChild.Properties[14].Name);
        Assert.Equal("new(0f, 0f, 0f)", (firstChild.Properties[14].Value as SharpCodeNode)?.Code);
        Assert.Equal("relativeSizeAdjustment", firstChild.Properties[15].Name);
        Assert.Equal("new(1f, 1f)", (firstChild.Properties[15].Value as SharpCodeNode)?.Code);
        Assert.Equal("rotationAngle", firstChild.Properties[16].Name);
        Assert.Equal("0f", (firstChild.Properties[16].Value as SharpCodeNode)?.Code);
        Assert.Equal("rotationAngleInDegrees", firstChild.Properties[17].Name);
        Assert.Equal("0f", (firstChild.Properties[17].Value as SharpCodeNode)?.Code);
        Assert.Equal("rotationAxis", firstChild.Properties[18].Name);
        Assert.Equal("new(0f, 0f, 1f)", (firstChild.Properties[18].Value as SharpCodeNode)?.Code);
        Assert.Equal("scale", firstChild.Properties[19].Name);
        Assert.Equal("new(1f, 1f, 1f)", (firstChild.Properties[19].Value as SharpCodeNode)?.Code);
        Assert.Equal("size", firstChild.Properties[20].Name);
        Assert.Equal("new(1000f, 800f)", (firstChild.Properties[20].Value as SharpCodeNode)?.Code);
        Assert.Equal("transformMatrix", firstChild.Properties[21].Name);
        Assert.Equal("new(new(1f, 0f, 0f, 1f, 0f, 0f))", (firstChild.Properties[21].Value as SharpCodeNode)?.Code);
        Assert.Equal("root", firstChild.Properties[22].Name);
        Assert.Equal("Microsoft.UI.Composition.Scenes.SceneNode.Create(_compositor)", (firstChild.Properties[22].Value as SharpCodeNode)?.Code);
    }
}