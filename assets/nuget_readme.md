# Declarative Composition

Tired of wiring up all the components in your visual tree? Declarative Composition is here to help you simplify the construction of the WinUI visual layer using a clean, declarative syntax.

## Features

* **Declarative DSL**: Write clear and readable declarations for defining visual hierarchies.
* **C# Source Generator**: Directly call the automatically generated C# code for your visual tree.
* **Type-Aware Syntax**: Built-in support for nested visuals and inline C# expressions. *(And more on the way!)*
* **Anonymous Objects**: Stop having to name every component in your visual tree. Only name the ones you need, and let the rest be anonymous.

## Usage

Add the following package reference to the `DeclarativeComposition` NuGet package in your WinUI project.

```xml
<PackageReference Include="MyCompany.MyCodeGenerator" Version="0.1.3-alpha"
                  OutputItemType="Analyzer"
                  ReferenceOutputAssembly="false" />
```

The package includes a C# source generator that will automatically generate the necessary code for your visual tree based on the declarative syntax you define.

## Documentation

*WIP*

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