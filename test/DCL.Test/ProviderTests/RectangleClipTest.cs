using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class RectangleClipTest() : TestBase("ProviderTests/RectangleClipTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("RectangleClip", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(16, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("RectangleClip", (firstChild.Properties[0].Value as StringLiteralNode)?.Content);
        Assert.Equal("anchorPoint", firstChild.Properties[1].Name);
        Assert.Equal("0", (firstChild.Properties[1].Value as StringLiteralNode)?.Content);
        Assert.Equal("centerPoint", firstChild.Properties[2].Name);
        Assert.Equal("0", (firstChild.Properties[2].Value as StringLiteralNode)?.Content);
        Assert.Equal("offset", firstChild.Properties[3].Name);
        Assert.Equal("0", (firstChild.Properties[3].Value as StringLiteralNode)?.Content);
        Assert.Equal("rotationAngle", firstChild.Properties[4].Name);
        Assert.Equal("0", (firstChild.Properties[4].Value as StringLiteralNode)?.Content);
        Assert.Equal("rotationAngleInDegrees", firstChild.Properties[5].Name);
        Assert.Equal("0", (firstChild.Properties[5].Value as StringLiteralNode)?.Content);
        Assert.Equal("scale", firstChild.Properties[6].Name);
        Assert.Equal("1", (firstChild.Properties[6].Value as StringLiteralNode)?.Content);
        Assert.Equal("transformMatrix", firstChild.Properties[7].Name);
        Assert.Equal("1,0,0 1,0,0", (firstChild.Properties[7].Value as StringLiteralNode)?.Content);
        Assert.Equal("bottom", firstChild.Properties[8].Name);
        Assert.Equal("0", (firstChild.Properties[8].Value as StringLiteralNode)?.Content);
        Assert.Equal("bottomLeftRadius", firstChild.Properties[9].Name);
        Assert.Equal("0", (firstChild.Properties[9].Value as StringLiteralNode)?.Content);
        Assert.Equal("bottomRightRadius", firstChild.Properties[10].Name);
        Assert.Equal("0", (firstChild.Properties[10].Value as StringLiteralNode)?.Content);
        Assert.Equal("left", firstChild.Properties[11].Name);
        Assert.Equal("0", (firstChild.Properties[11].Value as StringLiteralNode)?.Content);
        Assert.Equal("right", firstChild.Properties[12].Name);
        Assert.Equal("0", (firstChild.Properties[12].Value as StringLiteralNode)?.Content);
        Assert.Equal("top", firstChild.Properties[13].Name);
        Assert.Equal("0", (firstChild.Properties[13].Value as StringLiteralNode)?.Content);
        Assert.Equal("topLeftRadius", firstChild.Properties[14].Name);
        Assert.Equal("0", (firstChild.Properties[14].Value as StringLiteralNode)?.Content);
        Assert.Equal("topRightRadius", firstChild.Properties[15].Name);
        Assert.Equal("0", (firstChild.Properties[15].Value as StringLiteralNode)?.Content);
    }
}