using DeclarativeComposition.CodeGen.Interpreters.Composition;
using DeclarativeComposition.CodeGen.Interpreters.Sugar;

using COI = DeclarativeComposition.CodeGen.Interpreters.CompositionObjectInterpreter;
using COM = DeclarativeComposition.CSharp.CompositionObjectMeta;
using MFI = DeclarativeComposition.CodeGen.Interpreters.MethodFieldInterpreter;
using PFI = DeclarativeComposition.CodeGen.Interpreters.PropertyFieldInterpreter;

namespace DeclarativeComposition.CSharp;

/// <summary>
/// Metadata for .NET types used in Declarative Composition.
/// </summary>
public static class Metas
{
    /// <summary>
    /// Type metadata for <see cref="System.Object" />. <br/>
    /// Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy. <br/>
    /// More on <see href="https://learn.microsoft.com/dotnet/api/system.object">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta Obj = new(
        "System",
        "Object",
        null,
        new()
    );

    /// <summary>
    /// Type metadata for <see cref="System.Boolean" />. <br/>
    /// Represents a Boolean (true or false) value. <br/>
    /// More on <see href="https://learn.microsoft.com/dotnet/api/system.boolean">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta Bool = new(
        "System",
        "Boolean",
        Obj,
        new BoolInterpreter()
    );
    
    /// <summary>
    /// Type metadata for <see cref="System.Single" />. <br/>
    /// Represents a single-precision floating-point number. <br/>
    /// More on <see href="https://learn.microsoft.com/dotnet/api/system.single">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta Single = new(
        "System",
        "Single",
        Obj,
        new NumberInterpreter(NumberInterpreter.NumberType.Single)
    );
    
    /// <summary>
    /// Type metadata for <see cref="System.String" />. <br/>
    /// Represents text as a sequence of UTF-16 code units. <br/>
    /// More on <see href="https://learn.microsoft.com/dotnet/api/system.string">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta String = new(
        "System",
        "String",
        Obj,
        new StringInterpreter()
    );
    
    /// <summary>
    /// Type metadata for <see cref="System.Numerics.Vector2" />. <br/>
    /// Represents a vector with two single-precision floating-point values. <br/>
    /// More on <see href="https://learn.microsoft.com/dotnet/api/system.numerics.vector2">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta Vector2 = new(
        "System.Numerics",
        "Vector2",
        Obj,
        new VectorInterpreter(2, "Vector2")
    );
    
    /// <summary>
    /// Type metadata for <see cref="System.Numerics.Vector3" />. <br/>
    /// Represents a vector with three single-precision floating-point values. <br/>
    /// More on <see href="https://learn.microsoft.com/dotnet/api/system.numerics.vector3">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta Vector3 = new(
        "System.Numerics",
        "Vector3",
        Obj,
        new VectorInterpreter(3, "Vector3")
    );
    
    /// <summary>
    /// Type metadata for <see cref="System.Numerics.Quaternion" />. <br/>
    /// Represents a vector that is used to encode three-dimensional physical rotations. <br/>
    /// More on <see href="https://learn.microsoft.com/dotnet/api/system.numerics.quaternion">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta Quaternion = new(
        "System.Numerics",
        "Quaternion",
        Obj,
        new VectorInterpreter(4, "Quaternion")
    );
    
    /// <summary>
    /// Type metadata for <see cref="System.Numerics.Matrix3x2" />. <br/>
    /// Represents a 3x2 matrix. <br/>
    /// More on <see href="https://learn.microsoft.com/dotnet/api/system.numerics.matrix3x2">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta Matrix3X2 = new(
        "System.Numerics",
        "Matrix3x2",
        Obj,
        new MatrixInterpreter(3, 2)
    );
    
    /// <summary>
    /// Type metadata for <see cref="System.Numerics.Matrix4x4" />. <br/>
    /// Represents a 4x4 matrix. <br/>
    /// More on <see href="https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta Matrix4X4 = new(
        "System.Numerics",
        "Matrix4x4",
        Obj,
        new MatrixInterpreter(4, 4)
    );
    
    /// <summary>
    /// Type metadata for <see cref="Windows.UI.Color" />. <br/>
    /// Describes a color in terms of alpha, red, green, and blue channels. <br/>
    /// More on <see href="https://learn.microsoft.com/en-us/dotnet/api/windows.ui.color">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta Color = new(
        "Windows.UI",
        "Color",
        Obj,
        new ColorInterpreter()
    );

    /// <summary>
    /// Type metadata for <see cref="Microsoft.UI.Composition.CompositionGradientExtendMode" />. <br/>
    /// Defines constants that specify how to draw the gradient outside the brush's gradient vector or space. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositiongradientextendmode">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta GradientExtendMode = new(
        "Microsoft.UI.Composition",
        "CompositionGradientExtendMode",
        Obj,
        new EnumInterpreter(
            "Microsoft.UI.Composition",
            "CompositionGradientExtendMode",
            ["Clamp", "Wrap", "Mirror"]
        )
    );
    
    /// <summary>
    /// Type metadata for <see cref="Microsoft.UI.Composition.CompositionColorSpace" />. <br/>
    /// Specifies the color space for interpolating color values in ColorKeyFrameAnimation. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositioncolorspace">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta ColorSpace = new(
        "Microsoft.UI.Composition",
        "CompositionColorSpace",
        Obj,
        new EnumInterpreter(
            "Microsoft.UI.Composition",
            "CompositionColorSpace",
            ["Auto", "Hsl", "Rgb", "HslLinear", "RgbLinear"]
        )
    );
    
    /// <summary>
    /// Type metadata for <see cref="Microsoft.UI.Composition.CompositionMappingMode" />. <br/>
    /// Defines constants that specify whether the gradient brush's positioning coordinates (StartPoint, EndPoint) are absolute or relative to the output area. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionmappingmode">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta MappingMode = new(
        "Microsoft.UI.Composition",
        "CompositionMappingMode",
        Obj,
        new EnumInterpreter(
            "Microsoft.UI.Composition",
            "CompositionMappingMode",
            ["Absolute", "Relative"]
        )
    );

    /// <summary>
    /// Type metadata for <see cref="Microsoft.UI.Composition.CompositionBitmapInterpolationMode" />. <br/>
    /// Specifies the algorithm used for interpolating pixels from ICompositionSurface when they do not form a one-to-one mapping to pixels on screen. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionbitmapinterpolationmode">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta BitmapInterpolationMode = new(
        "Microsoft.UI.Composition",
        "CompositionBitmapInterpolationMode",
        Obj,
        new EnumInterpreter(
            "Microsoft.UI.Composition",
            "CompositionBitmapInterpolationMode",
            [
                "NearestNeighbor", "Linear", "MagLinearMinLinearMipLinear", "MagLinearMinLinearMipNearest",
                "MagLinearMinNearestMipLinear", "MagLinearMinNearestMipNearest", "MagNearestMinLinearMipLinear",
                "MagNearestMinLinearMipNearest", "MagNearestMinNearestMipLinear", "MagNearestMinNearestMipNearest"
            ]
        )
    );

    /// <summary>
    /// Type metadata for <see cref="Microsoft.UI.Composition.CompositionStretch" />. <br/>
    /// Specifies how content is scaled when mapped from its source to a destination space. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionstretch">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta Stretch = new(
        "Microsoft.UI.Composition",
        "CompositionStretch",
        Obj,
        new EnumInterpreter(
            "Microsoft.UI.Composition",
            "CompositionStretch",
            ["None", "Fill", "Uniform", "UniformToFill"]
        )
    );
    
    /// <summary>
    /// Type metadata for <see cref="Microsoft.UI.Composition.CompositionStrokeCap" />. <br/>
    /// Defines constants that specify the shape of the end of a line or segment. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionstrokecap">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta StrokeCap = new(
        "Microsoft.UI.Composition",
        "CompositionStrokeCap",
        Obj,
        new EnumInterpreter(
            "Microsoft.UI.Composition",
            "CompositionStrokeCap",
            ["Flat", "Square", "Round", "Triangle"]
        )
    );
    
    /// <summary>
    /// Type metadata for <see cref="Microsoft.UI.Composition.CompositionStrokeLineJoin" />. <br/>
    /// Defines constants that specify the shape used to join two lines or segments. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionstrokelinejoin">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta StrokeLineJoin = new(
        "Microsoft.UI.Composition",
        "CompositionStrokeLineJoin",
        Obj,
        new EnumInterpreter(
            "Microsoft.UI.Composition",
            "CompositionStrokeLineJoin",
            ["Miter", "Bevel", "Round", "MiterOrBevel"]
        )
    );
    
    /// <summary>
    /// Type metadata for <see cref="Microsoft.UI.Composition.CompositionBackfaceVisibility" />. <br/>
    /// Specifies whether the back face of a visual is visible during a 3D transform. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionbackfacevisibility">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta BackfaceVisibility = new(
        "Microsoft.UI.Composition",
        "CompositionBackfaceVisibility",
        Obj,
        new EnumInterpreter(
            "Microsoft.UI.Composition",
            "CompositionBackfaceVisibility",
            ["Inherit", "Visible", "Hidden"]
        )
    );
    
    /// <summary>
    /// Type metadata for <see cref="Microsoft.UI.Composition.CompositionBorderMode" />. <br/>
    /// Controls the aliasing behavior on the edges of visual borders. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionbordermode">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta BorderMode = new(
        "Microsoft.UI.Composition",
        "CompositionBorderMode",
        Obj,
        new EnumInterpreter(
            "Microsoft.UI.Composition",
            "CompositionBorderMode",
            ["Inherit", "Soft", "Hard"]
        )
    );
    
    /// <summary>
    /// Type metadata for <see cref="Microsoft.UI.Composition.CompositionCompositeMode" />. <br/>
    /// Determines how a non-opaque visual's content is blended with the background content behind the visual. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositioncompositemode">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta CompositeMode = new(
        "Microsoft.UI.Composition",
        "CompositionCompositeMode",
        Obj,
        new EnumInterpreter(
            "Microsoft.UI.Composition",
            "CompositionCompositeMode",
            ["Inherit", "SourceOver", "DestinationInvert", "MinBlend"]
        )
    );
    
    /// <summary>
    /// Type metadata for <see cref="Microsoft.UI.Composition.CompositionDropShadowSourcePolicy" />. <br/>
    /// Specifies the masking policy for a shadow. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositiondropshadowsourcepolicy">Microsoft Learn</see>.
    /// </summary>
    internal static readonly ObjectMeta DropShadowSourcePolicy = new(
        "Microsoft.UI.Composition",
        "CompositionDropShadowSourcePolicy",
        Obj,
        new EnumInterpreter(
            "Microsoft.UI.Composition",
            "CompositionDropShadowSourcePolicy",
            ["Default", "InheritFromVisualContent"]
        )
    );
    
    /// <summary>
    /// Type metadata for <see cref="Microsoft.UI.Composition.CompositionObject" />. <br/>
    /// Base class of the composition API representing a node in the visual tree structure. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionobject">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM CompositionObject = new(
        "CompositionObject",
        "Microsoft.UI.Composition",
        "CompositionObject",
        Obj,
        new(),
        [
            // A string to associate with the CompositionObject.
            new("Comment", [nameof(String)], new PFI("Comment"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionLight" />. <br/>
    /// Base class for a light source that can target a UI scene. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionlight">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM Light = new(
        "Light",
        "Microsoft.UI.Composition",
        "CompositionLight",
        CompositionObject,
        new(),
        [
            // A collection of Visuals that are not targeted by the light.
            new("ExclusionsFromTargets", [nameof(Visual)], new MFI("ExclusionsFromTargets.Add")),
            // A value that determines whether the composition light is on.
            new("IsEnabled", [nameof(Bool)], new PFI("IsEnabled")),
            // The collection of Visuals targeted by the light.
            new("Targets", [nameof(Visual)], new MFI("Targets.Add"))
        ],
        "Targets"
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.AmbientLight" />. <br/>
    /// A light that illuminates every targeted Visual equally. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.ambientlight">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM AmbientLight = new(
        "AmbientLight",
        "Microsoft.UI.Composition",
        "AmbientLight",
        Light,
        new COI("CreateAmbientLight"),
        [
            // Color of the light.
            new("Color", [nameof(Color)], new PFI("Color")),
            // The intensity of the light.
            new("Intensity", [nameof(Single)], new PFI("Intensity"))
        ],
        "Targets"
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.DistantLight" />. <br/>
    /// An infinitely large distant light source that emits light in a single direction. For example, a distant light could be used to represent sunlight. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.distantlight">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM DistantLight = new(
        "DistantLight",
        "Microsoft.UI.Composition",
        "DistantLight",
        Light,
        new COI("CreateDistantLight"),
        [
            // Color of the emitted DistantLight.
            new("Color", [nameof(Color)], new PFI("Color")),
            // The Visual used to determine the light’s direction. The light's Direction property is relative to this Visual’s coordinate space.
            new("CoordinateSpace", [nameof(Visual)], new PFI("CoordinateSpace")),
            // The direction in which the light is pointing, specified relative to its CoordinateSpace Visual.
            new("Direction", [nameof(Vector3)], new PFI("Direction")),
            // The intensity of the light.
            new("Intensity", [nameof(Single)], new PFI("Intensity"))
        ],
        "Targets"
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.PointLight" />. <br/>
    /// A point source of light that emanates light in all directions. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.pointlight">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM PointLight = new(
        "PointLight",
        "Microsoft.UI.Composition",
        "PointLight",
        Light,
        new COI("CreatePointLight"),
        [
            // Color of the light.
            new("Color", [nameof(Color)], new PFI("Color")),
            // The constant coefficient in the light's attenuation equation. Controls light intensity.
            new("ConstantAttenuation", [nameof(Single)], new PFI("ConstantAttenuation")),
            // The Visual used to determine the light's offset. The light's Offset property is relative to this Visual's coordinate space. PointLight.CoordinateSpace is a required property. If PointLight.CoordinateSpace is not set, the PointLight will not render.
            new("CoordinateSpace", [nameof(Visual)], new PFI("CoordinateSpace")),
            // The intensity of the light.
            new("Intensity", [nameof(Single)], new PFI("Intensity")),
            // The linear coefficient in the light's attenuation equation that determines how the light falls-off with distance.
            new("LinearAttenuation", [nameof(Single)], new PFI("LinearAttenuation")),
            // The maximum range at which this light is effective.
            new("MaxAttenuationCutoff", [nameof(Single)], new PFI("MaxAttenuationCutoff")),
            // The minimum range at which this light is effective.
            new("MinAttenuationCutoff", [nameof(Single)], new PFI("MinAttenuationCutoff")),
            // Offset of the light source relative to its CoordinateSpace Visual.
            new("Offset", [nameof(Vector3)], new PFI("Offset")),
            // The quadratic portion of the attenuation equation that determines how the light falls off with distance.
            new("QuadraticAttenuation", [nameof(Single)], new PFI("QuadraticAttenuation"))
        ],
        "Targets"
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.SpotLight" />. <br/>
    /// A light source that casts inner and outer cones of light. For example, a flashlight. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.spotlight">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM SpotLight = new(
        "SpotLight",
        "Microsoft.UI.Composition",
        "SpotLight",
        Light,
        new COI("CreateSpotLight"),
        [
            // The constant coefficient in the light's attenuation equation. Controls light intensity.
            new("ConstantAttenuation", [nameof(Single)], new PFI("ConstantAttenuation")),
            // The Visual used to determine the light's offset and direction. The light's Offset and Direction properties are relative to this Visual's coordinate space. SpotLight.CoordinateSpace is a required property. If SpotLight.CoordinateSpace is not set, the SpotLight will not render.
            new("CoordinateSpace", [nameof(Visual)], new PFI("CoordinateSpace")),
            // The direction in which the light is pointing, specified relative to its CoordinateSpace Visual.
            new("Direction", [nameof(Vector3)], new PFI("Direction")),
            // The SpotLight’s inner cone angle, expressed as a semi-vertical angle in radians.
            new("InnerConeAngle", [nameof(Single)], new PFI("InnerConeAngle")),
            // The SpotLight’s inner cone angle, expressed as a semi-vertical angle in degrees.
            new("InnerConeAngleInDegrees", [nameof(Single)], new PFI("InnerConeAngleInDegrees")),
            // Color of the spotlight's inner cone.
            new("InnerConeColor", [nameof(Color)], new PFI("InnerConeColor")),
            // The intensity of the light in the spotlight's inner cone.
            new("InnerConeIntensity", [nameof(Single)], new PFI("InnerConeIntensity")),
            // The linear coefficient in the light's attenuation equation that determines how the light falls off with distance.
            new("LinearAttenuation", [nameof(Single)], new PFI("LinearAttenuation")),
            // The maximum range at which this light is effective.
            new("MaxAttenuationCutoff", [nameof(Single)], new PFI("MaxAttenuationCutoff")),
            // The minimum range at which this light is effective.
            new("MinAttenuationCutoff", [nameof(Single)], new PFI("MinAttenuationCutoff")),
            // Offset of the light source relative to its CoordinateSpace Visual.
            new("Offset", [nameof(Vector3)], new PFI("Offset")),
            // The SpotLight’s outer cone angle, expressed as a semi-vertical angle in radians.
            new("OuterConeAngle", [nameof(Single)], new PFI("OuterConeAngle")),
            // The semi-vertical angle, in degrees, of the SpotLight's outer cone.
            new("OuterConeAngleInDegrees", [nameof(Single)], new PFI("OuterConeAngleInDegrees")),
            // The color of the spotlight's outer cone.
            new("OuterConeColor", [nameof(Color)], new PFI("OuterConeColor")),
            // The intensity of the light in the spotlight's outer cone.
            new("OuterConeIntensity", [nameof(Single)], new PFI("OuterConeIntensity")),
            // The quadratic portion of the attenuation equation that determines how the light falls off with distance.
            new("QuadraticAttenuation", [nameof(Single)], new PFI("QuadraticAttenuation"))
        ],
        "Targets"
    );

    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionBrush" />. <br/>
    /// Base class for brushes used to paint a SpriteVisual. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionbrush">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM Brush = new(
        "Brush",
        "Microsoft.UI.Composition",
        "CompositionBrush",
        CompositionObject,
        new(),
        []
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionBackdropBrush" />. <br/>
    /// A brush that applies an effect (or a chain of effects) to the region behind a SpriteVisual. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionbackdropbrush">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM BackdropBrush = new(
        "BackdropBrush",
        "Microsoft.UI.Composition",
        "CompositionBackdropBrush",
        Brush,
        new COI("CreateBackdropBrush"),
        []
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionColorBrush" />. <br/>
    /// Paints a SpriteVisual with a solid color. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositioncolorbrush">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM ColorBrush = new(
        "ColorBrush",
        "Microsoft.UI.Composition",
        "CompositionColorBrush",
        Brush,
        new COI("CreateColorBrush"),
        [
            // The color used to fill a SpriteVisual. Animatable.
            new("Color", [nameof(Color)], new PFI("Color"))
        ]
    );
    
    // /// <summary>
    // /// Provider for <see cref="Microsoft.UI.Composition.CompositionEffectBrush" />. <br/>
    // /// Paints a SpriteVisual with the output of a filter effect. The filter effect description is defined using the CompositionEffectFactory class. <br/>
    // /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositioneffectbrush">Microsoft Learn</see>.
    // /// </summary>
    // TODO: Constructor not implemented
    // internal static readonly COM EffectBrush = new(
    //     CompositionBrush,
    //     "Microsoft.UI.Composition",
    //     "CompositionEffectBrush",
    //     "_compositor.CreateEffectBrush()",
    //     new(),
    //     null
    // );

    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionGradientBrush" />. <br/>
    /// Represents a brush that describes a gradient, composed of gradient stops. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositiongradientbrush">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM GradientBrush = new(
        "GradientBrush",
        "Microsoft.UI.Composition",
        "CompositionGradientBrush",
        Brush,
        new(),
        [
            // The point on the brush to be positioned at the brush's offset.
            new("AnchorPoint", [nameof(Vector2)], new PFI("AnchorPoint")),
            // The point about which the brush is rotated and scaled.
            new("CenterPoint", [nameof(Vector2)], new PFI("CenterPoint")),
            // The brush's gradient stops.
            new("ColorStops", [nameof(ColorGradientStop)], new MFI("ColorStops.Add")),
            // A value that specifies how to draw the gradient outside the brush's gradient vector or space.
            new("ExtendMode", [nameof(GradientExtendMode)], new PFI("ExtendMode")),
            // A value that specifies how the gradient's colors are interpolated.
            new("InterpolationSpace", [nameof(ColorSpace)], new PFI("InterpolationSpace")),
            // A value that indicates whether the gradient brush's positioning coordinates (StartPoint, EndPoint) are absolute or relative to the output area.
            new("MappingMode", [nameof(MappingMode)], new PFI("MappingMode")),
            // The offset of the brush relative to the object being painted.
            new("Offset", [nameof(Vector2)], new PFI("Offset")),
            // The rotation angle of the brush in radians.
            new("RotationAngle", [nameof(Single)], new PFI("RotationAngle")),
            // The rotation angle of the brush in degrees.
            new("RotationAngleInDegrees", [nameof(Single)], new PFI("RotationAngleInDegrees")),
            // The scale to apply to the brush.
            new("Scale", [nameof(Vector2)], new PFI("Scale")),
            // The matrix of transforms to apply to the brush.
            new("TransformMatrix", [nameof(Matrix3X2)], new PFI("TransformMatrix"))
        ],
        "ColorStops"
    );

    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionLinearGradientBrush" />. <br/>
    /// Represents a brush that paints an area with a linear gradient. <br/>
    /// 
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionlineargradientbrush">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM LinearGradientBrush = new(
        "LinearGradientBrush",
        "Microsoft.UI.Composition",
        "CompositionLinearGradientBrush",
        GradientBrush,
        new COI("CreateLinearGradientBrush"),
        [
            // The ending two-dimensional coordinates of the linear gradient.
            new("EndPoint", [nameof(Vector2)], new PFI("EndPoint")),
            // The starting two-dimensional coordinates of the linear gradient.
            new("StartPoint", [nameof(Vector2)], new PFI("StartPoint"))
        ],
        "ColorStops"
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionRadialGradientBrush" />. <br/>
    /// Represents a brush that paints an area with a radial gradient. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionradialgradientbrush">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM RadialGradientBrush = new(
        "RadialGradientBrush",
        "Microsoft.UI.Composition",
        "CompositionRadialGradientBrush",
        GradientBrush,
        new COI("CreateRadialGradientBrush"),
        [
            // The two-dimensional coordinates of the center of the ellipse that contains the gradient.
            new("EllipseCenter", [nameof(Vector2)], new PFI("EllipseCenter")),
            // The radii of the ellipse that contains the gradient.
            new("EllipseRadius", [nameof(Vector2)], new PFI("EllipseRadius")),
            // The two-dimensional coordinates of the origin of the gradient.
            new("GradientOriginOffset", [nameof(Vector2)], new PFI("GradientOriginOffset"))
        ],
        "ColorStops"
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionMaskBrush" />. <br/>
    /// Paints a SpriteVisual with a CompositionBrush with an opacity mask applied to it. The source of the opacity mask can be any CompositionBrush of type CompositionColorBrush, CompositionLinearGradientBrush, CompositionSurfaceBrush, CompositionEffectBrush or a CompositionNineGridBrush. The opacity mask must be specified as a CompositionSurfaceBrush. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionmaskbrush">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM MaskBrush = new(
        "MaskBrush",
        "Microsoft.UI.Composition",
        "CompositionMaskBrush",
        Brush,
        new COI("CreateMaskBrush"),
        [
            // A brush that contains the opacity mask with which the Source brush's content is to be masked. Can be of type CompositionSurfaceBrush or CompositionNineGridBrush.
            new("Mask", [nameof(SurfaceBrush), nameof(NineGridBrush)], new PFI("Mask")),
            // A brush whose content is to be masked by the opacity mask. Can be of type CompositionSurfaceBrush, CompositionColorBrush, or CompositionNineGridBrush.
            new("Source", [nameof(SurfaceBrush), nameof(ColorBrush), nameof(NineGridBrush)], new PFI("Source"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionNineGridBrush" />. <br/>
    /// Paints a SpriteVisual with a CompositionBrush after applying Nine-Grid Stretching to the contents of the Source brush. The source of the nine-grid stretch can be any CompositionBrush of type CompositionColorBrush, CompositionSurfaceBrush or a CompositionEffectBrush. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionninegridbrush">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM NineGridBrush = new(
        "NineGridBrush",
        "Microsoft.UI.Composition",
        "CompositionNineGridBrush",
        Brush,
        new COI("CreateNineGridBrush"),
        [
            // Inset from the bottom edge of the source content that specifies the thickness of the bottom row. Defaults to 0.0f.
            new("BottomInset", [nameof(Single)], new PFI("BottomInset")),
            // Scale to be applied to BottomInset. Defaults to 1.0f.
            new("BottomInsetScale", [nameof(Single)], new PFI("BottomInsetScale")),
            // Indicates whether the center of the Nine-Grid is drawn.
            new("IsCenterHollow", [nameof(Bool)], new PFI("IsCenterHollow")),
            // Inset from the left edge of the source content that specifies the thickness of the left column. Defaults to 0.0f.
            new("LeftInset", [nameof(Single)], new PFI("LeftInset")),
            // Scale to be applied to LeftInset. Defaults to 1.0f.
            new("LeftInsetScale", [nameof(Single)], new PFI("LeftInsetScale")),
            // Inset from the right edge of the source content that specifies the thickness of the right column. Defaults to 0.0f.
            new("RightInset", [nameof(Single)], new PFI("RightInset")),
            // Scale to be applied to RightInset. Defaults to 1.0f.
            new("RightInsetScale", [nameof(Single)], new PFI("RightInsetScale")),
            // The brush whose content is to be Nine-Grid stretched. Can be of type CompositionSurfaceBrush or CompositionColorBrush.
            new("Source", [nameof(SurfaceBrush), nameof(ColorBrush)], new PFI("Source")),
            // Inset from the top edge of the source content that specifies the thickness of the top row. Defaults to 0.0f.
            new("TopInset", [nameof(Single)], new PFI("TopInset")),
            // Scale to be applied to TopInset. Defaults to 1.0f.
            new("TopInsetScale", [nameof(Single)], new PFI("TopInsetScale"))
        ]
    );

    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionSurfaceBrush" />. <br/>
    /// Paints a SpriteVisual with pixels from an ICompositionSurface. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionsurfacebrush">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM SurfaceBrush = new(
        "SurfaceBrush",
        "Microsoft.UI.Composition",
        "CompositionSurfaceBrush",
        Brush,
        new COI("CreateSurfaceBrush"),
        [
            // The point on the brush to be positioned at the brush's offset. Value is normalized with respect to the size of the SpriteVisual.
            new("AnchorPoint", [nameof(Vector2)], new PFI("AnchorPoint")), 
            // Specifies the algorithm used for interpolating pixels from ICompositionSurface when they do not form a one-to-one mapping to pixels on SpriteVisual (as can happen under stretch, scale, rotation, and other transformations).
            new("BitmapInterpolationMode", [nameof(BitmapInterpolationMode)], new PFI("BitmapInterpolationMode")), 
            // The point about which the brush is rotated and scaled.
            new("CenterPoint", [nameof(Vector2)], new PFI("CenterPoint")), 
            // Controls the positioning of the vertical axis of content with respect to the vertical axis of the SpriteVisual. The value is clamped from 0.0f to 1.0f with 0.0f representing the left vertical edge and 1.0f representing the right vertical edge of the SpriteVisual.
            new("HorizontalAlignmentRatio", [nameof(Single)], new PFI("HorizontalAlignmentRatio")), 
            // The offset of the brush relative to its SpriteVisual.
            new("Offset", [nameof(Vector2)], new PFI("Offset")), 
            // The rotation angle, in radians, of the brush.
            new("RotationAngle", [nameof(Single)], new PFI("RotationAngle")), 
            // The rotation angle, in degrees, of the brush.
            new("RotationAngleInDegrees", [nameof(Single)], new PFI("RotationAngleInDegrees")), 
            // The scale to apply to the brush.
            new("Scale", [nameof(Vector2)], new PFI("Scale")), 
            // Gets or sets a value that indicates whether the surface brush aligns with pixels.
            new("SnapToPixels", [nameof(Bool)], new PFI("SnapToPixels")), 
            // Controls the scaling that is applied to the contents the ICompositionSurface with respect to the size of the SpriteVisual that is being painted.
            new("Stretch", [nameof(Stretch)], new PFI("Stretch")), 
            // The ICompositionSurface associated with the CompositionSurfaceBrush.
            // TODO: Support for ICompositionSurface
            new("Surface", [], new PFI("Surface")), 
            // The transformation matrix to apply to the brush.
            new("TransformMatrix", [nameof(Matrix3X2)], new PFI("TransformMatrix")),
            // Controls the positioning of the horizontal axis of content with respect to the horizontal axis of the SpriteVisual. The value is clamped from 0.0f to 1.0f with 0.0f representing the top horizontal edge and 1.0f representing the bottom horizontal edge of the SpriteVisual. The default value is 0.5f.
            new("VerticalAlignmentRatio", [nameof(Single)], new PFI("VerticalAlignmentRatio"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionColorGradientStop" />. <br/>
    /// Describes the location and color of a transition point in a gradient. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositioncolorgradientstop">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM ColorGradientStop = new(
        "ColorGradientStop",
        "Microsoft.UI.Composition",
        "CompositionColorGradientStop",
        CompositionObject,
        new COI("CreateColorGradientStop"),
        [
            // The color of the gradient stop.
            new("Color", [nameof(Color)], new PFI("Color")),
            // The location of the gradient stop within the gradient vector.
            new("Offset", [nameof(Single)], new PFI("Offset"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionShape" />. <br/>
    /// Represents the base shape class. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionshape">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM Shape = new(
        "Shape",
        "Microsoft.UI.Composition",
        "CompositionShape",
        CompositionObject,
        new(),
        [
            // The point about which the shape is rotated and scaled.
            new("CenterPoint", [nameof(Vector2)], new PFI("CenterPoint")),
            // The offset of the shape relative to its ShapeVisual.
            new("Offset", [nameof(Vector2)], new PFI("Offset")),
            // The rotation angle of the shape in radians.
            new("RotationAngle", [nameof(Single)], new PFI("RotationAngle")),
            // The rotation angle of the shape in degrees.
            new("RotationAngleInDegrees", [nameof(Single)], new PFI("RotationAngleInDegrees")),
            // The scale to apply to the shape.
            new("Scale", [nameof(Vector2)], new PFI("Scale")),
            // The transform matrix to apply to the shape.
            new("TransformMatrix", [nameof(Matrix3X2)], new PFI("TransformMatrix"))
        ]
    );

    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionContainerShape" />. <br/>
    /// Represents a container for CompositionShapes, used to group items that share 2D transforms. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositioncontainershape">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM ContainerShape = new(
        "ContainerShape",
        "Microsoft.UI.Composition",
        "CompositionContainerShape",
        Shape,
        new COI("CreateContainerShape"),
        [
            // The collection of CompositionShapes in this container.
            new("Shapes", [nameof(Shape)], new MFI("Shapes.Append"))
        ],
        "Shapes"
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionSpriteShape" />. <br/>
    /// A CompositionShape that draws Stroked and Filled CompositionGeometry. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionspriteshape">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM SpriteShape = new(
        "SpriteShape",
        "Microsoft.UI.Composition",
        "CompositionSpriteShape",
        Shape,
        new COI("CreateSpriteShape"),
        [
            // The brush that paints the interior area of the shape.
            new("FillBrush", [nameof(Brush)], new PFI("FillBrush")),
            // The geometry that defines this shape.
            new("Geometry", [nameof(Geometry)], new PFI("Geometry")),
            // A value that specifies whether the shape's outline scales.
            new("IsStrokeNonScaling", [nameof(Bool)], new PFI("IsStrokeNonScaling")),
            // The brush that paints the outline of the shape.
            new("StrokeBrush", [nameof(Brush)], new PFI("StrokeBrush")),
            // The collection of values that indicates the pattern of dashes and gaps used to outline shapes.
            new("StrokeDashArray", [nameof(Single)], new MFI("StrokeDashArray.Add")),
            // A CompositionStrokeCap enumeration value that specifies how the ends of a dash are drawn.
            new("StrokeDashCap", [nameof(StrokeCap)], new PFI("StrokeDashCap")),
            // A value that specifies the distance within the dash pattern where a dash begins.
            new("StrokeDashOffset", [nameof(Single)], new PFI("StrokeDashOffset")),
            // A CompositionStrokeCap enumeration value that specifies how the end of a line is drawn.
            new("StrokeEndCap", [nameof(StrokeCap)], new PFI("StrokeEndCap")),
            // A CompositionStrokeLineJoin enumeration value that specifies the type of join used at the vertices of a shape.
            new("StrokeLineJoin", [nameof(StrokeLineJoin)], new PFI("StrokeLineJoin")),
            // A limit on the ratio of the miter length to half the StrokeThickness of a shape element.
            new("StrokeMiterLimit", [nameof(Single)], new PFI("StrokeMiterLimit")),
            // A CompositionStrokeCap enumeration value that specifies how the start of a line is drawn.
            new("StrokeStartCap", [nameof(StrokeCap)], new PFI("StrokeStartCap")),
            // The width of the shape outline.
            new("StrokeThickness", [nameof(Single)], new PFI("StrokeThickness"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.Visual" />. <br/>
    /// The base visual object in the visual hierarchy. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.visual">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM Visual = new(
        "Visual",
        "Microsoft.UI.Composition",
        "Visual",
        CompositionObject,
        new(),
        [
            // The point on the visual to be positioned at the visual's offset. Value is normalized with respect to the size of the visual. Animatable.
            new("AnchorPoint", [nameof(Vector2)], new PFI("AnchorPoint")),
            // Specifies whether the back face of the visual should be visible during a 3D transform.
            new("BackfaceVisibility", [nameof(BackfaceVisibility)], new PFI("BackfaceVisibility")),
            // Specifies how to compose the edges of bitmaps and clips associated with a visual, or with all visuals in the subtree rooted at this visual. Setting BorderMode at a parent Visual will affect all children visuals in the subtree and can be selectively turned off at each child visual.
            new("BorderMode", [nameof(BorderMode)], new PFI("BorderMode")),
            // The point about which rotation or scaling occurs. Animatable
            new("CenterPoint", [nameof(Vector3)], new PFI("CenterPoint")),
            // Specifies the clipping region for the visual. When a visual is rendered, only the portion of the visual that falls inside the clipping region is displayed, while any content that extends outside the clipping region is clipped (that is, not displayed).
            new("Clip", [nameof(Clip)], new PFI("Clip")),
            // Specifies how a visual's bitmap is blended with the screen.
            new("CompositeMode", [nameof(CompositeMode)], new PFI("CompositeMode")),
            // A value that indicates whether the visual sub-tree rooted at this visual participates in hit testing.
            new("IsHitTestVisible", [nameof(Bool)], new PFI("IsHitTestVisible")),
            // A value that indicates whether the composition engine aligns the rendered visual with a pixel boundary.
            new("IsPixelSnappingEnabled", [nameof(Bool)], new PFI("IsPixelSnappingEnabled")),
            // Indicates whether the visual and its entire subtree of child visuals is visible.
            new("IsVisible", [nameof(Bool)], new PFI("IsVisible")),
            // The offset of the visual relative to its parent or for a root visual the offset relative to the upper-left corner of the windows that hosts the visual. Animatable.
            new("Offset", [nameof(Vector3)], new PFI("Offset")),
            // The opacity of the visual. Animatable.
            new("Opacity", [nameof(Single)], new PFI("Opacity")),
            // A quaternion describing an orientation and rotation in 3D space that will be applied to the visual. Animatable.
            new("Orientation", [nameof(Quaternion)], new PFI("Orientation")),
            // Visual specifying the coordinate system in which this visual is composed.
            new("ParentForTransform", [nameof(Visual)], new PFI("ParentForTransform")),
            // Specifies the offset of the visual with respect to the size of its parent visual.
            new("RelativeOffsetAdjustment", [nameof(Vector3)], new PFI("RelativeOffsetAdjustment")),
            // The size of the visual with respect to the size of its parent visual.
            new("RelativeSizeAdjustment", [nameof(Vector2)], new PFI("RelativeSizeAdjustment")),
            // The rotation angle in radians of the visual. Animatable.
            new("RotationAngle", [nameof(Single)], new PFI("RotationAngle")),
            // The rotation angle of the visual in degrees. Animatable.
            new("RotationAngleInDegrees", [nameof(Single)], new PFI("RotationAngleInDegrees")),
            // The axis to rotate the visual around. Animatable.
            new("RotationAxis", [nameof(Vector3)], new PFI("RotationAxis")),
            // The scale to apply to the visual.
            new("Scale", [nameof(Vector3)], new PFI("Scale")),
            // The width and height of the visual. Animatable.
            new("Size", [nameof(Vector2)], new PFI("Size")),
            // The transformation matrix to apply to the visual. Animatable.
            new("TransformMatrix", [nameof(Matrix4X4)], new PFI("TransformMatrix"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.ContainerVisual" />. <br/>
    /// A node in the visual tree that can have children. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.containervisual">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM ContainerVisual = new(
        "ContainerVisual",
        "Microsoft.UI.Composition",
        "ContainerVisual",
        Visual,
        new COI("CreateContainerVisual"),
        [
            // The children of the ContainerVisual.
            new("Children", [nameof(Visual)], new MFI("Children.InsertAtTop"))
        ],
        "Children"
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.LayerVisual" />. <br/>
    /// A ContainerVisual whose children are flattened into a single layer. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.layervisual">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM LayerVisual = new(
        "LayerVisual",
        "Microsoft.UI.Composition",
        "LayerVisual",
        ContainerVisual,
        new COI("CreateLayerVisual"),
        [],
        "Children"
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.RedirectVisual" />. <br/>
    /// Represents a visual that gets its content from another visual. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.redirectvisual">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM RedirectVisual = new(
        "RedirectVisual",
        "Microsoft.UI.Composition",
        "RedirectVisual",
        ContainerVisual,
        new COI("CreateRedirectVisual"),
        [
            // The Visual that this RedirectVisual gets its content from.
            new("Source", [nameof(Visual)], new PFI("Source"))
        ],
        "Children"
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.Scenes.SceneVisual" />. <br/>
    /// Represents a container visual for the nodes of a 3D scene. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.scenes.scenevisual">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM SceneVisual = new(
        "SceneVisual",
        "Microsoft.UI.Composition.Scenes",
        "SceneVisual",
        ContainerVisual,
        new SceneVisualInterpreter(),
        [
            // The root node for the scene.
            // TODO: Support for SceneNode
            new("Root", [], new PFI("Root"))
        ],
        "Children"
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.ShapeVisual" />. <br/>
    /// Represents a visual tree node that is the root of a CompositionShape. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.shapevisual">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM ShapeVisual = new(
        "ShapeVisual",
        "Microsoft.UI.Composition",
        "ShapeVisual",
        ContainerVisual,
        new COI("CreateShapeVisual"),
        [
            // The collection of CompositionShapes that this shape visual tree is composed of.
            new("Shapes", [nameof(Shape)], new MFI("Shapes.Append"))
        ],
        "Shapes"
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.SpriteVisual" />. <br/>
    /// Hosts 2D boxed content of type CompositionBrush. Any part of the visual not covered by pixels from the brush are rendered as transparent pixels. CompositionBrush can be either a CompositionBackdropBrush, CompositionColorBrush, a CompositionSurfaceBrush or a CompositionEffectBrush. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.spritevisual">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM SpriteVisual = new(
        "SpriteVisual",
        "Microsoft.UI.Composition",
        "SpriteVisual",
        ContainerVisual,
        new COI("CreateSpriteVisual"),
        [
            // A CompositionBrush describing how the SpriteVisual is painted.
            new("Brush", [nameof(Brush)], new PFI("Brush")),
            // The shadow for the SpriteVisual.
            new("Shadow", [nameof(Shadow)], new PFI("Shadow"))
        ],
        "Children"
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionShadow" />. <br/>
    /// Base class for shadows that can be applied to a SpriteVisual. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionshadow">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM Shadow = new(
        "Shadow",
        "Microsoft.UI.Composition",
        "CompositionShadow",
        CompositionObject,
        new(),
        []
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.DropShadow" />. <br/>
    /// A drop shadow cast by a SpriteVisual or LayerVisual. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.dropshadow">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM DropShadow = new(
        "DropShadow",
        "Microsoft.UI.Composition",
        "DropShadow",
        Shadow,
        new COI("CreateDropShadow"),
        [
            // The radius of the Gaussian blur used to generate the shadow. Animatable.
            new("BlurRadius", [nameof(Single)], new PFI("BlurRadius")),
            // The color of the shadow. Animatable.
            new("Color", [nameof(Color)], new PFI("Color")),
            // Brush used to specify an opacity mask for the shadow. Defaults to the SpriteVisual's brush. Animatable.
            new("Mask", [nameof(Brush)], new PFI("Mask")),
            // Offset of the shadow relative to its SpriteVisual. Animatable.
            new("Offset", [nameof(Vector3)], new PFI("Offset")),
            // The opacity of the shadow. Animatable.
            new("Opacity", [nameof(Single)], new PFI("Opacity")),
            // Used to define the shadow masking policy to be used for the shadow.
            new("SourcePolicy", [nameof(DropShadowSourcePolicy)], new PFI("SourcePolicy"))
        ]
    );

    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionGeometry" />. <br/>
    /// Used to define the shadow masking policy to be used for the shadow. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositiongeometry">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM Geometry = new(
        "Geometry",
        "Microsoft.UI.Composition",
        "CompositionGeometry",
        CompositionObject,
        new(),
        [
            // The amount to trim the end of the geometry path.
            new("TrimEnd", [nameof(Single)], new PFI("TrimEnd")),
            // The amount to offset trimming the geometry path.
            new("TrimOffset", [nameof(Single)], new PFI("TrimOffset")),
            // The amount to trim the start of the geometry path.
            new("TrimStart", [nameof(Single)], new PFI("TrimStart"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionEllipseGeometry" />. <br/>
    /// The amount to trim the start of the geometry path. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionellipsegeometry">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM EllipseGeometry = new(
        "EllipseGeometry",
        "Microsoft.UI.Composition",
        "CompositionEllipseGeometry",
        Geometry,
        new COI("CreateEllipseGeometry"),
        [
            // The center point of the ellipse.
            new("Center", [nameof(Vector2)], new PFI("Center")),
            // The radius of the ellipse.
            new("Radius", [nameof(Vector2)], new PFI("Radius"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionLineGeometry" />. <br/>
    /// Represents a straight line between two points. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionlinegeometry">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM LineGeometry = new(
        "LineGeometry",
        "Microsoft.UI.Composition",
        "CompositionLineGeometry",
        Geometry,
        new COI("CreateLineGeometry"),
        [
            // The end point of the line.
            new("End", [nameof(Vector2)], new PFI("End")),
            // The starting point of the line.
            new("Start", [nameof(Vector2)], new PFI("Start"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionPathGeometry" />. <br/>
    /// Represents a series of connected lines and curves. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionpathgeometry">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM PathGeometry = new(
        "PathGeometry",
        "Microsoft.UI.Composition",
        "CompositionPathGeometry",
        Geometry,
        new COI("CreatePathGeometry"),
        [
            // The data that defines the lines and curves of the path.
            // TODO: Support for CompositionPath
            new("Path", [], new PFI("Path"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionRectangleGeometry" />. <br/>
    /// Represents a rectangle shape of the specified size. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionrectanglegeometry">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM RectangleGeometry = new(
        "RectangleGeometry",
        "Microsoft.UI.Composition",
        "CompositionRectangleGeometry",
        Geometry,
        new COI("CreateRectangleGeometry"),
        [
            // The offset of the rectangle.
            new("Offset", [nameof(Vector2)], new PFI("Offset")),
            // The height and width of the rectangle.
            new("Size", [nameof(Vector2)], new PFI("Size"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionRoundedRectangleGeometry" />. <br/>
    /// Represents a rectangle shape of the specified size with rounded corners. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionroundedrectanglegeometry">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM RoundedRectangleGeometry = new(
        "RoundedRectangleGeometry",
        "Microsoft.UI.Composition",
        "CompositionRoundedRectangleGeometry",
        Geometry,
        new COI("CreateRoundedRectangleGeometry"),
        [
            // The degree to which the corners are rounded.
            new("CornerRadius", [nameof(Vector2)], new PFI("CornerRadius")),
            // The offset of the rectangle.
            new("Offset", [nameof(Vector2)], new PFI("Offset")),
            // The height and width of the rectangle.
            new("Size", [nameof(Vector2)], new PFI("Size"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionClip" />. <br/>
    /// Base class for clipping objects such as InsetClip. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionclip">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM Clip = new(
        "Clip",
        "Microsoft.UI.Composition",
        "CompositionClip",
        CompositionObject,
        new(),
        [
            // The point on the clip to be positioned at the clip's offset. Value is normalized with respect to the size of the visual.
            new("AnchorPoint", [nameof(Vector2)], new PFI("AnchorPoint")),
            // The point about which rotation or scaling occurs.
            new("CenterPoint", [nameof(Vector2)], new PFI("CenterPoint")),
            // The offset of the clip relative to the visual on which the clip is applied.
            new("Offset", [nameof(Vector2)], new PFI("Offset")),
            // The angle of rotation applied to the clip, in radians.
            new("RotationAngle", [nameof(Single)], new PFI("RotationAngle")),
            // The angle of rotation applied to the clip, in degrees.
            new("RotationAngleInDegrees", [nameof(Single)], new PFI("RotationAngleInDegrees")),
            // The scale to apply to the clip.
            new("Scale", [nameof(Vector2)], new PFI("Scale")),
            // The 3x2 transformation matrix to apply to the clip.
            new("TransformMatrix", [nameof(Matrix3X2)], new PFI("TransformMatrix"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionGeometricClip" />. <br/>
    /// Represents a shape that clips a portion of a visual. The visible portion of the visual is a shape defined by a CompositionGeometry. The portion of the visual outside the geometry is clipped. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositiongeometricclip">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM GeometricClip = new(
        "GeometricClip",
        "Microsoft.UI.Composition",
        "CompositionGeometricClip",
        Clip,
        new COI("CreateGeometricClip"),
        [
            // The CompositionGeometry that defines the shape of the clip.
            new("Geometry", [nameof(Geometry)], new PFI("Geometry")),
            // A CompositionViewBox that maps the shape visual tree coordinates onto the visual.
            new("ViewBox", [nameof(ViewBox)], new PFI("ViewBox"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.InsetClip" />. <br/>
    /// Represents a rectangle that clips a portion of a visual. The portion of the visual inside the rectangle is visible; the portion of the visual outside the rectangle is clipped. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.insetclip">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM InsetClip = new(
        "InsetClip",
        "Microsoft.UI.Composition",
        "InsetClip",
        Clip,
        new COI("CreateInsetClip"),
        [
            // The offset from the bottom of the visual. The portion of the visual below the BottomInset will be clipped. Animatable.
            new("BottomInset", [nameof(Single)], new PFI("BottomInset")),
            // The offset from the left of the visual. The portion of the visual to the left of the LeftInset will be clipped. Animatable.
            new("LeftInset", [nameof(Single)], new PFI("LeftInset")),
            // The offset from the right of the visual. The portion of the visual to the right of the RightInset will be clipped. Animatable.
            new("RightInset", [nameof(Single)], new PFI("RightInset")),
            // The offset from the top of the visual. The portion of the visual above the TopInset will be clipped. Animatable.
            new("TopInset", [nameof(Single)], new PFI("TopInset"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.RectangleClip" />. <br/>
    /// Represents a rectangle with optional rounded corners that clips a portion of a visual. The portion of the visual inside the rectangle is visible; the portion of the visual outside the rectangle is clipped. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.rectangleclip">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM RectangleClip = new(
        "RectangleClip",
        "Microsoft.UI.Composition",
        "RectangleClip",
        Clip,
        new COI("CreateRectangleClip"),
        [
            // The offset from the bottom of the visual. The portion of the visual below the edge defined by Bottom will be clipped. Animatable.
            new("Bottom", [nameof(Single)], new PFI("Bottom")),
            // The amount by which the bottom left corner of the rectangle is rounded.
            new("BottomLeftRadius", [nameof(Single)], new PFI("BottomLeftRadius")),
            // The amount by which the bottom right corner of the rectangle is rounded.
            new("BottomRightRadius", [nameof(Single)], new PFI("BottomRightRadius")),
            // The offset from the left of the visual. The portion of the visual to the left of the edge defined by Left will be clipped. Animatable.
            new("Left", [nameof(Single)], new PFI("Left")),
            // The amount from the right of the visual. The portion of the visual to the right of the edge defined by Right will be clipped. Animatable.
            new("Right", [nameof(Single)], new PFI("Right")),
            // The offset from the top of the visual. The portion of the visual above the edge defined by Top will be clipped. Animatable.
            new("Top", [nameof(Single)], new PFI("Top")),
            // The amount by which the top left corner of the rectangle is rounded.
            new("TopLeftRadius", [nameof(Single)], new PFI("TopLeftRadius")),
            // The amount by which the top right corner of the rectangle is rounded.
            new("TopRightRadius", [nameof(Single)], new PFI("TopRightRadius"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionProjectedShadow" />. <br/>
    /// Represents a scene-based shadow calculated using the relationship between the light, the visual that casts the shadow, and the visual that receives the shadow, such that the shadow is drawn differently on each receiver. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionprojectedshadow">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM ProjectedShadow = new(
        "ProjectedShadow",
        "Microsoft.UI.Composition",
        "CompositionProjectedShadow",
        CompositionObject,
        new COI("CreateProjectedShadow"),
        [
            // The multiplier for the shadow's blur radius.
            new("BlurRadiusMultiplier", [nameof(Single)], new PFI("BlurRadiusMultiplier")),
            // The collection of objects that cast a shadow on the receivers.
            new("Casters", [nameof(ProjectedShadowCaster)], new MFI("Casters.InsertAtTop")),
            // The composition light that determines the direction the shadow is cast.
            new("LightSource", [nameof(Light)], new PFI("LightSource")),
            // The maximum blur radius of the shadow.
            new("MaxBlurRadius", [nameof(Single)], new PFI("MaxBlurRadius")),
            // The minimum blur radius of the shadow.
            new("MinBlurRadius", [nameof(Single)], new PFI("MinBlurRadius")),
            // The collection of objects that the shadow is cast on.
            new("Receivers", [nameof(ProjectedShadowReceiver)], new MFI("Receivers.Add"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionProjectedShadowCaster" />. <br/>
    /// Represents an object that casts a projected shadow. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionprojectedshadowcaster">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM ProjectedShadowCaster = new(
        "ProjectedShadowCaster",
        "Microsoft.UI.Composition",
        "CompositionProjectedShadowCaster",
        CompositionObject,
        new COI("CreateProjectedShadowCaster"),
        [
            // The brush used to draw the shadow.
            new("Brush", [nameof(Brush)], new PFI("Brush")),
            // The visual that casts the shadow.
            new("CastingVisual", [nameof(Visual)], new PFI("CastingVisual"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionProjectedShadowReceiver" />. <br/>
    /// Represents an object that can have a projected shadow cast on it. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionprojectedshadowreceiver">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM ProjectedShadowReceiver = new(
        "ProjectedShadowReceiver",
        "Microsoft.UI.Composition",
        "CompositionProjectedShadowReceiver",
        CompositionObject,
        new COI("CreateProjectedShadowReceiver"),
        [
            // The visual that the shadow is cast on.
            new("ReceivingVisual", [nameof(Visual)], new PFI("ReceivingVisual"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionViewBox" />. <br/>
    /// Represents a container that maps shape visual tree coordinates onto the visual. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionviewbox">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM ViewBox = new(
        "ViewBox",
        "Microsoft.UI.Composition",
        "CompositionViewBox",
        CompositionObject,
        new COI("CreateViewBox"),
        [
            // The horizontal alignment ratio of the view box.
            new("HorizontalAlignmentRatio", [nameof(Single)], new PFI("HorizontalAlignmentRatio")),
            // The offset of the view box.
            new("Offset", [nameof(Vector2)], new PFI("Offset")),
            // The height and width of the view box.
            new("Size", [nameof(Vector2)], new PFI("Size")),
            // A value that specifies how content fits into the available space.
            new("Stretch", [nameof(Stretch)], new PFI("Stretch")),
            // The vertical alignment ratio of the view box.
            new("VerticalAlignmentRatio", [nameof(Single)], new PFI("VerticalAlignmentRatio"))
        ]
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionSurfaceBrush" />. <br/>
    /// Represents a visual tree as an ICompositionSurface that can be used to paint a Visual using a CompositionBrush. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionsurfacebrush">Microsoft Learn</see>.
    /// </summary>
    internal static readonly COM VisualSurface = new(
        "VisualSurface",
        "Microsoft.UI.Composition",
        "CompositionVisualSurface",
        CompositionObject,
        new COI("CreateVisualSurface"),
        [
            // The coordinates of the top-left corner of the part of the visual surface used for rendering.
            new("SourceOffset", [nameof(Vector2)], new PFI("SourceOffset")),
            // The height and width of the part of the visual surface used for rendering.
            new("SourceSize", [nameof(Vector2)], new PFI("SourceSize")),
            // The root of the visual tree that is the target of the visual surface.
            new("SourceVisual", [nameof(Visual)], new PFI("SourceVisual"))
        ]
    );
}