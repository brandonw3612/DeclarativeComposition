using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class NineGridBrushTest() : TestBase("ProviderTests/NineGridBrushTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("NineGridBrush", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(11, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("\"NineGridBrush\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("bottomInset", firstChild.Properties[1].Name);
        Assert.Equal("0f", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("bottomInsetScale", firstChild.Properties[2].Name);
        Assert.Equal("1f", (firstChild.Properties[2].Value as SharpCodeNode)?.Code);
        Assert.Equal("isCenterHollow", firstChild.Properties[3].Name);
        Assert.Equal("true", (firstChild.Properties[3].Value as SharpCodeNode)?.Code);
        Assert.Equal("leftInset", firstChild.Properties[4].Name);
        Assert.Equal("0f", (firstChild.Properties[4].Value as SharpCodeNode)?.Code);
        Assert.Equal("leftInsetScale", firstChild.Properties[5].Name);
        Assert.Equal("1f", (firstChild.Properties[5].Value as SharpCodeNode)?.Code);
        Assert.Equal("rightInset", firstChild.Properties[6].Name);
        Assert.Equal("0f", (firstChild.Properties[6].Value as SharpCodeNode)?.Code);
        Assert.Equal("rightInsetScale", firstChild.Properties[7].Name);
        Assert.Equal("source", firstChild.Properties[8].Name);
        Assert.Equal("_compositor.CreateColorBrush()", (firstChild.Properties[8].Value as SharpCodeNode)?.Code);
        Assert.Equal("topInset", firstChild.Properties[9].Name);
        Assert.Equal("0f", (firstChild.Properties[9].Value as SharpCodeNode)?.Code);
        Assert.Equal("topInsetScale", firstChild.Properties[10].Name);
        Assert.Equal("1f", (firstChild.Properties[10].Value as SharpCodeNode)?.Code);
    }
}