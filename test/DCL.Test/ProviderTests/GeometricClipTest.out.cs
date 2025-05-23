// Generated by DeclarativeComposition

namespace DCL.Test.ProviderTests {
    partial class GeometricClipTest {
        private Microsoft.UI.Composition.Compositor _compositor;

        public GeometricClipTest(Microsoft.UI.Composition.Compositor compositor) {
            _compositor = compositor;
            var obj1 = _compositor.CreateGeometricClip();
            obj1.Comment = "GeometricClip";
            obj1.AnchorPoint = new(0f, 0f);
            obj1.CenterPoint = new(0f, 0f);
            obj1.Offset = new(0f, 0f);
            obj1.RotationAngle = 0f;
            obj1.RotationAngleInDegrees = 0f;
            obj1.Scale = new(1f, 1f);
            obj1.TransformMatrix = new(1f, 0f, 0f, 1f, 0f, 0f);
            obj1.Geometry = _compositor.CreateRectangleGeometry();
            obj1.ViewBox = _compositor.CreateViewBox();
        }
    }
}