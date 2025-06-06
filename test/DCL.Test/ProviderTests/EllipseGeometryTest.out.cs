// Generated by DeclarativeComposition

namespace DCL.Test.ProviderTests {
    partial class EllipseGeometryTest {
        private Microsoft.UI.Composition.Compositor _compositor;
        
        public EllipseGeometryTest(Microsoft.UI.Composition.Compositor compositor) {
            _compositor = compositor;
            var obj1 = _compositor.CreateEllipseGeometry();
            obj1.Comment = "EllipseGeometry";
            obj1.TrimEnd = 0f;
            obj1.TrimOffset = 0f;
            obj1.TrimStart = 0f;
            obj1.Center = new(50f, 50f);
            obj1.Radius = new(10f, 10f);
        }
    }
}