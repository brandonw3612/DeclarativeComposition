using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class ColorBrushTest() : TestBase("ProviderTests/ColorBrushTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("ColorBrush", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(2, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("\"ColorBrush\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("color", firstChild.Properties[1].Name);
        Assert.Equal("Microsoft.UI.Colors.Red", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
    }
}