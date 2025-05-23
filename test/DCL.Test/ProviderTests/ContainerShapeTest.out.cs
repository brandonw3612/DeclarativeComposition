// Generated by DeclarativeComposition

namespace DCL.Test.ProviderTests {

    partial class ContainerShapeTest {

        private Microsoft.UI.Composition.Compositor _compositor;


        public ContainerShapeTest(Microsoft.UI.Composition.Compositor compositor) {
            _compositor = compositor;

            var obj1 = _compositor.CreateContainerShape();
            obj1.Comment = "ContainerShape";
            obj1.CenterPoint = new(0f, 0f);
            obj1.Offset = new(0f, 0f);
            obj1.RotationAngle = 0f;
            obj1.RotationAngleInDegrees = 0f;
            obj1.Scale = new(1f, 1f);
            obj1.TransformMatrix = new(1f, 0f, 0f, 1f, 0f, 0f);
            var obj2 = _compositor.CreateSpriteShape();
            obj1.Shapes.Append(obj2);
            var obj3 = _compositor.CreateSpriteShape();
            obj1.Shapes.Append(obj3);
        }

    }

}