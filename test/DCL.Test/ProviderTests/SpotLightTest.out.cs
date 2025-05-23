// Generated by DeclarativeComposition

namespace DCL.Test.ProviderTests {
    partial class SpotLightTest {
        private Microsoft.UI.Composition.Compositor _compositor;

        public SpotLightTest(Microsoft.UI.Composition.Compositor compositor) {
            _compositor = compositor;
            var obj1 = _compositor.CreateSpotLight();
            obj1.Comment = "SpotLight";
            obj1.IsEnabled = true;
            obj1.ConstantAttenuation = 1.0f;
            obj1.CoordinateSpace = _compositor.CreateSpriteVisual();
            obj1.Direction = new(0.0f, 0.0f, -1.0f);
            obj1.InnerConeAngle = 0.0f;
            obj1.InnerConeAngleInDegrees = 0.0f;
            obj1.InnerConeColor = Microsoft.UI.Colors.White;
            obj1.InnerConeIntensity = 1.0f;
            obj1.LinearAttenuation = 0.0f;
            obj1.MaxAttenuationCutoff = 1.0f;
            obj1.MinAttenuationCutoff = 0.0f;
            obj1.Offset = new(0.0f, 0.0f, 0.0f);
            obj1.OuterConeAngle = 0.0f;
            obj1.OuterConeAngleInDegrees = 0.0f;
            obj1.OuterConeColor = Microsoft.UI.Colors.White;
            obj1.OuterConeIntensity = 1.0f;
            obj1.QuadraticAttenuation = 0.0f;
        }
    }
}