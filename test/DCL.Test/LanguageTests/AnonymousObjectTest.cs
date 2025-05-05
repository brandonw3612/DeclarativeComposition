using DeclarativeComposition.DCL.AST;

namespace DCL.Test.LanguageTests;

public class AnonymousObjectTest() : Primitives.TestBase("LanguageTests/AnonymousObjectTest")
{
    protected override void VerifyAst(RootNode root)
    {
        Assert.NotNull(root);
        Assert.NotNull(root.Declaration);
        Assert.Single(root.Body);
        
        var anonymousVisual = root.Body[0];
        Assert.NotNull(anonymousVisual);
        Assert.Null(anonymousVisual.Name);
        Assert.Equal("SpriteVisual", anonymousVisual.Type);
        Assert.Single(anonymousVisual.Properties);
        
        Assert.Equal("brush", anonymousVisual.Properties[0].Name);
        var anonymousBrush = anonymousVisual.Properties[0].Value as ObjectNode;
        Assert.NotNull(anonymousBrush);
        Assert.Equal("ColorBrush", anonymousBrush.Type);
        Assert.Single(anonymousBrush.Properties);
        Assert.Equal("color", anonymousBrush.Properties[0].Name);
        Assert.Equal("Microsoft.UI.Colors.Red", (anonymousBrush.Properties[0].Value as SharpCodeNode)?.Code);
    }
}