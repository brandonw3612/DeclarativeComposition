using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.ProviderTests;

public class ColorGradientStopTest() : TestBase("ProviderTests/ColorGradientStopTest")
{
    protected override void VerifyAst(RootNode root)
    {
        // Verify the root node
        Assert.NotNull(root);
        Assert.Single(root.Body);

        // Verify the first child node
        var firstChild = root.Body[0];
        Assert.Equal("ColorGradientStop", firstChild.Type);
        Assert.Null(firstChild.Name);
        Assert.Empty(firstChild.Children);
        Assert.Equal(3, firstChild.Properties.Count);
        
        // Verify the properties of the first child node
        Assert.Equal("comment", firstChild.Properties[0].Name);
        Assert.Equal("\"ColorGradientStop\"", (firstChild.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("color", firstChild.Properties[1].Name);
        Assert.Equal("Microsoft.UI.Colors.White", (firstChild.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("offset", firstChild.Properties[2].Name);
        Assert.Equal("0f", (firstChild.Properties[2].Value as SharpCodeNode)?.Code);
    }
}