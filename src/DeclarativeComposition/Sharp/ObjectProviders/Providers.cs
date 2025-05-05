namespace DeclarativeComposition.Sharp.ObjectProviders;

partial class SharpObjectProvider
{
    /// <summary>
    /// Provider for the CompositionObject object.
    /// </summary>
    private static readonly SharpObjectProvider CompositionObject = new(
        null,
        "Microsoft.UI.Composition",
        "CompositionObject",
        null,
        new()
        {
            ["Comment".ToLower()] = new("Comment"),
        },
        null
    );

    /// <summary>
    /// Provider for the CompositionLight object.
    /// </summary>
    private static readonly SharpObjectProvider CompositionLight = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionLight",
        null,
        new()
        {
            ["IsEnabled".ToLower()] = new("IsEnabled"),
        },
        null
    );
    
    /// <summary>
    /// Provider for the AmbientLight object.
    /// </summary>
    private static readonly SharpObjectProvider AmbientLight = new(
        CompositionLight,
        "Microsoft.UI.Composition",
        "AmbientLight",
        "_compositor.CreateAmbientLight()",
        new()
        {
            ["Color".ToLower()] = new("Color"),
            ["Intensity".ToLower()] = new("Intensity")
        },
        null
    );
    
    /// <summary>
    /// Provider for the DistantLight object.
    /// </summary>
    private static readonly SharpObjectProvider DistantLight = new(
        CompositionLight,
        "Microsoft.UI.Composition",
        "DistantLight",
        "_compositor.CreateDistantLight()",
        new()
        {
            ["Color".ToLower()] = new("Color"),
            ["CoordinateSpace".ToLower()] = new("CoordinateSpace"),
            ["Direction".ToLower()] = new("Direction"),
            ["Intensity".ToLower()] = new("Intensity")
        },
        null
    );
    
    /// <summary>
    /// Provider for the PointLight object.
    /// </summary>
    private static readonly SharpObjectProvider PointLight = new(
        CompositionLight,
        "Microsoft.UI.Composition",
        "PointLight",
        "_compositor.CreatePointLight()",
        new()
        {
            ["Color".ToLower()] = new("Color"),
            ["ConstantAttenuation".ToLower()] = new("ConstantAttenuation"),
            ["CoordinateSpace".ToLower()] = new("CoordinateSpace"),
            ["Intensity".ToLower()] = new("Intensity"),
            ["LinearAttenuation".ToLower()] = new("LinearAttenuation"),
            ["MaxAttenuationCutoff".ToLower()] = new("MaxAttenuationCutoff"),
            ["MinAttenuationCutoff".ToLower()] = new("MinAttenuationCutoff"),
            ["Offset".ToLower()] = new("Offset"),
            ["QuadraticAttenuation".ToLower()] = new("QuadraticAttenuation")
        },
        null
    );
    
    /// <summary>
    /// Provider for the SpotLight object.
    /// </summary>
    private static readonly SharpObjectProvider SpotLight = new(
        CompositionLight,
        "Microsoft.UI.Composition",
        "SpotLight",
        "_compositor.CreateSpotLight()",
        new()
        {
            ["ConstantAttenuation".ToLower()] = new("ConstantAttenuation"),
            ["CoordinateSpace".ToLower()] = new("CoordinateSpace"),
            ["Direction".ToLower()] = new("Direction"),
            ["InnerConeAngle".ToLower()] = new("InnerConeAngle"),
            ["InnerConeAngleInDegrees".ToLower()] = new("InnerConeAngleInDegrees"),
            ["InnerConeColor".ToLower()] = new("InnerConeColor"),
            ["InnerConeIntensity".ToLower()] = new("InnerConeIntensity"),
            ["LinearAttenuation".ToLower()] = new("LinearAttenuation"),
            ["MaxAttenuationCutoff".ToLower()] = new("MaxAttenuationCutoff"),
            ["MinAttenuationCutoff".ToLower()] = new("MinAttenuationCutoff"),
            ["Offset".ToLower()] = new("Offset"),
            ["OuterConeAngle".ToLower()] = new("OuterConeAngle"),
            ["OuterConeAngleInDegrees".ToLower()] = new("OuterConeAngleInDegrees"),
            ["OuterConeColor".ToLower()] = new("OuterConeColor"),
            ["OuterConeIntensity".ToLower()] = new("OuterConeIntensity"),
            ["QuadraticAttenuation".ToLower()] = new("QuadraticAttenuation")
        },
        null
    );

    /// <summary>
    /// Provider for the CompositionBrush object.
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
    /// Provider for the CompositionBackdropBrush object.
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
    /// Provider for the CompositionColorBrush object.
    /// </summary>
    private static readonly SharpObjectProvider ColorBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionColorBrush",
        "_compositor.CreateColorBrush()",
        new()
        {
            ["Color".ToLower()] = new("Color")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionEffectBrush object.
    /// </summary>
    private static readonly SharpObjectProvider EffectBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionEffectBrush",
        "_compositor.CreateEffectBrush()",
        new(),
        null
    );

    /// <summary>
    /// Provider for the CompositionGradientBrush object.
    /// </summary>
    private static readonly SharpObjectProvider GradientBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionGradientBrush",
        null,
        new()
        {
            ["AnchorPoint".ToLower()] = new("AnchorPoint"),
            ["CenterPoint".ToLower()] = new("CenterPoint"),
            ["ColorStops".ToLower()] = new("ColorStops"),
            ["ExtendMode".ToLower()] = new("ExtendMode"),
            ["InterpolationSpace".ToLower()] = new("InterpolationSpace"),
            ["MappingMode".ToLower()] = new("MappingMode"),
            ["Offset".ToLower()] = new("Offset"),
            ["RotationAngle".ToLower()] = new("RotationAngle"),
            ["RotationAngleInDegrees".ToLower()] = new("RotationAngleInDegrees"),
            ["Scale".ToLower()] = new("Scale"),
            ["TransformMatrix".ToLower()] = new("TransformMatrix")
        },
        null
    );

    /// <summary>
    /// Provider for the CompositionLinearGradientBrush object.
    /// </summary>
    private static readonly SharpObjectProvider LinearGradientBrush = new(
        GradientBrush,
        "Microsoft.UI.Composition",
        "CompositionLinearGradientBrush",
        "_compositor.CreateLinearGradientBrush()",
        new()
        {
            ["EndPoint".ToLower()] = new("EndPoint"),
            ["StartPoint".ToLower()] = new("StartPoint")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionRadialGradientBrush object.
    /// </summary>
    private static readonly SharpObjectProvider RadialGradientBrush = new(
        GradientBrush,
        "Microsoft.UI.Composition",
        "CompositionRadialGradientBrush",
        "_compositor.CreateRadialGradientBrush()",
        new()
        {
            ["EllipseCenter".ToLower()] = new("EllipseCenter"),
            ["EllipseRadius".ToLower()] = new("EllipseRadius"),
            ["GradientOriginOffset".ToLower()] = new("GradientOriginOffset")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionMaskBrush object.
    /// </summary>
    private static readonly SharpObjectProvider MaskBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionMaskBrush",
        "_compositor.CreateMaskBrush()",
        new()
        {
            ["Mask".ToLower()] = new("Mask"),
            ["Source".ToLower()] = new("Source")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionNineGridBrush object.
    /// </summary>
    private static readonly SharpObjectProvider NineGridBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionNineGridBrush",
        "_compositor.CreateNineGridBrush()",
        new()
        {
            ["BottomInset".ToLower()] = new("BottomInset"),
            ["BottomInsetScale".ToLower()] = new("BottomInsetScale"),
            ["IsCenterHollow".ToLower()] = new("IsCenterHollow"),
            ["LeftInset".ToLower()] = new("LeftInset"),
            ["LeftInsetScale".ToLower()] = new("LeftInsetScale"),
            ["RightInset".ToLower()] = new("RightInset"),
            ["RightInsetScale".ToLower()] = new("RightInsetScale"),
            ["Source".ToLower()] = new("Source"),
            ["TopInset".ToLower()] = new("TopInset"),
            ["TopInsetScale".ToLower()] = new("TopInsetScale")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionSurfaceBrush object.
    /// </summary>
    private static readonly SharpObjectProvider SurfaceBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionSurfaceBrush",
        "_compositor.CreateSurfaceBrush()",
        new()
        {
            ["AnchorPoint".ToLower()] = new("AnchorPoint"),
            ["BitmapInterpolationMode".ToLower()] = new("BitmapInterpolationMode"),
            ["CenterPoint".ToLower()] = new("CenterPoint"),
            ["HorizontalAlignmentRatio".ToLower()] = new("HorizontalAlignmentRatio"),
            ["Offset".ToLower()] = new("Offset"),
            ["RotationAngle".ToLower()] = new("RotationAngle"),
            ["RotationAngleInDegrees".ToLower()] = new("RotationAngleInDegrees"),
            ["Scale".ToLower()] = new("Scale"),
            ["SnapToPixels".ToLower()] = new("SnapToPixels"),
            ["Stretch".ToLower()] = new("Stretch"),
            ["Surface".ToLower()] = new("Surface"),
            ["TransformMatrix".ToLower()] = new("TransformMatrix"),
            ["VerticalAlignmentRatio".ToLower()] = new("VerticalAlignmentRatio")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionColorGradientStop object.
    /// </summary>
    private static readonly SharpObjectProvider ColorGradientStop = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionColorGradientStop",
        "_compositor.CreateColorGradientStop()",
        new()
        {
            ["Color".ToLower()] = new("Color"),
            ["Offset".ToLower()] = new("Offset")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionShape object.
    /// </summary>
    private static readonly SharpObjectProvider CompositionShape = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionShape",
        null,
        new()
        {
            ["CenterPoint".ToLower()] = new("CenterPoint"),
            ["Offset".ToLower()] = new("Offset"),
            ["RotationAngle".ToLower()] = new("RotationAngle"),
            ["RotationAngleInDegrees".ToLower()] = new("RotationAngleInDegrees"),
            ["Scale".ToLower()] = new("Scale"),
            ["TransformMatrix".ToLower()] = new("TransformMatrix")
        },
        null
    );
    
    /// <summary>
    /// Provider for the ContainerShape object.
    /// </summary>
    private static readonly SharpObjectProvider ContainerShape = new(
        CompositionShape,
        "Microsoft.UI.Composition",
        "ContainerShape",
        "_compositor.CreateContainerShape()",
        new(),
        "Shapes.Append"
    );
    
    /// <summary>
    /// Provider for the CompositionSpriteShape object.
    /// </summary>
    private static readonly SharpObjectProvider SpriteShape = new(
        CompositionShape,
        "Microsoft.UI.Composition",
        "CompositionSpriteShape",
        "_compositor.CreateSpriteShape()",
        new()
        {
            ["FillBrush".ToLower()] = new("FillBrush"),
            ["Geometry".ToLower()] = new("Geometry"),
            ["IsStrokeNonScaling".ToLower()] = new("IsStrokeNonScaling"),
            ["StrokeBrush".ToLower()] = new("StrokeBrush"),
            ["StrokeDashArray".ToLower()] = new("StrokeDashArray"),
            ["StrokeDashCap".ToLower()] = new("StrokeDashCap"),
            ["StrokeDashOffset".ToLower()] = new("StrokeDashOffset"),
            ["StrokeEndCap".ToLower()] = new("StrokeEndCap"),
            ["StrokeLineJoin".ToLower()] = new("StrokeLineJoin"),
            ["StrokeMiterLimit".ToLower()] = new("StrokeMiterLimit"),
            ["StrokeStartCap".ToLower()] = new("StrokeStartCap"),
            ["StrokeThickness".ToLower()] = new("StrokeThickness")
        },
        null
    );
    
    /// <summary>
    /// Provider for the Visual object.
    /// </summary>
    private static readonly SharpObjectProvider Visual = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "Visual",
        null,
        new()
        {
            ["AnchorPoint".ToLower()] = new("AnchorPoint"),
            ["BackfaceVisibility".ToLower()] = new("BackfaceVisibility"),
            ["BorderMode".ToLower()] = new("BorderMode"),
            ["CenterPoint".ToLower()] = new("CenterPoint"),
            ["Clip".ToLower()] = new("Clip"),
            ["CompositeMode".ToLower()] = new("CompositeMode"),
            ["IsHitTestVisible".ToLower()] = new("IsHitTestVisible"),
            ["IsPixelSnappingEnabled".ToLower()] = new("IsPixelSnappingEnabled"),
            ["IsVisible".ToLower()] = new("IsVisible"),
            ["Offset".ToLower()] = new("Offset"),
            ["Opacity".ToLower()] = new("Opacity"),
            ["Orientation".ToLower()] = new("Orientation"),
            ["ParentForTransform".ToLower()] = new("ParentForTransform"),
            ["RelativeOffsetAdjustment".ToLower()] = new("RelativeOffsetAdjustment"),
            ["RelativeSizeAdjustment".ToLower()] = new("RelativeSizeAdjustment"),
            ["RotationAngle".ToLower()] = new("RotationAngle"),
            ["RotationAngleInDegrees".ToLower()] = new("RotationAngleInDegrees"),
            ["RotationAxis".ToLower()] = new("RotationAxis"),
            ["Scale".ToLower()] = new("Scale"),
            ["Size".ToLower()] = new("Size"),
            ["TransformMatrix".ToLower()] = new("TransformMatrix")
        },
        null
    );
    
    /// <summary>
    /// Provider for the ContainerVisual object.
    /// </summary>
    private static readonly SharpObjectProvider ContainerVisual = new(
        Visual,
        "Microsoft.UI.Composition",
        "ContainerVisual",
        "_compositor.CreateContainerVisual()",
        new(),
        "Children.InsertAtTop"
    );
    
    private static readonly SharpObjectProvider LayerVisual = new(
        ContainerVisual,
        "Microsoft.UI.Composition",
        "LayerVisual",
        "_compositor.CreateLayerVisual()",
        new(),
        "Children.InsertAtTop"
    );
    
    /// <summary>
    /// Provider for the RedirectVisual object.
    /// </summary>
    private static readonly SharpObjectProvider RedirectVisual = new(
        ContainerVisual,
        "Microsoft.UI.Composition",
        "RedirectVisual",
        "_compositor.CreateRedirectVisual()",
        new()
        {
            ["Source".ToLower()] = new("Source")
        },
        "Children.InsertAtTop"
    );
    
    /// <summary>
    /// Provider for the SceneVisual object.
    /// </summary>
    private static readonly SharpObjectProvider SceneVisual = new(
        ContainerVisual,
        "Microsoft.UI.Composition.Scenes",
        "SceneVisual",
        "Microsoft.UI.Composition.Scenes.SceneVisual.Create(_compositor)",
        new()
        {
            ["Root".ToLower()] = new("Root")
        },
        "Children.InsertAtTop"
    );
    
    /// <summary>
    /// Provider for the ShapeVisual object.
    /// </summary>
    private static readonly SharpObjectProvider ShapeVisual = new(
        ContainerVisual,
        "Microsoft.UI.Composition",
        "ShapeVisual",
        "_compositor.CreateShapeVisual()",
        new(),
        "Shapes.Append"
    );
    
    /// <summary>
    /// Provider for the SpriteVisual object.
    /// </summary>
    private static readonly SharpObjectProvider SpriteVisual = new(
        ContainerVisual,
        "Microsoft.UI.Composition",
        "SpriteVisual",
        "_compositor.CreateSpriteVisual()",
        new()
        {
            ["Brush".ToLower()] = new("Brush"),
            ["Shadow".ToLower()] = new("Shadow")
        },
        "Children.InsertAtTop"
    );
    
    /// <summary>
    /// Provider for the CompositionShadow object.
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
    /// Provider for the DropShadow object.
    /// </summary>
    private static readonly SharpObjectProvider DropShadow = new(
        CompositionShadow,
        "Microsoft.UI.Composition",
        "DropShadow",
        "_compositor.CreateDropShadow()",
        new()
        {
            ["BlurRadius".ToLower()] = new("BlurRadius"),
            ["Color".ToLower()] = new("Color"),
            ["Mask".ToLower()] = new("Mask"),
            ["Offset".ToLower()] = new("Offset"),
            ["Opacity".ToLower()] = new("Opacity"),
            ["SourcePolicy".ToLower()] = new("SourcePolicy")
        },
        null
    );

    /// <summary>
    /// Provider for the CompositionGeometry object.
    /// </summary>
    private static readonly SharpObjectProvider CompositionGeometry = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionGeometry",
        null,
        new()
        {
            ["TrimEnd".ToLower()] = new("TrimEnd"),
            ["TrimOffset".ToLower()] = new("TrimOffset"),
            ["TrimStart".ToLower()] = new("TrimStart")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionEllipseGeometry object.
    /// </summary>
    private static readonly SharpObjectProvider EllipseGeometry = new(
        CompositionGeometry,
        "Microsoft.UI.Composition",
        "CompositionEllipseGeometry",
        "_compositor.CreateEllipseGeometry()",
        new()
        {
            ["Center".ToLower()] = new("Center"),
            ["Radius".ToLower()] = new("Radius")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionLineGeometry object.
    /// </summary>
    private static readonly SharpObjectProvider LineGeometry = new(
        CompositionGeometry,
        "Microsoft.UI.Composition",
        "CompositionLineGeometry",
        "_compositor.CreateLineGeometry()",
        new()
        {
            ["End".ToLower()] = new("End"),
            ["Start".ToLower()] = new("Start")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionPathGeometry object.
    /// </summary>
    private static readonly SharpObjectProvider PathGeometry = new(
        CompositionGeometry,
        "Microsoft.UI.Composition",
        "CompositionPathGeometry",
        "_compositor.CreatePathGeometry()",
        new()
        {
            ["Path".ToLower()] = new("Path")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionRectangleGeometry object.
    /// </summary>
    private static readonly SharpObjectProvider RectangleGeometry = new(
        CompositionGeometry,
        "Microsoft.UI.Composition",
        "CompositionRectangleGeometry",
        "_compositor.CreateRectangleGeometry()",
        new()
        {
            ["Offset".ToLower()] = new("Offset"),
            ["Size".ToLower()] = new("Size")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionRoundedRectangleGeometry object.
    /// </summary>
    private static readonly SharpObjectProvider RoundedRectangleGeometry = new(
        CompositionGeometry,
        "Microsoft.UI.Composition",
        "CompositionRoundedRectangleGeometry",
        "_compositor.CreateRoundedRectangleGeometry()",
        new()
        {
            ["CornerRadius".ToLower()] = new("CornerRadius"),
            ["Offset".ToLower()] = new("Offset"),
            ["Size".ToLower()] = new("Size")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionClip object.
    /// </summary>
    private static readonly SharpObjectProvider CompositionClip = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionClip",
        null,
        new()
        {
            ["AnchorPoint".ToLower()] = new("AnchorPoint"),
            ["CenterPoint".ToLower()] = new("CenterPoint"),
            ["Offset".ToLower()] = new("Offset"),
            ["RotationAngle".ToLower()] = new("RotationAngle"),
            ["RotationAngleInDegrees".ToLower()] = new("RotationAngleInDegrees"),
            ["Scale".ToLower()] = new("Scale"),
            ["TransformMatrix".ToLower()] = new("TransformMatrix")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionGeometricClip object.
    /// </summary>
    private static readonly SharpObjectProvider GeometricClip = new(
        CompositionClip,
        "Microsoft.UI.Composition",
        "CompositionGeometricClip",
        "_compositor.CreateGeometricClip()",
        new()
        {
            ["Geometry".ToLower()] = new("Geometry"),
            ["ViewBox".ToLower()] = new("ViewBox")
        },
        null
    );
    
    /// <summary>
    /// Provider for the InsetClip object.
    /// </summary>
    private static readonly SharpObjectProvider InsetClip = new(
        CompositionClip,
        "Microsoft.UI.Composition",
        "InsetClip",
        "_compositor.CreateInsetClip()",
        new()
        {
            ["BottomInset".ToLower()] = new("BottomInset"),
            ["LeftInset".ToLower()] = new("LeftInset"),
            ["RightInset".ToLower()] = new("RightInset"),
            ["TopInset".ToLower()] = new("TopInset")
        },
        null
    );
    
    /// <summary>
    /// Provider for the RectangleClip object.
    /// </summary>
    private static readonly SharpObjectProvider RectangleClip = new(
        CompositionClip,
        "Microsoft.UI.Composition",
        "RectangleClip",
        "_compositor.CreateRectangleClip()",
        new()
        {
            ["Bottom".ToLower()] = new("Bottom"),
            ["BottomLeftRadius".ToLower()] = new("BottomLeftRadius"),
            ["BottomRightRadius".ToLower()] = new("BottomRightRadius"),
            ["Left".ToLower()] = new("Left"),
            ["Right".ToLower()] = new("Right"),
            ["Top".ToLower()] = new("Top"),
            ["TopLeftRadius".ToLower()] = new("TopLeftRadius"),
            ["TopRightRadius".ToLower()] = new("TopRightRadius")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionProjectedShadow object.
    /// </summary>
    private static readonly SharpObjectProvider ProjectedShadow = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionProjectedShadow",
        "_compositor.CreateProjectedShadow()",
        new()
        {
            ["BlurRadiusMultiplier".ToLower()] = new("BlurRadiusMultiplier"),
            ["Casters".ToLower()] = new("Casters"),
            ["LightSource".ToLower()] = new("LightSource"),
            ["MaxBlurRadius".ToLower()] = new("MaxBlurRadius"),
            ["MinBlurRadius".ToLower()] = new("MinBlurRadius"),
            ["Receivers".ToLower()] = new("Receivers")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionProjectedShadowCaster object.
    /// </summary>
    private static readonly SharpObjectProvider ProjectedShadowCaster = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionProjectedShadowCaster",
        "_compositor.CreateProjectedShadowCaster()",
        new()
        {
            ["Brush".ToLower()] = new("Brush"),
            ["CastingVisual".ToLower()] = new("CastingVisual"),
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionProjectedShadowReceiver object.
    /// </summary>
    private static readonly SharpObjectProvider ProjectedShadowReceiver = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionProjectedShadowReceiver",
        "_compositor.CreateProjectedShadowReceiver()",
        new()
        {
            ["ReceivingVisual".ToLower()] = new("ReceivingVisual"),
        },
        null
    );
    
    private static readonly SharpObjectProvider ViewBox = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionViewBox",
        "_compositor.CreateViewBox()",
        new()
        {
            ["HorizontalAlignmentRatio".ToLower()] = new("HorizontalAlignmentRatio"),
            ["Offset".ToLower()] = new("Offset"),
            ["Size".ToLower()] = new("Size"),
            ["Stretch".ToLower()] = new("Stretch"),
            ["VerticalAlignmentRatio".ToLower()] = new("VerticalAlignmentRatio")
        },
        null
    );
    
    private static readonly SharpObjectProvider VisualSurface = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionVisualSurface",
        "_compositor.CreateVisualSurface()",
        new()
        {
            ["SourceOffset".ToLower()] = new("SourceOffset"),
            ["SourceSize".ToLower()] = new("SourceSize"),
            ["SourceVisual".ToLower()] = new("SourceVisual")
        },
        null
    );
}