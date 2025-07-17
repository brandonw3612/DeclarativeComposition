<h1 align='center'>
  <image src='https://raw.githubusercontent.com/brandonw3612/DeclarativeComposition/main/assets/vsce-icon.png' width='64' />
  <br/>
  Declarative Composition
  <br/>
  <a href="https://github.com/brandonw3612/DeclarativeComposition/blob/main/LICENSE">
    <img alt="GitHub" src="https://img.shields.io/github/license/brandonw3612/DeclarativeComposition?label=License">
  </a>
</h1>

Official language support for [Declarative Composition](https://github.com/brandonw3612/DeclarativeComposition).

## Usage

*Under development. Not published yet.*

## Documentation

*Under development. Not published yet.*

## Example

With Composition APIs, you can create a visual tree like this:

```csharp
// ...

_rootVisual = _compositor.CreateSpriteVisual();
_rootVisual.Size = new(800f, 600f);
_rootVisual.Offset = new(400f, 300f, 0f);

var backgroundVisual = _compositor.CreateSpriteVisual();
backgroundVisual.RelativeSizeAdjustment = new(1f, 1f);
_backgroundBrush = _compositor.CreateColorBrush();
_backgroundBrush.Color = Windows.UI.Color.FromArgb(0x3F, 0xBF, 0xBF, 0xBF);
backgroundVisual.Brush = _backgroundBrush;
_rootVisual.Children.InsertAtTop(backgroundVisual);

_foregroundVisual = _compositor.CreateSpriteVisual();
_foregroundVisual.RelativeSizeAdjustment = new(0.9f, 1f);
var foregroundBrush = _compositor.CreateColorBrush();
foregroundBrush.Color = Windows.UI.Color.FromArgb(0xBF, 0x7F, 0x7F, 0x7F);
_foregroundVisual.Brush = foregroundBrush;
_rootVisual.Children.InsertAtTop(_foregroundVisual);

var clip = _compositor.CreateGeometricClip();
_clipGeometry = _compositor.CreateRoundedRectangleGeometry();
_clipGeometry.CornerRadius = new(4f);
_clipGeometry.Size = new(800f, 600f);
clip.Geometry = _clipGeometry;
_rootVisual.Clip = clip;

// ...
```

It is sometimes exhausting to wire up every component, and naming always gives us headaches... With Declarative Composition, the equivalent visual tree can be defined as:

```
_rootVisual : SpriteVisual {
    .size = #"new(800f, 600f)"
    .offset = #"new(400f, 300f, 0f)"
    SpriteVisual {
        .relativeSizeAdjustment = #"new(1f, 1f)"
        .brush = _backgroundBrush : ColorBrush {
            .color = #"Windows.UI.Color.FromArgb(0x3F, 0xBF, 0xBF, 0xBF)"
        }
    }
    _foregroundVisual: SpriteVisual {
        .relativeSizeAdjustment = #"new(0.9f, 1f)"
        .brush = ColorBrush {
            .color = #"Windows.UI.Color.FromArgb(0xBF, 0x7F, 0x7F, 0x7F)"
        }
    }   
    .clip = GeometricClip {
        .geometry = _clipGeometry : RoundedRectangleGeometry {
            .cornerRadius = #"new(4f)"
            .size = #"new(800f, 600f)"
        }
    }
}
```