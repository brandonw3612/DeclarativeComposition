namespace DeclarativeComposition.CSharp;

public class MetaLibrary
{
    private static MetaLibrary? _current;
    public static MetaLibrary Current => _current ??= new();
    
    public Dictionary<string, ObjectMeta> DeclarableCOMs { get; }
    
    public Dictionary<string, ObjectMeta> AllObjectMetas { get; }
    
    private MetaLibrary()
    {
        DeclarableCOMs = new[] {
            Metas.AmbientLight,
            Metas.DistantLight,
            Metas.PointLight,
            Metas.SpotLight,
            Metas.BackdropBrush,
            Metas.ColorBrush,
            // TODO: Support for EffectBrush
            Metas.LinearGradientBrush,
            Metas.RadialGradientBrush,
            Metas.MaskBrush,
            Metas.NineGridBrush,
            Metas.SurfaceBrush,
            Metas.ColorGradientStop,
            Metas.ContainerShape,
            Metas.SpriteShape,
            Metas.ContainerVisual,
            Metas.LayerVisual,
            Metas.RedirectVisual,
            Metas.SceneVisual,
            Metas.ShapeVisual,
            Metas.SpriteVisual,
            Metas.DropShadow,
            Metas.EllipseGeometry,
            Metas.LineGeometry,
            Metas.PathGeometry,
            Metas.RectangleGeometry,
            Metas.RoundedRectangleGeometry,
            Metas.GeometricClip,
            Metas.InsetClip,
            Metas.RectangleClip,
            Metas.ProjectedShadow,
            Metas.ProjectedShadowCaster,
            Metas.ProjectedShadowReceiver,
            Metas.ViewBox,
            Metas.VisualSurface
        }.ToDictionary(
            static m => m.Alias,
            static m => m as ObjectMeta,
            StringComparer.OrdinalIgnoreCase
        );

        AllObjectMetas = new()
        {
            // Base
            [nameof(Metas.Obj)] = Metas.Obj,
            // Sugared objects
            [nameof(Metas.Bool)] = Metas.Bool,
            [nameof(Metas.Single)] = Metas.Single,
            [nameof(Metas.String)] = Metas.String,
            [nameof(Metas.Vector2)] = Metas.Vector2,
            [nameof(Metas.Vector3)] = Metas.Vector3,
            [nameof(Metas.Quaternion)] = Metas.Quaternion,
            [nameof(Metas.Matrix3X2)] = Metas.Matrix3X2,
            [nameof(Metas.Matrix4X4)] = Metas.Matrix4X4,
            [nameof(Metas.Color)] = Metas.Color,
            // Composition enums
            [nameof(Metas.GradientExtendMode)] = Metas.GradientExtendMode,
            [nameof(Metas.ColorSpace)] = Metas.ColorSpace,
            [nameof(Metas.MappingMode)] = Metas.MappingMode,
            [nameof(Metas.BitmapInterpolationMode)] = Metas.BitmapInterpolationMode,
            [nameof(Metas.Stretch)] = Metas.Stretch,
            [nameof(Metas.StrokeCap)] = Metas.StrokeCap,
            [nameof(Metas.StrokeLineJoin)] = Metas.StrokeLineJoin,
            [nameof(Metas.BackfaceVisibility)] = Metas.BackfaceVisibility,
            [nameof(Metas.BorderMode)] = Metas.BorderMode,
            [nameof(Metas.CompositeMode)] = Metas.CompositeMode,
            [nameof(Metas.DropShadowSourcePolicy)] = Metas.DropShadowSourcePolicy,
            // Composition objects
            [nameof(Metas.CompositionObject)] = Metas.CompositionObject,
            [nameof(Metas.Light)] = Metas.Light,
            [nameof(Metas.AmbientLight)] = Metas.AmbientLight,
            [nameof(Metas.DistantLight)] = Metas.DistantLight,
            [nameof(Metas.PointLight)] = Metas.PointLight,
            [nameof(Metas.SpotLight)] = Metas.SpotLight,
            [nameof(Metas.Brush)] = Metas.Brush,
            [nameof(Metas.BackdropBrush)] = Metas.BackdropBrush,
            [nameof(Metas.ColorBrush)] = Metas.ColorBrush,
            [nameof(Metas.GradientBrush)] = Metas.GradientBrush,
            [nameof(Metas.LinearGradientBrush)] = Metas.LinearGradientBrush,
            [nameof(Metas.RadialGradientBrush)] = Metas.RadialGradientBrush,
            [nameof(Metas.MaskBrush)] = Metas.MaskBrush,
            [nameof(Metas.NineGridBrush)] = Metas.NineGridBrush,
            [nameof(Metas.SurfaceBrush)] = Metas.SurfaceBrush,
            [nameof(Metas.ColorGradientStop)] = Metas.ColorGradientStop,
            [nameof(Metas.Shape)] = Metas.Shape,
            [nameof(Metas.ContainerShape)] = Metas.ContainerShape,
            [nameof(Metas.SpriteShape)] = Metas.SpriteShape,
            [nameof(Metas.Visual)] = Metas.Visual,
            [nameof(Metas.ContainerVisual)] = Metas.ContainerVisual,
            [nameof(Metas.LayerVisual)] = Metas.LayerVisual,
            [nameof(Metas.RedirectVisual)] = Metas.RedirectVisual,
            [nameof(Metas.SceneVisual)] = Metas.SceneVisual,
            [nameof(Metas.ShapeVisual)] = Metas.ShapeVisual,
            [nameof(Metas.SpriteVisual)] = Metas.SpriteVisual,
            [nameof(Metas.Shadow)] = Metas.Shadow,
            [nameof(Metas.DropShadow)] = Metas.DropShadow,
            [nameof(Metas.Geometry)] = Metas.Geometry,
            [nameof(Metas.EllipseGeometry)] = Metas.EllipseGeometry,
            [nameof(Metas.LineGeometry)] = Metas.LineGeometry,
            [nameof(Metas.PathGeometry)] = Metas.PathGeometry,
            [nameof(Metas.RectangleGeometry)] = Metas.RectangleGeometry,
            [nameof(Metas.RoundedRectangleGeometry)] = Metas.RoundedRectangleGeometry,
            [nameof(Metas.Clip)] = Metas.Clip,
            [nameof(Metas.GeometricClip)] = Metas.GeometricClip,
            [nameof(Metas.InsetClip)] = Metas.InsetClip,
            [nameof(Metas.RectangleClip)] = Metas.RectangleClip,
            [nameof(Metas.ProjectedShadow)] = Metas.ProjectedShadow,
            [nameof(Metas.ProjectedShadowCaster)] = Metas.ProjectedShadowCaster,
            [nameof(Metas.ProjectedShadowReceiver)] = Metas.ProjectedShadowReceiver,
            [nameof(Metas.ViewBox)] = Metas.ViewBox,
            [nameof(Metas.VisualSurface)] = Metas.VisualSurface
        };
    }
}