namespace DeclarativeComposition.Sharp.ObjectProviders;

/// <summary>
/// C# object provider for composition objects.
/// </summary>
public partial class SharpObjectProvider
{
    private SharpObjectProvider(SharpObjectProvider? parent, string namespaceName, string className, string? constructorCall, Dictionary<string, SharpPropertyProvider> properties, string? childAppendCall)
    {
        Parent = parent;
        NamespaceName = namespaceName;
        ClassName = className;
        ConstructorCall = constructorCall;
        Properties = properties;
        ChildAppendCall = childAppendCall;
        if (parent is null) return;
        foreach (var p in parent.Properties)
        {
            Properties.Add(p.Key, p.Value);
        }
    }

    /// <summary>
    /// Parent object provider for the current object provider.
    /// </summary>
    public SharpObjectProvider? Parent { get; }
    
    /// <summary>
    /// Namespace name of the object type.
    /// </summary>
    public string NamespaceName { get; }
    
    /// <summary>
    /// Class name of the object type.
    /// </summary>
    public string ClassName { get; }
    
    /// <summary>
    /// Constructor call for the object.
    /// </summary>
    public string? ConstructorCall { get; }
    
    /// <summary>
    /// Properties of the object type.
    /// </summary>
    public Dictionary<string, SharpPropertyProvider> Properties { get; }
    
    /// <summary>
    /// Call to append a child to the object.
    /// </summary>
    public string? ChildAppendCall { get; }
    
    /// <summary>
    /// Factory method to create an object provider from a type alias.
    /// </summary>
    /// <param name="typeAlias">Type alias of the object type.</param>
    /// <returns>Object provider instance or null if not found.</returns>
    public static SharpObjectProvider? FromTypeAlias(string typeAlias) =>
        typeAlias switch
        {
            "AmbientLight" => AmbientLight,
            "BackdropBrush" or "CompositionBackdropBrush" => BackdropBrush,
            "ColorBrush" or "CompositionColorBrush" => ColorBrush,
            "ColorGradientStop" or "CompositionColorGradientStop" => ColorGradientStop,
            "ContainerShape" => ContainerShape,
            "ContainerVisual" => ContainerVisual,
            "DelegatedInkTrailVisual" => DelegatedInkTrailVisual,
            "DistantLight" => DistantLight,
            "DropShadow" => DropShadow,
            "EffectBrush" or "CompositionEffectBrush" => EffectBrush,
            "EffectVisual" => EffectVisual,
            "EllipseGeometry" or "CompositionEllipseGeometry" => EllipseGeometry,
            "GeometricClip" or "CompositionGeometricClip" => GeometricClip,
            "ImageVisual" => ImageVisual,
            "InsetClip" => InsetClip,
            "LayerVisual" => LayerVisual,
            "LineGeometry" or "CompositionLineGeometry" => LineGeometry,
            "LinearGradientBrush" or "CompositionLinearGradientBrush" => LinearGradientBrush,
            "MaskBrush" or "CompositionMaskBrush" => MaskBrush,
            "NineGridBrush" or "CompositionNineGridBrush" => NineGridBrush,
            "PathGeometry" or "CompositionPathGeometry" => PathGeometry,
            "PointLight" => PointLight,
            "ProjectedShadow" or "CompositionProjectedShadow" => ProjectedShadow,
            "ProjectedShadowCaster" or "CompositionProjectedShadowCaster" => ProjectedShadowCaster,
            "ProjectedShadowReceiver" or "CompositionProjectedShadowReceiver" => ProjectedShadowReceiver,
            "RadialGradientBrush" or "CompositionRadialGradientBrush" => RadialGradientBrush,
            "RectangleClip" => RectangleClip,
            "RectangleGeometry" or "CompositionRectangleGeometry" => RectangleGeometry,
            "RedirectVisual" => RedirectVisual,
            "RoundedRectangleGeometry" or "CompositionRoundedRectangleGeometry" => RoundedRectangleGeometry,
            "SceneVisual" => SceneVisual,
            "ShapeVisual" => ShapeVisual,
            "SolidColorVisual" => SolidColorVisual,
            "SpotLight" => SpotLight,
            "SpriteShape" or "CompositionSpriteShape" => SpriteShape,
            "SpriteVisual" => SpriteVisual,
            "SurfaceBrush" or "CompositionSurfaceBrush" => SurfaceBrush,
            "ViewBox" or "CompositionViewBox" => ViewBox,
            "VisualSurface" or "CompositionVisualSurface" => VisualSurface,
            _ => null
        };
}