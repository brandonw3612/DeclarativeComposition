// Generated by DeclarativeComposition

namespace DCL.Test.ProviderTests {
    partial class PointLightTest {
        private Microsoft.UI.Composition.Compositor _compositor;

        public PointLightTest(Microsoft.UI.Composition.Compositor compositor) {
            _compositor = compositor;
            var obj1 = _compositor.CreatePointLight();
            obj1.Comment = "PointLight";
            obj1.IsEnabled = true;
            obj1.Color = Microsoft.UI.Colors.White;
            obj1.ConstantAttenuation = 0.0f;
            obj1.CoordinateSpace = _compositor.CreateSpriteVisual();
            obj1.Intensity = 1.0f;
            obj1.LinearAttenuation = 0.0f;
            obj1.MaxAttenuationCutoff = 1.0f;
            obj1.MinAttenuationCutoff = 0.0f;
            obj1.Offset = new(0.0f, 0.0f, 0.0f);
            obj1.QuadraticAttenuation = 0.0f;
        }
    }
}