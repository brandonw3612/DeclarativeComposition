<h1 align='center'>
  <image src='assets/vsce-icon.png' width='64' />
  <br/>
  Declarative Composition
  <br/>
  <a href="https://github.com/brandonw3612/DeclarativeComposition/blob/main/LICENSE">
    <img alt="GitHub" src="https://img.shields.io/github/license/brandonw3612/DeclarativeComposition?label=License">
  </a>
  <a href="https://www.nuget.org/packages/DeclarativeComposition">
    <img alt="NuGet (with prereleases)" src="https://img.shields.io/nuget/vpre/DeclarativeComposition?logo=nuget&label=NuGet%20Package&labelColor=004880">
  </a>
  <a href="https://marketplace.visualstudio.com/items?itemName=brandonw3612.declarative-composition-language-support">
    <img alt="Visual Studio Marketplace Version" src="https://img.shields.io/visual-studio-marketplace/v/brandonw3612.declarative-composition-language-support?include_prereleases&logo=vscodium&logoColor=ffffff&label=VSCode%20Extension&labelColor=1f9cf0">
  </a>
</h1>

Tired of wiring up all the components in your visual tree? Declarative Composition is here to help you simplify the construction of the WinUI visual layer using a clean, declarative syntax.

## Features

* **Declarative DSL**: Write clear and readable declarations for defining visual hierarchies.
* **C# Source Generator**: Directly call the automatically generated C# code for your visual tree.
* **Type-Aware Syntax**: Built-in support for nested visuals and inline C# expressions. *(And more on the way!)*
* **Anonymous Objects**: Stop having to name every component in your visual tree. Only name the ones you need, and let the rest be anonymous.

## Usage

Add the following package reference to the `DeclarativeComposition` NuGet package in your WinUI project.

```xml
<PackageReference Include="MyCompany.MyCodeGenerator" Version="0.2.1-alpha"
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
    .size = "800, 600"
    .offset = "400 300 0"
    SpriteVisual {
        .relativeSizeAdjustment = "1"
        .brush = _backgroundBrush : ColorBrush {
            .color = "#3fbfbfbf"
        }
    }
    _foregroundVisual: SpriteVisual {
        .relativeSizeAdjustment = "0.9 1"
        .brush = ColorBrush {
            .color = "#BF7F7F7F"
        }
    }   
    .clip = GeometricClip {
        .geometry = _clipGeometry : RoundedRectangleGeometry {
            .cornerRadius = "4"
            .size = "800 600"
        }
    }
}
```