using DeclarativeComposition.Sharp.FieldProviders;

namespace DeclarativeComposition.Sharp.ObjectProviders;

partial class SharpObjectProvider
{
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionObject" />. <br/>
    /// Base class of the composition API representing a node in the visual tree structure. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionobject">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider CompositionObject = new(
        null,
        "Microsoft.UI.Composition",
        "CompositionObject",
        null,
        new()
        {
            // A string to associate with the CompositionObject.
            ["Comment".ToLower()] = new PropertyFieldProvider("Comment"),
        },
        null
    );

    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionLight" />. <br/>
    /// Base class for a light source that can target a UI scene. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionlight">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider CompositionLight = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionLight",
        null,
        new()
        {
            // A collection of Visuals that are not targeted by the light.
            ["ExclusionsFromTargets".ToLower()] = new CollectionFieldProvider("ExclusionsFromTargets.Add"),
            // A value that determines whether the composition light is on.
            ["IsEnabled".ToLower()] = new PropertyFieldProvider("IsEnabled"),
            // The collection of Visuals targeted by the light.
            ["Targets".ToLower()] = new CollectionFieldProvider("Targets.Add"),
        },
        "Targets".ToLower()
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.AmbientLight" />. <br/>
    /// A light that illuminates every targeted Visual equally. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.ambientlight">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider AmbientLight = new(
        CompositionLight,
        "Microsoft.UI.Composition",
        "AmbientLight",
        "_compositor.CreateAmbientLight()",
        new()
        {
            // Color of the light.
            ["Color".ToLower()] = new PropertyFieldProvider("Color"),
            // The intensity of the light.
            ["Intensity".ToLower()] = new PropertyFieldProvider("Intensity")
        },
        "Targets".ToLower()
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.DistantLight" />. <br/>
    /// An infinitely large distant light source that emits light in a single direction. For example, a distant light could be used to represent sunlight. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.distantlight">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider DistantLight = new(
        CompositionLight,
        "Microsoft.UI.Composition",
        "DistantLight",
        "_compositor.CreateDistantLight()",
        new()
        {
            // Color of the emitted DistantLight.
            ["Color".ToLower()] = new PropertyFieldProvider("Color"),
            // The Visual used to determine the light’s direction. The light's Direction property is relative to this Visual’s coordinate space.
            ["CoordinateSpace".ToLower()] = new PropertyFieldProvider("CoordinateSpace"),
            // The direction in which the light is pointing, specified relative to its CoordinateSpace Visual.
            ["Direction".ToLower()] = new PropertyFieldProvider("Direction"),
            // The intensity of the light.
            ["Intensity".ToLower()] = new PropertyFieldProvider("Intensity")
        },
        "Targets".ToLower()
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.PointLight" />. <br/>
    /// A point source of light that emanates light in all directions. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.pointlight">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider PointLight = new(
        CompositionLight,
        "Microsoft.UI.Composition",
        "PointLight",
        "_compositor.CreatePointLight()",
        new()
        {
            // Color of the light.
            ["Color".ToLower()] = new PropertyFieldProvider("Color"),
            // The constant coefficient in the light's attenuation equation. Controls light intensity.
            ["ConstantAttenuation".ToLower()] = new PropertyFieldProvider("ConstantAttenuation"),
            // The Visual used to determine the light's offset. The light's offset property is relative to this Visual's coordinate space. PointLight.CoordinateSpace is a required property. If PointLight.CoordinateSpace is not set, the PointLight will not render.
            ["CoordinateSpace".ToLower()] = new PropertyFieldProvider("CoordinateSpace"),
            // The intensity of the light.
            ["Intensity".ToLower()] = new PropertyFieldProvider("Intensity"),
            // The linear coefficient in the light's attenuation equation that determines how the light falls-off with distance.
            ["LinearAttenuation".ToLower()] = new PropertyFieldProvider("LinearAttenuation"),
            // The maximum range at which this light is effective.
            ["MaxAttenuationCutoff".ToLower()] = new PropertyFieldProvider("MaxAttenuationCutoff"),
            // The minimum range at which this light is effective.
            ["MinAttenuationCutoff".ToLower()] = new PropertyFieldProvider("MinAttenuationCutoff"),
            // Offset of the light source relative to its coordinate space Visual.
            ["Offset".ToLower()] = new PropertyFieldProvider("Offset"),
            // The quadratic portion of the attenuation equation that determines how the light falls off with distance.
            ["QuadraticAttenuation".ToLower()] = new PropertyFieldProvider("QuadraticAttenuation")
        },
        "Targets".ToLower()
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.SpotLight" />. <br/>
    /// A light source that casts inner and outer cones of light. For example, a flashlight. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.spotlight">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider SpotLight = new(
        CompositionLight,
        "Microsoft.UI.Composition",
        "SpotLight",
        "_compositor.CreateSpotLight()",
        new()
        {
            // The constant coefficient in the light's attenuation equation. Controls light intensity. Animatable.
            ["ConstantAttenuation".ToLower()] = new PropertyFieldProvider("ConstantAttenuation"),
            // The Visual used to determine the light's direction and offset. The light's offset and direction properties are relative to this Visual's coordinate space. SpotLight.CoordinateSpace is a required property. If SpotLight.CoordinateSpace is not set, the SpotLight will not render.
            ["CoordinateSpace".ToLower()] = new PropertyFieldProvider("CoordinateSpace"),
            // The direction in which the light is pointing, specified relative to its CoordinateSpace Visual.
            ["Direction".ToLower()] = new PropertyFieldProvider("Direction"),
            // The SpotLight’s inner cone angle, expressed as a semi-vertical angle in radians. Animatable.
            ["InnerConeAngle".ToLower()] = new PropertyFieldProvider("InnerConeAngle"),
            // The SpotLight’s inner cone angle, expressed as a semi-vertical angle in degrees. Animatable.
            ["InnerConeAngleInDegrees".ToLower()] = new PropertyFieldProvider("InnerConeAngleInDegrees"),
            // Color of the spotlight's inner cone. Animatable.
            ["InnerConeColor".ToLower()] = new PropertyFieldProvider("InnerConeColor"),
            // The intensity of the light in the spotlight's inner cone.
            ["InnerConeIntensity".ToLower()] = new PropertyFieldProvider("InnerConeIntensity"),
            // The linear coefficient in the light's attenuation equation that determines how the light falls off with distance. Animatable.
            ["LinearAttenuation".ToLower()] = new PropertyFieldProvider("LinearAttenuation"),
            // The maximum range at which this light is effective.
            ["MaxAttenuationCutoff".ToLower()] = new PropertyFieldProvider("MaxAttenuationCutoff"),
            // The minimum range at which this light is effective.
            ["MinAttenuationCutoff".ToLower()] = new PropertyFieldProvider("MinAttenuationCutoff"),
            // Offset of the light source relative to its CoordinateSpace Visual. Animatable.
            ["Offset".ToLower()] = new PropertyFieldProvider("Offset"),
            // The SpotLight’s outer cone angle, expressed as a semi-vertical angle in radians. Animatable.
            ["OuterConeAngle".ToLower()] = new PropertyFieldProvider("OuterConeAngle"),
            // The semi-vertical angle, in degrees, of the SpotLight's outer cone. Animatable.
            ["OuterConeAngleInDegrees".ToLower()] = new PropertyFieldProvider("OuterConeAngleInDegrees"),
            // The color of the spotlight's outer cone. Animatable.
            ["OuterConeColor".ToLower()] = new PropertyFieldProvider("OuterConeColor"),
            // The intensity of the light in the spotlight's outer cone.
            ["OuterConeIntensity".ToLower()] = new PropertyFieldProvider("OuterConeIntensity"),
            // The quadratic portion of the attenuation equation that determines how the light falls off with distance. Animatable.
            ["QuadraticAttenuation".ToLower()] = new PropertyFieldProvider("QuadraticAttenuation")
        },
        "Targets".ToLower()
    );

    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionBrush" />. <br/>
    /// Base class for brushes used to paint a SpriteVisual. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionbrush">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider CompositionBrush = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionBrush",
        null,
        new(),
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionBackdropBrush" />. <br/>
    /// A brush that applies an effect (or a chain of effects) to the region behind a SpriteVisual. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionbackdropbrush">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider BackdropBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionBackdropBrush",
        "_compositor.CreateBackdropBrush()",
        new(),
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionColorBrush" />. <br/>
    /// Paints a SpriteVisual with a solid color. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositioncolorbrush">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider ColorBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionColorBrush",
        "_compositor.CreateColorBrush()",
        new()
        {
            // The color used to fill a SpriteVisual. Animatable.
            ["Color".ToLower()] = new PropertyFieldProvider("Color")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionEffectBrush" />. <br/>
    /// Paints a SpriteVisual with the output of a filter effect. The filter effect description is defined using the CompositionEffectFactory class. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositioneffectbrush">Microsoft Learn</see>.
    /// </summary>
    // TODO: Constructor not implemented
    private static readonly SharpObjectProvider EffectBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionEffectBrush",
        "_compositor.CreateEffectBrush()",
        new(),
        null
    );

    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionGradientBrush" />. <br/>
    /// Represents a brush that describes a gradient, composed of gradient stops. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositiongradientbrush">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider GradientBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionGradientBrush",
        null,
        new()
        {
            // The point on the brush to be positioned at the brush's offset.
            ["AnchorPoint".ToLower()] = new PropertyFieldProvider("AnchorPoint"),
            // The point about which the brush is rotated and scaled.
            ["CenterPoint".ToLower()] = new PropertyFieldProvider("CenterPoint"),
            // The brush's gradient stops.
            ["ColorStops".ToLower()] = new CollectionFieldProvider("ColorStops.Add"),
            // A value that specifies how to draw the gradient outside the brush's gradient vector or space.
            ["ExtendMode".ToLower()] = new PropertyFieldProvider("ExtendMode"),
            // A value that specifies how the gradient's colors are interpolated.
            ["InterpolationSpace".ToLower()] = new PropertyFieldProvider("InterpolationSpace"),
            // A value that indicates whether the gradient brush's positioning coordinates (StartPoint, EndPoint) are absolute or relative to the output area.
            ["MappingMode".ToLower()] = new PropertyFieldProvider("MappingMode"),
            // The offset of the brush relative to the object being painted.
            ["Offset".ToLower()] = new PropertyFieldProvider("Offset"),
            // The rotation angle of the brush in radians.
            ["RotationAngle".ToLower()] = new PropertyFieldProvider("RotationAngle"),
            // The rotation angle of the brush in degrees.
            ["RotationAngleInDegrees".ToLower()] = new PropertyFieldProvider("RotationAngleInDegrees"),
            // The scale to apply to the brush.
            ["Scale".ToLower()] = new PropertyFieldProvider("Scale"),
            // The matrix of transforms to apply to the brush.
            ["TransformMatrix".ToLower()] = new PropertyFieldProvider("TransformMatrix")
        },
        "ColorStops".ToLower()
    );

    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionLinearGradientBrush" />. <br/>
    /// Represents a brush that paints an area with a linear gradient. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionlineargraidentbrush">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider LinearGradientBrush = new(
        GradientBrush,
        "Microsoft.UI.Composition",
        "CompositionLinearGradientBrush",
        "_compositor.CreateLinearGradientBrush()",
        new()
        {
            // The ending two-dimensional coordinates of the linear gradient.
            ["EndPoint".ToLower()] = new PropertyFieldProvider("EndPoint"),
            // The starting two-dimensional coordinates of the linear gradient.
            ["StartPoint".ToLower()] = new PropertyFieldProvider("StartPoint")
        },
        "ColorStops".ToLower()
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionRadialGradientBrush" />. <br/>
    /// Represents a brush that paints an area with a radial gradient. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionradialgradientbrush">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider RadialGradientBrush = new(
        GradientBrush,
        "Microsoft.UI.Composition",
        "CompositionRadialGradientBrush",
        "_compositor.CreateRadialGradientBrush()",
        new()
        {
            // The two-dimensional coordinates of the center of the ellipse that contains the gradient.
            ["EllipseCenter".ToLower()] = new PropertyFieldProvider("EllipseCenter"),
            // The radii of the ellipse that contains the gradient.
            ["EllipseRadius".ToLower()] = new PropertyFieldProvider("EllipseRadius"),
            // The two-dimensional coordinates of the origin of the gradient.
            ["GradientOriginOffset".ToLower()] = new PropertyFieldProvider("GradientOriginOffset")
        },
        "ColorStops".ToLower()
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionMaskBrush" />. <br/>
    /// Paints a SpriteVisual with a CompositionBrush with an opacity mask applied to it. The source of the opacity mask can be any CompositionBrush of type CompositionColorBrush, CompositionLinearGradientBrush, CompositionSurfaceBrush, CompositionEffectBrush or a CompositionNineGridBrush. The opacity mask must be specified as a CompositionSurfaceBrush. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionmaskbrush">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider MaskBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionMaskBrush",
        "_compositor.CreateMaskBrush()",
        new()
        {
            // A brush that contains the opacity mask with which the Source brush's content is to be masked. Can be of type CompositionSurfaceBrush or CompositionNineGridBrush.
            ["Mask".ToLower()] = new PropertyFieldProvider("Mask"),
            // A brush whose content is to be masked by the opacity mask. Can be of type CompositionSurfaceBrush, CompositionColorBrush, or CompositionNineGridBrush.
            ["Source".ToLower()] = new PropertyFieldProvider("Source")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionNineGridBrush" />. <br/>
    /// Paints a SpriteVisual with a CompositionBrush after applying Nine-Grid Stretching to the contents of the Source brush. The source of the nine-grid stretch can be any CompositionBrush of type CompositionColorBrush, CompositionSurfaceBrush or a CompositionEffectBrush. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionninegridbrush">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider NineGridBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionNineGridBrush",
        "_compositor.CreateNineGridBrush()",
        new()
        {
            // Inset from the bottom edge of the source content that specifies the thickness of the bottom row. Defaults to 0.0f.
            ["BottomInset".ToLower()] = new PropertyFieldProvider("BottomInset"),
            // Scale to be applied to BottomInset. Defaults to 1.0f.
            ["BottomInsetScale".ToLower()] = new PropertyFieldProvider("BottomInsetScale"),
            // Indicates whether the center of the Nine-Grid is drawn.
            ["IsCenterHollow".ToLower()] = new PropertyFieldProvider("IsCenterHollow"),
            // Inset from the left edge of the source content that specifies the thickness of the left column. Defaults to 0.0f.
            ["LeftInset".ToLower()] = new PropertyFieldProvider("LeftInset"),
            // Scale to be applied to LeftInset. Defaults to 1.0f.
            ["LeftInsetScale".ToLower()] = new PropertyFieldProvider("LeftInsetScale"),
            // Inset from the right edge of the source content that specifies the thickness of the right column. Defaults to 0.0f.
            ["RightInset".ToLower()] = new PropertyFieldProvider("RightInset"),
            // Scale to be applied to RightInset. Defaults to 1.0f.
            ["RightInsetScale".ToLower()] = new PropertyFieldProvider("RightInsetScale"),
            // The brush whose content is to be Nine-Grid stretched. Can be of type CompositionSurfaceBrush or CompositionColorBrush.
            ["Source".ToLower()] = new PropertyFieldProvider("Source"),
            // Inset from the top edge of the source content that specifies the thickness of the top row. Defaults to 0.0f.
            ["TopInset".ToLower()] = new PropertyFieldProvider("TopInset"),
            // Scale to be applied to TopInset. Defaults to 1.0f.
            ["TopInsetScale".ToLower()] = new PropertyFieldProvider("TopInsetScale")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionSurfaceBrush" />. <br/>
    /// Paints a SpriteVisual with pixels from an ICompositionSurface. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionsurfacebrush">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider SurfaceBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionSurfaceBrush",
        "_compositor.CreateSurfaceBrush()",
        new()
        {
            // The point on the brush to be positioned at the brush's offset. Value is normalized with respect to the size of the SpriteVisual.
            ["AnchorPoint".ToLower()] = new PropertyFieldProvider("AnchorPoint"),
            // Specifies the algorithm used for interpolating pixels from ICompositionSurface when they do not form a one-to-one mapping to pixels on SpriteVisual (as can happen under stretch, scale, rotation, and other transformations).
            ["BitmapInterpolationMode".ToLower()] = new PropertyFieldProvider("BitmapInterpolationMode"),
            // The point about which the brush is rotated and scaled.
            ["CenterPoint".ToLower()] = new PropertyFieldProvider("CenterPoint"),
            // Controls the positioning of the vertical axis of content with respect to the vertical axis of the SpriteVisual. The value is clamped from 0.0f to 1.0f with 0.0f representing the left vertical edge and 1.0f representing the right vertical edge of the SpriteVisual.
            ["HorizontalAlignmentRatio".ToLower()] = new PropertyFieldProvider("HorizontalAlignmentRatio"),
            // The offset of the brush relative to its SpriteVisual.
            ["Offset".ToLower()] = new PropertyFieldProvider("Offset"),
            // The rotation angle, in radians, of the brush.
            ["RotationAngle".ToLower()] = new PropertyFieldProvider("RotationAngle"),
            // The rotation angle, in degrees, of the brush.
            ["RotationAngleInDegrees".ToLower()] = new PropertyFieldProvider("RotationAngleInDegrees"),
            // The scale to apply to the brush.
            ["Scale".ToLower()] = new PropertyFieldProvider("Scale"),
            // Gets or sets a value that indicates whether the surface brush aligns with pixels.
            ["SnapToPixels".ToLower()] = new PropertyFieldProvider("SnapToPixels"),
            // Controls the scaling that is applied to the contents the ICompositionSurface with respect to the size of the SpriteVisual that is being painted.
            ["Stretch".ToLower()] = new PropertyFieldProvider("Stretch"),
            // The ICompositionSurface associated with the CompositionSurfaceBrush.
            ["Surface".ToLower()] = new PropertyFieldProvider("Surface"),
            // The transformation matrix to apply to the brush.
            ["TransformMatrix".ToLower()] = new PropertyFieldProvider("TransformMatrix"),
            // Controls the positioning of the horizontal axis of content with respect to the horizontal axis of the SpriteVisual. The value is clamped from 0.0f to 1.0f with 0.0f representing the top horizontal edge and 1.0f representing the bottom horizontal edge of the SpriteVisual. The default value is 0.5f.
            ["VerticalAlignmentRatio".ToLower()] = new PropertyFieldProvider("VerticalAlignmentRatio")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionColorGradientStop" />. <br/>
    /// Describes the location and color of a transition point in a gradient. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositioncolorgradientstop">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider ColorGradientStop = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionColorGradientStop",
        "_compositor.CreateColorGradientStop()",
        new()
        {
            // The color of the gradient stop.
            ["Color".ToLower()] = new PropertyFieldProvider("Color"),
            // The location of the gradient stop within the gradient vector.
            ["Offset".ToLower()] = new PropertyFieldProvider("Offset")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionShape" />. <br/>
    /// Represents the base shape class. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionshape">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider CompositionShape = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionShape",
        null,
        new()
        {
            // The point about which the shape is rotated and scaled.
            ["CenterPoint".ToLower()] = new PropertyFieldProvider("CenterPoint"),
            // The offset of the shape relative to its ShapeVisual.
            ["Offset".ToLower()] = new PropertyFieldProvider("Offset"),
            // The rotation angle of the shape in radians.
            ["RotationAngle".ToLower()] = new PropertyFieldProvider("RotationAngle"),
            // The rotation angle of the shape in degrees.
            ["RotationAngleInDegrees".ToLower()] = new PropertyFieldProvider("RotationAngleInDegrees"),
            // The scale to apply to the shape.
            ["Scale".ToLower()] = new PropertyFieldProvider("Scale"),
            // The transform matrix to apply to the shape.
            ["TransformMatrix".ToLower()] = new PropertyFieldProvider("TransformMatrix")
        },
        null
    );

    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionContainerShape" />. <br/>
    /// Represents a container for CompositionShapes, used to group items that share 2D transforms. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositioncontainershape">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider ContainerShape = new(
        CompositionShape,
        "Microsoft.UI.Composition",
        "ContainerShape",
        "_compositor.CreateContainerShape()",
        new()
        {
            // The collection of CompositionShapes in this container.
            ["Shapes".ToLower()] = new CollectionFieldProvider("Shapes.Append")
        },
        "Shapes".ToLower()
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionSpriteShape" />. <br/>
    /// A CompositionShape that draws Stroked and Filled CompositionGeometry. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionspriteshape">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider SpriteShape = new(
        CompositionShape,
        "Microsoft.UI.Composition",
        "CompositionSpriteShape",
        "_compositor.CreateSpriteShape()",
        new()
        {
            // The brush that paints the interior area of the shape.
            ["FillBrush".ToLower()] = new PropertyFieldProvider("FillBrush"),
            // The geometry that defines this shape.
            ["Geometry".ToLower()] = new PropertyFieldProvider("Geometry"),
            // A value that specifies whether the shape's outline scales.
            ["IsStrokeNonScaling".ToLower()] = new PropertyFieldProvider("IsStrokeNonScaling"),
            // The brush that paints the outline of the shape.
            ["StrokeBrush".ToLower()] = new PropertyFieldProvider("StrokeBrush"),
            // The collection of values that indicates the pattern of dashes and gaps used to outline shapes.
            ["StrokeDashArray".ToLower()] = new CollectionFieldProvider("StrokeDashArray.Add"),
            // A CompositionStrokeCap enumeration value that specifies how the ends of a dash are drawn.
            ["StrokeDashCap".ToLower()] = new PropertyFieldProvider("StrokeDashCap"),
            // A value that specifies the distance within the dash pattern where a dash begins.
            ["StrokeDashOffset".ToLower()] = new PropertyFieldProvider("StrokeDashOffset"),
            // A CompositionStrokeCap enumeration value that specifies how the end of a line is drawn.
            ["StrokeEndCap".ToLower()] = new PropertyFieldProvider("StrokeEndCap"),
            // A CompositionStrokeLineJoin enumeration value that specifies the type of join used at the vertices of a shape.
            ["StrokeLineJoin".ToLower()] = new PropertyFieldProvider("StrokeLineJoin"),
            // A limit on the ratio of the miter length to half the StrokeThickness of a shape element.
            ["StrokeMiterLimit".ToLower()] = new PropertyFieldProvider("StrokeMiterLimit"),
            // A CompositionStrokeCap enumeration value that specifies how the start of a line is drawn.
            ["StrokeStartCap".ToLower()] = new PropertyFieldProvider("StrokeStartCap"),
            // The width of the shape outline.
            ["StrokeThickness".ToLower()] = new PropertyFieldProvider("StrokeThickness")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.Visual" />. <br/>
    /// The base visual object in the visual hierarchy. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.visual">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider Visual = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "Visual",
        null,
        new()
        {
            // The point on the visual to be positioned at the visual's offset. Value is normalized with respect to the size of the visual. Animatable.
            ["AnchorPoint".ToLower()] = new PropertyFieldProvider("AnchorPoint"),
            // Specifies whether the back face of the visual should be visible during a 3D transform.
            ["BackfaceVisibility".ToLower()] = new PropertyFieldProvider("BackfaceVisibility"),
            // Specifies how to compose the edges of bitmaps and clips associated with a visual, or with all visuals in the subtree rooted at this visual. Setting BorderMode at a parent Visual will affect all children visuals in the subtree and can be selectively turned off at each child visual.
            ["BorderMode".ToLower()] = new PropertyFieldProvider("BorderMode"),
            // The point about which rotation or scaling occurs. Animatable
            ["CenterPoint".ToLower()] = new PropertyFieldProvider("CenterPoint"),
            // Specifies the clipping region for the visual. When a visual is rendered, only the portion of the visual that falls inside the clipping region is displayed, while any content that extends outside the clipping region is clipped (that is, not displayed).
            ["Clip".ToLower()] = new PropertyFieldProvider("Clip"),
            // Specifies how a visual's bitmap is blended with the screen.
            ["CompositeMode".ToLower()] = new PropertyFieldProvider("CompositeMode"),
            // A value that indicates whether the visual sub-tree rooted at this visual participates in hit testing.
            ["IsHitTestVisible".ToLower()] = new PropertyFieldProvider("IsHitTestVisible"),
            // A value that indicates whether the composition engine aligns the rendered visual with a pixel boundary.
            ["IsPixelSnappingEnabled".ToLower()] = new PropertyFieldProvider("IsPixelSnappingEnabled"),
            // Indicates whether the visual and its entire subtree of child visuals is visible.
            ["IsVisible".ToLower()] = new PropertyFieldProvider("IsVisible"),
            // The offset of the visual relative to its parent or for a root visual the offset relative to the upper-left corner of the windows that hosts the visual. Animatable.
            ["Offset".ToLower()] = new PropertyFieldProvider("Offset"),
            // The opacity of the visual. Animatable.
            ["Opacity".ToLower()] = new PropertyFieldProvider("Opacity"),
            // A quaternion describing an orientation and rotation in 3D space that will be applied to the visual. Animatable.
            ["Orientation".ToLower()] = new PropertyFieldProvider("Orientation"),
            // Visual specifying the coordinate system in which this visual is composed.
            ["ParentForTransform".ToLower()] = new PropertyFieldProvider("ParentForTransform"),
            // Specifies the offset of the visual with respect to the size of its parent visual.
            ["RelativeOffsetAdjustment".ToLower()] = new PropertyFieldProvider("RelativeOffsetAdjustment"),
            // The size of the visual with respect to the size of its parent visual.
            ["RelativeSizeAdjustment".ToLower()] = new PropertyFieldProvider("RelativeSizeAdjustment"),
            // The rotation angle in radians of the visual. Animatable.
            ["RotationAngle".ToLower()] = new PropertyFieldProvider("RotationAngle"),
            // The rotation angle of the visual in degrees. Animatable.
            ["RotationAngleInDegrees".ToLower()] = new PropertyFieldProvider("RotationAngleInDegrees"),
            // The axis to rotate the visual around. Animatable.
            ["RotationAxis".ToLower()] = new PropertyFieldProvider("RotationAxis"),
            // The scale to apply to the visual.
            ["Scale".ToLower()] = new PropertyFieldProvider("Scale"),
            // The width and height of the visual. Animatable.
            ["Size".ToLower()] = new PropertyFieldProvider("Size"),
            // The transformation matrix to apply to the visual. Animatable.
            ["TransformMatrix".ToLower()] = new PropertyFieldProvider("TransformMatrix")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.ContainerVisual" />. <br/>
    /// A node in the visual tree that can have children. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.containervisual">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider ContainerVisual = new(
        Visual,
        "Microsoft.UI.Composition",
        "ContainerVisual",
        "_compositor.CreateContainerVisual()",
        new()
        {
            // The children of the ContainerVisual.
            ["Children".ToLower()] = new CollectionFieldProvider("Children.InsertAtTop")
        },
        "Children".ToLower()
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.LayerVisual" />. <br/>
    /// A ContainerVisual whose children are flattened into a single layer. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.layervisual">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider LayerVisual = new(
        ContainerVisual,
        "Microsoft.UI.Composition",
        "LayerVisual",
        "_compositor.CreateLayerVisual()",
        new(),
        "Children".ToLower()
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.RedirectVisual" />. <br/>
    /// Represents a visual that gets its content from another visual. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.redirectvisual">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider RedirectVisual = new(
        ContainerVisual,
        "Microsoft.UI.Composition",
        "RedirectVisual",
        "_compositor.CreateRedirectVisual()",
        new()
        {
            // The Visual that this RedirectVisual gets its content from.
            ["Source".ToLower()] = new PropertyFieldProvider("Source")
        },
        "Children".ToLower()
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.Scenes.SceneVisual" />. <br/>
    /// Represents a container visual for the nodes of a 3D scene. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.scenes.scenevisual">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider SceneVisual = new(
        ContainerVisual,
        "Microsoft.UI.Composition.Scenes",
        "SceneVisual",
        "Microsoft.UI.Composition.Scenes.SceneVisual.Create(_compositor)",
        new()
        {
            ["Root".ToLower()] = new PropertyFieldProvider("Root")
        },
        "Children".ToLower()
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.ShapeVisual" />. <br/>
    /// Represents a visual tree node that is the root of a CompositionShape. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.shapevisual">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider ShapeVisual = new(
        ContainerVisual,
        "Microsoft.UI.Composition",
        "ShapeVisual",
        "_compositor.CreateShapeVisual()",
        new()
        {
            // The collection of CompositionShapes that this shape visual tree is composed of.
            ["Shapes".ToLower()] = new CollectionFieldProvider("Shapes.Append")
        },
        "Shapes".ToLower()
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.SpriteVisual" />. <br/>
    /// Hosts 2D boxed content of type CompositionBrush. Any part of the visual not covered by pixels from the brush are rendered as transparent pixels. CompositionBrush can be either a CompositionBackdropBrush, CompositionColorBrush, a CompositionSurfaceBrush or a CompositionEffectBrush. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.spritevisual">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider SpriteVisual = new(
        ContainerVisual,
        "Microsoft.UI.Composition",
        "SpriteVisual",
        "_compositor.CreateSpriteVisual()",
        new()
        {
            // A CompositionBrush describing how the SpriteVisual is painted.
            ["Brush".ToLower()] = new PropertyFieldProvider("Brush"),
            // The shadow for the SpriteVisual.
            ["Shadow".ToLower()] = new PropertyFieldProvider("Shadow")
        },
        "Children".ToLower()
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionShadow" />. <br/>
    /// Base class for shadows that can be applied to a SpriteVisual. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionshadow">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider CompositionShadow = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionShadow",
        null,
        new(),
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.DropShadow" />. <br/>
    /// A drop shadow cast by a SpriteVisual or LayerVisual. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.dropshadow">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider DropShadow = new(
        CompositionShadow,
        "Microsoft.UI.Composition",
        "DropShadow",
        "_compositor.CreateDropShadow()",
        new()
        {
            // The radius of the Gaussian blur used to generate the shadow. Animatable.
            ["BlurRadius".ToLower()] = new PropertyFieldProvider("BlurRadius"),
            // The color of the shadow. Animatable.
            ["Color".ToLower()] = new PropertyFieldProvider("Color"),
            // Brush used to specify an opacity mask for the shadow. Defaults to the SpriteVisual's brush. Animatable.
            ["Mask".ToLower()] = new PropertyFieldProvider("Mask"),
            // Offset of the shadow relative to its SpriteVisual. Animatable.
            ["Offset".ToLower()] = new PropertyFieldProvider("Offset"),
            // The opacity of the shadow. Animatable.
            ["Opacity".ToLower()] = new PropertyFieldProvider("Opacity"),
            // Used to define the shadow masking policy to be used for the shadow.
            ["SourcePolicy".ToLower()] = new PropertyFieldProvider("SourcePolicy")
        },
        null
    );

    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionGeometry" />. <br/>
    /// Used to define the shadow masking policy to be used for the shadow. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositiongeometry">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider CompositionGeometry = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionGeometry",
        null,
        new()
        {
            // The amount to trim the end of the geometry path.
            ["TrimEnd".ToLower()] = new PropertyFieldProvider("TrimEnd"),
            // The amount to offset trimming the geometry path.
            ["TrimOffset".ToLower()] = new PropertyFieldProvider("TrimOffset"),
            // The amount to trim the start of the geometry path.
            ["TrimStart".ToLower()] = new PropertyFieldProvider("TrimStart")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionEllipseGeometry" />. <br/>
    /// he amount to trim the start of the geometry path. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionellipsegeometry">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider EllipseGeometry = new(
        CompositionGeometry,
        "Microsoft.UI.Composition",
        "CompositionEllipseGeometry",
        "_compositor.CreateEllipseGeometry()",
        new()
        {
            // The center point of the ellipse.
            ["Center".ToLower()] = new PropertyFieldProvider("Center"),
            // The radius of the ellipse.
            ["Radius".ToLower()] = new PropertyFieldProvider("Radius")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionLineGeometry" />. <br/>
    /// Represents a straight line between two points. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionlinegeometry">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider LineGeometry = new(
        CompositionGeometry,
        "Microsoft.UI.Composition",
        "CompositionLineGeometry",
        "_compositor.CreateLineGeometry()",
        new()
        {
            // The end point of the line.
            ["End".ToLower()] = new PropertyFieldProvider("End"),
            // The startint point of the line.
            ["Start".ToLower()] = new PropertyFieldProvider("Start")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionPathGeometry" />. <br/>
    /// Represents a series of connected lines and curves. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionpathgeometry">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider PathGeometry = new(
        CompositionGeometry,
        "Microsoft.UI.Composition",
        "CompositionPathGeometry",
        "_compositor.CreatePathGeometry()",
        new()
        {
            // The data that defines the lines and curves of the path.
            ["Path".ToLower()] = new PropertyFieldProvider("Path")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionRectangleGeometry" />. <br/>
    /// Represents a rectangle shape of the specified size. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionrectanglegeometry">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider RectangleGeometry = new(
        CompositionGeometry,
        "Microsoft.UI.Composition",
        "CompositionRectangleGeometry",
        "_compositor.CreateRectangleGeometry()",
        new()
        {
            // The offset of the rectangle.
            ["Offset".ToLower()] = new PropertyFieldProvider("Offset"),
            // The height and width of the rectangle.
            ["Size".ToLower()] = new PropertyFieldProvider("Size")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionRoundedRectangleGeometry" />. <br/>
    /// Represents a rectangle shape of the specified size with rounded corners. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionroundedrectanglegeometry">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider RoundedRectangleGeometry = new(
        CompositionGeometry,
        "Microsoft.UI.Composition",
        "CompositionRoundedRectangleGeometry",
        "_compositor.CreateRoundedRectangleGeometry()",
        new()
        {
            // The degree to which the corners are rounded.
            ["CornerRadius".ToLower()] = new PropertyFieldProvider("CornerRadius"),
            // The offset of the rectangle.
            ["Offset".ToLower()] = new PropertyFieldProvider("Offset"),
            // The height and width of the rectangle.
            ["Size".ToLower()] = new PropertyFieldProvider("Size")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionClip" />. <br/>
    /// Base class for clipping objects such as InsetClip. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionclip">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider CompositionClip = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionClip",
        null,
        new()
        {
            // The point on the clip to be positioned at the clip's offset. Value is normalized with respect to the size of the visual.
            ["AnchorPoint".ToLower()] = new PropertyFieldProvider("AnchorPoint"),
            // The point about which rotation or scaling occurs.
            ["CenterPoint".ToLower()] = new PropertyFieldProvider("CenterPoint"),
            // The offset of the clip relative to the visual on which the clip is applied.
            ["Offset".ToLower()] = new PropertyFieldProvider("Offset"),
            // The angle of rotation applied to the clip, in radians.
            ["RotationAngle".ToLower()] = new PropertyFieldProvider("RotationAngle"),
            // The angle of rotation applied to the clip, in degrees.
            ["RotationAngleInDegrees".ToLower()] = new PropertyFieldProvider("RotationAngleInDegrees"),
            // The scale to apply to the clip.
            ["Scale".ToLower()] = new PropertyFieldProvider("Scale"),
            // The 3x2 transformation matrix to apply to the clip.
            ["TransformMatrix".ToLower()] = new PropertyFieldProvider("TransformMatrix")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionGeometricClip" />. <br/>
    /// Represents a shape that clips a portion of a visual. The visible portion of the visual is a shape defined by a CompositionGeometry. The portion of the visual outside the geometry is clipped. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositiongeometricclip">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider GeometricClip = new(
        CompositionClip,
        "Microsoft.UI.Composition",
        "CompositionGeometricClip",
        "_compositor.CreateGeometricClip()",
        new()
        {
            // CompositionGeometry that defines the shape of the clip.
            ["Geometry".ToLower()] = new PropertyFieldProvider("Geometry"),
            // A CompositionViewBox that maps the shape visual tree coordinates onto the visual.
            ["ViewBox".ToLower()] = new PropertyFieldProvider("ViewBox")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.InsetClip" />. <br/>
    /// Represents a rectangle that clips a portion of a visual. The portion of the visual inside the rectangle is visible; the portion of the visual outside the rectangle is clipped. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.insetclip">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider InsetClip = new(
        CompositionClip,
        "Microsoft.UI.Composition",
        "InsetClip",
        "_compositor.CreateInsetClip()",
        new()
        {
            // The offset from the bottom of the visual. The portion of the visual below the BottomInset will be clipped. Animatable.
            ["BottomInset".ToLower()] = new PropertyFieldProvider("BottomInset"),
            // The offset from the left of the visual. The portion of the visual to the left of the LeftInset will be clipped. Animatable.
            ["LeftInset".ToLower()] = new PropertyFieldProvider("LeftInset"),
            // The offset from the right of the visual. The portion of the visual to the right of the RightInset will be clipped. Animatable.
            ["RightInset".ToLower()] = new PropertyFieldProvider("RightInset"),
            // The offset from the top of the visual. The portion of the visual above the TopInset will be clipped. Animatable.
            ["TopInset".ToLower()] = new PropertyFieldProvider("TopInset")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.RectangleClip" />. <br/>
    /// Represents a rectangle with optional rounded corners that clips a portion of a visual. The portion of the visual inside the rectangle is visible; the portion of the visual outside the rectangle is clipped. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.rectangleclip">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider RectangleClip = new(
        CompositionClip,
        "Microsoft.UI.Composition",
        "RectangleClip",
        "_compositor.CreateRectangleClip()",
        new()
        {
            // The offset from the bottom of the visual. The portion of the visual below the edge defined by Bottom will be clipped. Animatable.
            ["Bottom".ToLower()] = new PropertyFieldProvider("Bottom"),
            // The amount by which the bottom left corner of the rectangle is rounded.
            ["BottomLeftRadius".ToLower()] = new PropertyFieldProvider("BottomLeftRadius"),
            // The amount by which the bottom right corner of the rectangle is rounded.
            ["BottomRightRadius".ToLower()] = new PropertyFieldProvider("BottomRightRadius"),
            // The offset from the left of the visual. The portion of the visual to the left of the edge defined by Left will be clipped. Animatable.
            ["Left".ToLower()] = new PropertyFieldProvider("Left"),
            // The amount from the right of the visual. The portion of the visual to the right the edge defined by Right will be clipped. Animatable.
            ["Right".ToLower()] = new PropertyFieldProvider("Right"),
            // The offset from the top of the visual. The portion of the visual above the edge defined by Top will be clipped. Animatable.
            ["Top".ToLower()] = new PropertyFieldProvider("Top"),
            // The amount by which the top left corner of the rectangle is rounded.
            ["TopLeftRadius".ToLower()] = new PropertyFieldProvider("TopLeftRadius"),
            // The amount by which the top right corner of the rectangle is rounded.
            ["TopRightRadius".ToLower()] = new PropertyFieldProvider("TopRightRadius")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionProjectedShadow" />. <br/>
    /// Represents a scene-based shadow calculated using the relationship between the light, the visual that casts the shadow, and the visual that receives the shadow, such that the shadow is drawn differently on each receiver. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionprojectedshadow">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider ProjectedShadow = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionProjectedShadow",
        "_compositor.CreateProjectedShadow()",
        new()
        {
            // The multiplier for the shadow's blur radius.
            ["BlurRadiusMultiplier".ToLower()] = new PropertyFieldProvider("BlurRadiusMultiplier"),
            // The collection of objects that cast a shadow on the receivers.
            ["Casters".ToLower()] = new CollectionFieldProvider("Casters.InsertAtTop"),
            // The composition light that determines the direction the shadow is cast.
            ["LightSource".ToLower()] = new PropertyFieldProvider("LightSource"),
            // The maximum blur radius of the shadow.
            ["MaxBlurRadius".ToLower()] = new PropertyFieldProvider("MaxBlurRadius"),
            // The minimum blur radius of the shadow.
            ["MinBlurRadius".ToLower()] = new PropertyFieldProvider("MinBlurRadius"),
            // The collection of objects that the shadow is cast on.
            ["Receivers".ToLower()] = new CollectionFieldProvider("Receivers.Add"),
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionProjectedShadowCaster" />. <br/>
    /// Represents an object that casts a projected shadow. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionprojectedshadowcaster">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider ProjectedShadowCaster = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionProjectedShadowCaster",
        "_compositor.CreateProjectedShadowCaster()",
        new()
        {
            // The brush used to draw the shadow.
            ["Brush".ToLower()] = new PropertyFieldProvider("Brush"),
            // The visual that casts the shadow.
            ["CastingVisual".ToLower()] = new PropertyFieldProvider("CastingVisual"),
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionProjectedShadowReceiver" />. <br/>
    /// Represents an object that can have a projected shadow cast on it. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionprojectedshadowreceiver">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider ProjectedShadowReceiver = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionProjectedShadowReceiver",
        "_compositor.CreateProjectedShadowReceiver()",
        new()
        {
            // The Visual that the shadow is cast on.
            ["ReceivingVisual".ToLower()] = new PropertyFieldProvider("ReceivingVisual"),
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionViewBox" />. <br/>
    /// Represents a container that maps shape visual tree coordinates onto the visual. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionviewbox">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider ViewBox = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionViewBox",
        "_compositor.CreateViewBox()",
        new()
        {
            // The horizontal alignment ratio of the view box.
            ["HorizontalAlignmentRatio".ToLower()] = new PropertyFieldProvider("HorizontalAlignmentRatio"),
            // The offset of the view box.
            ["Offset".ToLower()] = new PropertyFieldProvider("Offset"),
            // The height and width of the view box.
            ["Size".ToLower()] = new PropertyFieldProvider("Size"),
            // A value that specifies how content fits into the available space.
            ["Stretch".ToLower()] = new PropertyFieldProvider("Stretch"),
            // The vertical alignment ratio of the view box.
            ["VerticalAlignmentRatio".ToLower()] = new PropertyFieldProvider("VerticalAlignmentRatio")
        },
        null
    );
    
    /// <summary>
    /// Provider for <see cref="Microsoft.UI.Composition.CompositionSurfaceBrush" />. <br/>
    /// Represents a visual tree as an ICompositionSurface that can be used to paint a Visual using a CompositionBrush. <br/>
    /// More on <see href="https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionsurfacebrush">Microsoft Learn</see>.
    /// </summary>
    private static readonly SharpObjectProvider VisualSurface = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionVisualSurface",
        "_compositor.CreateVisualSurface()",
        new()
        {
            // The coordinates of the top-left corner of the part of the visual surface used for rendering.
            ["SourceOffset".ToLower()] = new PropertyFieldProvider("SourceOffset"),
            // The the height and width of the part of the visual surface used for rendering.
            ["SourceSize".ToLower()] = new PropertyFieldProvider("SourceSize"),
            // The root of the visual tree that is the target of the visual surface.
            ["SourceVisual".ToLower()] = new PropertyFieldProvider("SourceVisual")
        },
        null
    );
}