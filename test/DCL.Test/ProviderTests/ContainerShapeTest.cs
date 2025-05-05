using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class ContainerShapeTest() : TestBase("ProviderTests/ContainerShapeTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("ContainerShape", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Equal(7, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("\"ContainerShape\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
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
        
        Assert.Equal(2, firstChild.Children.Count);
        Assert.Equal("SpriteShape", firstChild.Children[0].Type);
        Assert.Null(firstChild.Children[0].Name);
        Assert.Equal("SpriteShape", firstChild.Children[1].Type);
        Assert.Null(firstChild.Children[1].Name);
    }
}