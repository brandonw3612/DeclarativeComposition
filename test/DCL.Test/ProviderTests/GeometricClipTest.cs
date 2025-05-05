using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class GeometricClipTest() : TestBase("ProviderTests/GeometricClipTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("GeometricClip", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(10, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("\"GeometricClip\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("anchorPoint", firstChild.Properties[1].Name);
        Assert.Equal("new(0f, 0f)", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("centerPoint", firstChild.Properties[2].Name);
        Assert.Equal("new(0f, 0f)", (firstChild.Properties[2].Value as SharpCodeNode)?.Code);
        Assert.Equal("offset", firstChild.Properties[3].Name);
        Assert.Equal("new(0f, 0f)", (firstChild.Properties[3].Value as SharpCodeNode)?.Code);
        Assert.Equal("rotationAngle", firstChild.Properties[4].Name);
        Assert.Equal("0f", (firstChild.Properties[4].Value as SharpCodeNode)?.Code);
        Assert.Equal("rotationAngleInDegrees", firstChild.Properties[5].Name);
        Assert.Equal("0f", (firstChild.Properties[5].Value as SharpCodeNode)?.Code);
        Assert.Equal("scale", firstChild.Properties[6].Name);
        Assert.Equal("new(1f, 1f)", (firstChild.Properties[6].Value as SharpCodeNode)?.Code);
        Assert.Equal("transformMatrix", firstChild.Properties[7].Name);
        Assert.Equal("new(1f, 0f, 0f, 1f, 0f, 0f)", (firstChild.Properties[7].Value as SharpCodeNode)?.Code);
        Assert.Equal("geometry", firstChild.Properties[8].Name);
        Assert.Equal("_compositor.CreateRectangleGeometry()", (firstChild.Properties[8].Value as SharpCodeNode)?.Code);
        Assert.Equal("viewBox", firstChild.Properties[9].Name);
        Assert.Equal("_compositor.CreateViewBox()", (firstChild.Properties[9].Value as SharpCodeNode)?.Code);
    }
}