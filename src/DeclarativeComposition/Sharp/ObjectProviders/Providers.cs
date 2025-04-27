namespace DeclarativeComposition.Sharp.ObjectProviders;

partial class SharpObjectProvider
{
    /// <summary>
    /// Provider for the CompositionObject object.
    /// </summary>
    public static readonly SharpObjectProvider CompositionObject = new(
        null,
        "Microsoft.UI.Composition",
        "CompositionObject",
        null,
        new()
        {
            ["comment"] = new("Comment"),
        },
        null
    );

    /// <summary>
    /// Provider for the CompositionLight object.
    /// </summary>
    public static readonly SharpObjectProvider CompositionLight = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionLight",
        null,
        new()
        {
            ["isenabled"] = new("IsEnabled"),
        },
        null
    );
    
    /// <summary>
    /// Provider for the AmbientLight object.
    /// </summary>
    public static readonly SharpObjectProvider AmbientLight = new(
        CompositionLight,
        "Microsoft.UI.Composition",
        "AmbientLight",
        "_compositor.CreateAmbientLight()",
        new()
        {
            ["color"] = new("Color"),
            ["intensity"] = new("Intensity")
        },
        null
    );
    
    /// <summary>
    /// Provider for the DistantLight object.
    /// </summary>
    public static readonly SharpObjectProvider DistantLight = new(
        CompositionLight,
        "Microsoft.UI.Composition",
        "DistantLight",
        "_compositor.CreateDistantLight()",
        new()
        {
            ["color"] = new("Color"),
            ["coordinatespace"] = new("CoordinateSpace"),
            ["direction"] = new("Direction"),
            ["intensity"] = new("Intensity")
        },
        null
    );
    
    /// <summary>
    /// Provider for the PointLight object.
    /// </summary>
    public static readonly SharpObjectProvider PointLight = new(
        CompositionLight,
        "Microsoft.UI.Composition",
        "PointLight",
        "_compositor.CreatePointLight()",
        new()
        {
            ["color"] = new("Color"),
            ["constantattenuation"] = new("ConstantAttenuation"),
            ["coordinatespace"] = new("CoordinateSpace"),
            ["intensity"] = new("Intensity"),
            ["linearattenuation"] = new("LinearAttenuation"),
            ["maxattenuationcutoff"] = new("MaxAttenuationCutoff"),
            ["minattenuationcutoff"] = new("MinAttenuationCutoff"),
            ["offset"] = new("Offset"),
            ["quadraticattenuation"] = new("QuadraticAttenuation")
        },
        null
    );
    
    /// <summary>
    /// Provider for the SpotLight object.
    /// </summary>
    public static readonly SharpObjectProvider SpotLight = new(
        CompositionLight,
        "Microsoft.UI.Composition",
        "SpotLight",
        "_compositor.CreateSpotLight()",
        new()
        {
            ["constantattenuation"] = new("ConstantAttenuation"),
            ["coordinatespace"] = new("CoordinateSpace"),
            ["direction"] = new("Direction"),
            ["innerconeangle"] = new("InnerConeAngle"),
            ["innerconeangleindegrees"] = new("InnerConeAngleInDegrees"),
            ["innerconecolor"] = new("InnerConeColor"),
            ["innerconeintensity"] = new("InnerConeIntensity"),
            ["linearattenuation"] = new("LinearAttenuation"),
            ["maxattenuationcutoff"] = new("MaxAttenuationCutoff"),
            ["minattenuationcutoff"] = new("MinAttenuationCutoff"),
            ["offset"] = new("Offset"),
            ["outerconeangle"] = new("OuterConeAngle"),
            ["outerconeangleindegrees"] = new("OuterConeAngleInDegrees"),
            ["outerconecolor"] = new("OuterConeColor"),
            ["outerconeintensity"] = new("OuterConeIntensity"),
            ["quadraticattenuation"] = new("QuadraticAttenuation")
        },
        null
    );

    /// <summary>
    /// Provider for the CompositionBrush object.
    /// </summary>
    public static readonly SharpObjectProvider CompositionBrush = new(
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
    public static readonly SharpObjectProvider BackdropBrush = new(
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
    public static readonly SharpObjectProvider ColorBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionColorBrush",
        "_compositor.CreateColorBrush()",
        new()
        {
            ["color"] = new("Color")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionEffectBrush object.
    /// </summary>
    public static readonly SharpObjectProvider EffectBrush = new(
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
    public static readonly SharpObjectProvider GradientBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionGradientBrush",
        null,
        new()
        {
            ["anchorpoint"] = new("AnchorPoint"),
            ["centerpoint"] = new("CenterPoint"),
            ["colorstops"] = new("ColorStops"),
            ["extendmode"] = new("ExtendMode"),
            ["interpolationspace"] = new("InterpolationSpace"),
            ["mappingmode"] = new("MappingMode"),
            ["offset"] = new("Offset"),
            ["rotationangle"] = new("RotationAngle"),
            ["rotationangleindegrees"] = new("RotationAngleInDegrees"),
            ["scale"] = new("Scale"),
            ["transformmatrix"] = new("TransformMatrix")
        },
        null
    );

    /// <summary>
    /// Provider for the CompositionLinearGradientBrush object.
    /// </summary>
    public static readonly SharpObjectProvider LinearGradientBrush = new(
        GradientBrush,
        "Microsoft.UI.Composition",
        "CompositionLinearGradientBrush",
        "_compositor.CreateLinearGradientBrush()",
        new()
        {
            ["endpoint"] = new("EndPoint"),
            ["startpoint"] = new("StartPoint")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionRadialGradientBrush object.
    /// </summary>
    public static readonly SharpObjectProvider RadialGradientBrush = new(
        GradientBrush,
        "Microsoft.UI.Composition",
        "CompositionRadialGradientBrush",
        "_compositor.CreateRadialGradientBrush()",
        new()
        {
            ["ellipsecenter"] = new("EllipseCenter"),
            ["ellipseradius"] = new("EllipseRadius"),
            ["gradientoriginoffset"] = new("GradientOriginOffset")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionMaskBrush object.
    /// </summary>
    public static readonly SharpObjectProvider MaskBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionMaskBrush",
        "_compositor.CreateMaskBrush()",
        new()
        {
            ["mask"] = new("Mask"),
            ["source"] = new("Source")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionNineGridBrush object.
    /// </summary>
    public static readonly SharpObjectProvider NineGridBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionNineGridBrush",
        "_compositor.CreateNineGridBrush()",
        new()
        {
            ["bottominset"] = new("BottomInset"),
            ["bottominsetscale"] = new("BottomInsetScale"),
            ["iscenterhollow"] = new("IsCenterHollow"),
            ["leftinset"] = new("LeftInset"),
            ["leftinsetscale"] = new("LeftInsetScale"),
            ["rightinset"] = new("RightInset"),
            ["rightinsetscale"] = new("RightInsetScale"),
            ["source"] = new("Source"),
            ["topinset"] = new("TopInset"),
            ["topinsetscale"] = new("TopInsetScale")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionSurfaceBrush object.
    /// </summary>
    public static readonly SharpObjectProvider SurfaceBrush = new(
        CompositionBrush,
        "Microsoft.UI.Composition",
        "CompositionSurfaceBrush",
        "_compositor.CreateSurfaceBrush()",
        new()
        {
            ["anchorpoint"] = new("AnchorPoint"),
            ["bitmapinterpolationmode"] = new("BitmapInterpolationMode"),
            ["centerpoint"] = new("CenterPoint"),
            ["horizontalalignmentratio"] = new("HorizontalAlignmentRatio"),
            ["offset"] = new("Offset"),
            ["rotationangle"] = new("RotationAngle"),
            ["rotationangleindegrees"] = new("RotationAngleInDegrees"),
            ["scale"] = new("Scale"),
            ["snaptopixels"] = new("SnapToPixels"),
            ["stretch"] = new("Stretch"),
            ["surface"] = new("Surface"),
            ["transformmatrix"] = new("TransformMatrix"),
            ["verticalalignmentratio"] = new("VerticalAlignmentRatio")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionColorGradientStop object.
    /// </summary>
    public static readonly SharpObjectProvider ColorGradientStop = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionColorGradientStop",
        null,
        new()
        {
            ["color"] = new("Color"),
            ["offset"] = new("Offset")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionShape object.
    /// </summary>
    public static readonly SharpObjectProvider CompositionShape = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionShape",
        null,
        new()
        {
            ["centerpoint"] = new("CenterPoint"),
            ["offset"] = new("Offset"),
            ["rotationangle"] = new("RotationAngle"),
            ["rotationangleindegrees"] = new("RotationAngleInDegrees"),
            ["scale"] = new("Scale"),
            ["transformmatrix"] = new("TransformMatrix")
        },
        null
    );
    
    /// <summary>
    /// Provider for the ContainerShape object.
    /// </summary>
    public static readonly SharpObjectProvider ContainerShape = new(
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
    public static readonly SharpObjectProvider SpriteShape = new(
        CompositionShape,
        "Microsoft.UI.Composition",
        "CompositionSpriteShape",
        "_compositor.CreateSpriteShape()",
        new()
        {
            ["fillbrush"] = new("FillBrush"),
            ["geometry"] = new("Geometry"),
            ["isstrokenonscaling"] = new("IsStrokeNonScaling"),
            ["strokebrush"] = new("StrokeBrush"),
            ["strokedasharray"] = new("StrokeDashArray"),
            ["strokedashcap"] = new("StrokeDashCap"),
            ["strokedashoffset"] = new("StrokeDashOffset"),
            ["strokeendcap"] = new("StrokeEndCap"),
            ["strokelinejoin"] = new("StrokeLineJoin"),
            ["strokemiterlimit"] = new("StrokeMiterLimit"),
            ["strokeoffset"] = new("StrokeOffset"),
            ["strokestartcap"] = new("StrokeStartCap"),
            ["strokethickness"] = new("StrokeThickness")
        },
        null
    );
    
    /// <summary>
    /// Provider for the Visual object.
    /// </summary>
    public static readonly SharpObjectProvider Visual = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "Visual",
        null,
        new()
        {
            ["anchorpoint"] = new("AnchorPoint"),
            ["backfacevisibility"] = new("BackfaceVisibility"),
            ["bordermode"] = new("BorderMode"),
            ["centerpoint"] = new("CenterPoint"),
            ["clip"] = new("Clip"),
            ["compositemode"] = new("CompositeMode"),
            ["ishittestvisible"] = new("IsHitTestVisible"),
            ["ispixelsnappingenabled"] = new("IsPixelSnappingEnabled"),
            ["isvisible"] = new("IsVisible"),
            ["offset"] = new("Offset"),
            ["opacity"] = new("Opacity"),
            ["orientation"] = new("Orientation"),
            ["parentfortransform"] = new("ParentForTransform"),
            ["relativeoffsetadjustment"] = new("RelativeOffsetAdjustment"),
            ["relativesizeadjustment"] = new("RelativeSizeAdjustment"),
            ["rotationangle"] = new("RotationAngle"),
            ["rotationangleindegrees"] = new("RotationAngleInDegrees"),
            ["rotationaxis"] = new("RotationAxis"),
            ["scale"] = new("Scale"),
            ["size"] = new("Size"),
            ["transformmatrix"] = new("TransformMatrix")
        },
        null
    );
    
    /// <summary>
    /// Provider for the ContainerVisual object.
    /// </summary>
    public static readonly SharpObjectProvider ContainerVisual = new(
        Visual,
        "Microsoft.UI.Composition",
        "ContainerVisual",
        "_compositor.CreateContainerVisual()",
        new(),
        "Children.InsertAtTop"
    );
    
    /// <summary>
    /// Provider for the EffectVisual object.
    /// </summary>
    public static readonly SharpObjectProvider EffectVisual = new(
        Visual,
        "Microsoft.UI.Composition",
        "EffectVisual",
        "_compositor.CreateEffectVisual()",
        new()
        {
            ["effect"] = new("Effect"),
        },
        "Children.InsertAtTop"
    );
    
    /// <summary>
    /// Provider for the ImageVisual object.
    /// </summary>
    public static readonly SharpObjectProvider ImageVisual = new(
        Visual,
        "Microsoft.UI.Composition",
        "ImageVisual",
        "_compositor.CreateImageVisual()",
        new()
        {
            ["horizontalalignmentratio"] = new("HorizontalAlignmentRatio"),
            ["image"] = new("Image"),
            ["stretch"] = new("Stretch"),
            ["verticalalignmentratio"] = new("VerticalAlignmentRatio")
        },
        "Children.InsertAtTop"
    );
    
    public static readonly SharpObjectProvider LayerVisual = new(
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
    public static readonly SharpObjectProvider RedirectVisual = new(
        ContainerVisual,
        "Microsoft.UI.Composition",
        "RedirectVisual",
        "_compositor.CreateRedirectVisual()",
        new()
        {
            ["source"] = new("Source")
        },
        "Children.InsertAtTop"
    );
    
    /// <summary>
    /// Provider for the SceneVisual object.
    /// </summary>
    public static readonly SharpObjectProvider SceneVisual = new(
        ContainerVisual,
        "Microsoft.UI.Composition.Scenes",
        "SceneVisual",
        "_compositor.CreateSceneVisual()",
        new()
        {
            ["root"] = new("Root")
        },
        "Children.InsertAtTop"
    );
    
    /// <summary>
    /// Provider for the ShapeVisual object.
    /// </summary>
    public static readonly SharpObjectProvider ShapeVisual = new(
        ContainerVisual,
        "Microsoft.UI.Composition",
        "ShapeVisual",
        "_compositor.CreateShapeVisual()",
        new(),
        "Shapes.Append"
    );
    
    /// <summary>
    /// Provider for the SolidColorVisual object.
    /// </summary>
    public static readonly SharpObjectProvider SolidColorVisual = new(
        ContainerVisual,
        "Microsoft.UI.Composition",
        "SolidColorVisual",
        "_compositor.CreateSolidColorVisual()",
        new()
        {
            ["color"] = new("Color")
        },
        null
    );
    
    /// <summary>
    /// Provider for the SpriteVisual object.
    /// </summary>
    public static readonly SharpObjectProvider SpriteVisual = new(
        ContainerVisual,
        "Microsoft.UI.Composition",
        "SpriteVisual",
        "_compositor.CreateSpriteVisual()",
        new()
        {
            ["brush"] = new("Brush"),
            ["shadow"] = new("Shadow")
        },
        "Children.InsertAtTop"
    );
    
    /// <summary>
    /// Provider for the DelegatedInkTrailVisual object.
    /// </summary>
    public static readonly SharpObjectProvider DelegatedInkTrailVisual = new(
        Visual,
        "Microsoft.UI.Composition",
        "DelegatedInkTrailVisual",
        "_compositor.CreateDelegatedInkTrailVisual()",
        new(),
        null
    );
    
    /// <summary>
    /// Provider for the CompositionShadow object.
    /// </summary>
    public static readonly SharpObjectProvider CompositionShadow = new(
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
    public static readonly SharpObjectProvider DropShadow = new(
        CompositionShadow,
        "Microsoft.UI.Composition",
        "DropShadow",
        "_compositor.CreateDropShadow()",
        new()
        {
            ["blurradius"] = new("BlurRadius"),
            ["color"] = new("Color"),
            ["mask"] = new("Mask"),
            ["offset"] = new("Offset"),
            ["opacity"] = new("Opacity"),
            ["sourcepolicy"] = new("SourcePolicy")
        },
        null
    );

    /// <summary>
    /// Provider for the CompositionGeometry object.
    /// </summary>
    public static readonly SharpObjectProvider CompositionGeometry = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionGeometry",
        null,
        new()
        {
            ["trimend"] = new("TrimEnd"),
            ["trimoffset"] = new("TrimOffset"),
            ["trimstart"] = new("TrimStart")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionEllipseGeometry object.
    /// </summary>
    public static readonly SharpObjectProvider EllipseGeometry = new(
        CompositionGeometry,
        "Microsoft.UI.Composition",
        "CompositionEllipseGeometry",
        "_compositor.CreateEllipseGeometry()",
        new()
        {
            ["center"] = new("Center"),
            ["radius"] = new("Radius")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionLineGeometry object.
    /// </summary>
    public static readonly SharpObjectProvider LineGeometry = new(
        CompositionGeometry,
        "Microsoft.UI.Composition",
        "CompositionLineGeometry",
        "_compositor.CreateLineGeometry()",
        new()
        {
            ["end"] = new("End"),
            ["start"] = new("Start")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionPathGeometry object.
    /// </summary>
    public static readonly SharpObjectProvider PathGeometry = new(
        CompositionGeometry,
        "Microsoft.UI.Composition",
        "CompositionPathGeometry",
        "_compositor.CreatePathGeometry()",
        new()
        {
            ["path"] = new("Path")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionRectangleGeometry object.
    /// </summary>
    public static readonly SharpObjectProvider RectangleGeometry = new(
        CompositionGeometry,
        "Microsoft.UI.Composition",
        "CompositionRectangleGeometry",
        "_compositor.CreateRectangleGeometry()",
        new()
        {
            ["offset"] = new("Offset"),
            ["size"] = new("Size")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionRoundedRectangleGeometry object.
    /// </summary>
    public static readonly SharpObjectProvider RoundedRectangleGeometry = new(
        CompositionGeometry,
        "Microsoft.UI.Composition",
        "CompositionRoundedRectangleGeometry",
        "_compositor.CreateRoundedRectangleGeometry()",
        new()
        {
            ["cornerradius"] = new("CornerRadius"),
            ["offset"] = new("Offset"),
            ["size"] = new("Size")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionClip object.
    /// </summary>
    public static readonly SharpObjectProvider CompositionClip = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionClip",
        null,
        new()
        {
            ["anchorpoint"] = new("AnchorPoint"),
            ["centerpoint"] = new("CenterPoint"),
            ["offset"] = new("Offset"),
            ["rotationangle"] = new("RotationAngle"),
            ["rotationangleindegrees"] = new("RotationAngleInDegrees"),
            ["scale"] = new("Scale"),
            ["transformmatrix"] = new("TransformMatrix")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionGeometricClip object.
    /// </summary>
    public static readonly SharpObjectProvider GeometricClip = new(
        CompositionClip,
        "Microsoft.UI.Composition",
        "CompositionGeometricClip",
        "_compositor.CreateGeometricClip()",
        new()
        {
            ["geometry"] = new("Geometry"),
            ["viewbox"] = new("ViewBox")
        },
        null
    );
    
    /// <summary>
    /// Provider for the InsetClip object.
    /// </summary>
    public static readonly SharpObjectProvider InsetClip = new(
        CompositionClip,
        "Microsoft.UI.Composition",
        "InsetClip",
        "_compositor.CreateInsetClip()",
        new()
        {
            ["bottominset"] = new("BottomInset"),
            ["leftinset"] = new("LeftInset"),
            ["rightinset"] = new("RightInset"),
            ["topinset"] = new("TopInset")
        },
        null
    );
    
    /// <summary>
    /// Provider for the RectangleClip object.
    /// </summary>
    public static readonly SharpObjectProvider RectangleClip = new(
        CompositionClip,
        "Microsoft.UI.Composition",
        "RectangleClip",
        "_compositor.CreateRectangleClip()",
        new()
        {
            ["bottom"] = new("Bottom"),
            ["bottomleftradius"] = new("BottomLeftRadius"),
            ["bottomrightradius"] = new("BottomRightRadius"),
            ["left"] = new("Left"),
            ["right"] = new("Right"),
            ["top"] = new("Top"),
            ["topleftradius"] = new("TopLeftRadius"),
            ["toprightradius"] = new("TopRightRadius")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionProjectedShadow object.
    /// </summary>
    public static readonly SharpObjectProvider ProjectedShadow = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionProjectedShadow",
        "_compositor.CreateProjectedShadow()",
        new()
        {
            ["blurradiusmultiplier"] = new("BlurRadiusMultiplier"),
            ["casters"] = new("Casters"),
            ["lightsource"] = new("LightSource"),
            ["maxblurradius"] = new("MaxBlurRadius"),
            ["minblurradius"] = new("MinBlurRadius"),
            ["receivers"] = new("Receivers")
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionProjectedShadowCaster object.
    /// </summary>
    public static readonly SharpObjectProvider ProjectedShadowCaster = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionProjectedShadowCaster",
        null,
        new()
        {
            ["brush"] = new("Brush"),
            ["castingvisual"] = new("CastingVisual"),
        },
        null
    );
    
    /// <summary>
    /// Provider for the CompositionProjectedShadowReceiver object.
    /// </summary>
    public static readonly SharpObjectProvider ProjectedShadowReceiver = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionProjectedShadowReceiver",
        null,
        new()
        {
            ["receivingvisual"] = new("ReceivingVisual"),
        },
        null
    );
    
    public static readonly SharpObjectProvider ViewBox = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionViewBox",
        "_compositor.CreateViewBox()",
        new()
        {
            ["horizontalalignmentratio"] = new("HorizontalAlignmentRatio"),
            ["offset"] = new("Offset"),
            ["size"] = new("Size"),
            ["stretch"] = new("Stretch"),
            ["verticalalignmentratio"] = new("VerticalAlignmentRatio")
        },
        null
    );
    
    public static readonly SharpObjectProvider VisualSurface = new(
        CompositionObject,
        "Microsoft.UI.Composition",
        "CompositionVisualSurface",
        "_compositor.CreateVisualSurface()",
        new()
        {
            ["sourceoffset"] = new("SourceOffset"),
            ["sourcesize"] = new("SourceSize"),
            ["sourcevisual"] = new("SourceVisual")
        },
        null
    );
}