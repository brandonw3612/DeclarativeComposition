using DCL.Test.Primitives;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.LanguageTests;

public class NamedObjectTest() : TestBase("LanguageTests/NamedObjectTest")
{
    protected override void VerifyAst(RootNode root)
    {
        Assert.NotNull(root);
        Assert.NotNull(root.Declaration);
        Assert.Equal(2, root.Body.Count);

        var namedVisual = root.Body[0];
        Assert.NotNull(namedVisual);
        Assert.Equal("_rootVisual", namedVisual.Name);
        Assert.Equal("SpriteVisual", namedVisual.Type);
        Assert.Single(namedVisual.Properties);
        Assert.Equal("brush", namedVisual.Properties[0].Name);
        var namedBrush = namedVisual.Properties[0].Value as ObjectNode;
        Assert.NotNull(namedBrush);
        Assert.Equal("backgroundVisual", namedBrush.Name);
        Assert.Equal("ColorBrush", namedBrush.Type);
        Assert.Single(namedBrush.Properties);
        Assert.Equal("color", namedBrush.Properties[0].Name);
        Assert.Equal("Microsoft.UI.Colors.Red", (namedBrush.Properties[0].Value as SharpCodeNode)?.Code);

        var namedVisual2 = root.Body[1];
        Assert.NotNull(namedVisual2);
        Assert.Equal("ForegroundVisual", namedVisual2.Name);
        Assert.Equal("SpriteVisual", namedVisual2.Type);
        Assert.Equal(3, namedVisual2.Properties.Count);
        Assert.Equal("size", namedVisual2.Properties[0].Name);
        Assert.Equal("new(100f, 100f)", (namedVisual2.Properties[0].Value as SharpCodeNode)?.Code);
        Assert.Equal("offset", namedVisual2.Properties[1].Name);
        Assert.Equal("new(0f, 0f, 0f)", (namedVisual2.Properties[1].Value as SharpCodeNode)?.Code);
        Assert.Equal("opacity", namedVisual2.Properties[2].Name);
        Assert.Equal("0.5f", (namedVisual2.Properties[2].Value as SharpCodeNode)?.Code);
    }
}