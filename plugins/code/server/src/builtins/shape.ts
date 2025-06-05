import { ObjectBuiltin } from './builtin';
import { CompositionObjectBuiltin } from './composition';
import { DocBuilder, msLearn } from './doc';

export const CompositionShapeBuiltin: ObjectBuiltin = {
	typeName: "CompositionShape",
	parent: CompositionObjectBuiltin,
	fields: [
		...CompositionObjectBuiltin.fields,
		{
			fieldName: "centerPoint",
			documentation: new DocBuilder()
				.text("Field").code(".centerPoint").break()
				.text("The point about which the shape is rotated and scaled.").break()
				.text(msLearn("microsoft.ui.composition.compositionshape.centerpoint")).build()
		},
		{
			fieldName: "offset",
			documentation: new DocBuilder()
				.text("Field").code(".offset").break()
				.text("The offset of the shape relative to its ShapeVisual.").break()
				.text(msLearn("microsoft.ui.composition.compositionshape.offset")).build()
		},
		{
			fieldName: "rotationAngle",
			documentation: new DocBuilder()
				.text("Field").code(".rotationAngle").break()
				.text("The rotation angle of the shape in radians.").break()
				.text(msLearn("microsoft.ui.composition.compositionshape.rotationangle")).build()
		},
		{
			fieldName: "rotationAngleInDegrees",
			documentation: new DocBuilder()
				.text("Field").code(".rotationAngleInDegrees").break()
				.text("The rotation angle of the shape in degrees.").break()
				.text(msLearn("microsoft.ui.composition.compositionshape.rotationangleindegrees")).build()
		},
		{
			fieldName: "scale",
			documentation: new DocBuilder()
				.text("Field").code(".scale").break()
				.text("The scale to apply to the shape.").break()
				.text(msLearn("microsoft.ui.composition.compositionshape.scale")).build()
		},
		{
			fieldName: "transformMatrix",
			documentation: new DocBuilder()
				.text("Field").code(".transformMatrix").break()
				.text("The transform matrix to apply to the shape.").break()
				.text(msLearn("microsoft.ui.composition.compositionshape.transformmatrix")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionShape").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents the base shape class.").break()
		.text(msLearn("microsoft.ui.composition.compositionshape")).build()
};

export const ContainerShapeBuiltin: ObjectBuiltin = {
	typeName: "ContainerShape",
	parent: CompositionShapeBuiltin,
	fields: [
		...CompositionShapeBuiltin.fields,
		{
			fieldName: "shapes",
			documentation: new DocBuilder()
				.text("Field").code(".shapes").break()
				.text("The collection of CompositionShapes in this container.").break()
				.text(msLearn("microsoft.ui.composition.compositioncontainershape.shapes")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionContainerShape").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents a container for CompositionShapes, used to group items that share 2D transforms.").break()
		.text(msLearn("microsoft.ui.composition.compositioncontainershape")).build()
};

export const CompositionSpriteShapeBuiltin: ObjectBuiltin = {
	typeName: "SpriteShape",
	parent: CompositionShapeBuiltin,
	fields: [
		...CompositionShapeBuiltin.fields,
		{
			fieldName: "fillBrush",
			documentation: new DocBuilder()
				.text("Field").code(".fillBrush").break()
				.text("The brush that paints the interior area of the shape.").break()
				.text(msLearn("microsoft.ui.composition.compositionspriteshape.fillbrush")).build()
		},
		{
			fieldName: "geometry",
			documentation: new DocBuilder()
				.text("Field").code(".geometry").break()
				.text("The geometry that defines this shape.").break()
				.text(msLearn("microsoft.ui.composition.compositionspriteshape.geometry")).build()
		},
		{
			fieldName: "isStrokeNonScaling",
			documentation: new DocBuilder()
				.text("Field").code(".isStrokeNonScaling").break()
				.text("A value that specifies whether the shape's outline scales.").break()
				.text(msLearn("microsoft.ui.composition.compositionspriteshape.isstrokenonscaling")).build()
		},
		{
			fieldName: "strokeBrush",
			documentation: new DocBuilder()
				.text("Field").code(".strokeBrush").break()
				.text("The brush that paints the outline of the shape.").break()
				.text(msLearn("microsoft.ui.composition.compositionspriteshape.strokebrush")).build()
		},
		{
			fieldName: "strokeDashArray",
			documentation: new DocBuilder()
				.text("Field").code(".strokeDashArray").break()
				.text("The collection of values that indicates the pattern of dashes and gaps used to outline shapes.").break()
				.text(msLearn("microsoft.ui.composition.compositionspriteshape.strokedasharray")).build()
		},
		{
			fieldName: "strokeDashCap",
			documentation: new DocBuilder()
				.text("Field").code(".strokeDashCap").break()
				.text("A CompositionStrokeCap enumeration value that specifies how the ends of a dash are drawn.").break()
				.text(msLearn("microsoft.ui.composition.compositionspriteshape.strokedashcap")).build()
		},
		{
			fieldName: "strokeDashOffset",
			documentation: new DocBuilder()
				.text("Field").code(".strokeDashOffset").break()
				.text("A value that specifies the distance within the dash pattern where a dash begins.").break()
				.text(msLearn("microsoft.ui.composition.compositionspriteshape.strokedashoffset")).build()
		},
		{
			fieldName: "strokeEndCap",
			documentation: new DocBuilder()
				.text("Field").code(".strokeEndCap").break()
				.text("A CompositionStrokeCap enumeration value that specifies how the end of a line is drawn.").break()
				.text(msLearn("microsoft.ui.composition.compositionspriteshape.strokeendcap")).build()
		},
		{
			fieldName: "strokeLineJoin",
			documentation: new DocBuilder()
				.text("Field").code(".strokeLineJoin").break()
				.text("A CompositionStrokeLineJoin enumeration value that specifies the type of join used at the vertices of a shape.").break()
				.text(msLearn("microsoft.ui.composition.compositionspriteshape.strokelinejoin")).build()
		},
		{
			fieldName: "strokeMiterLimit",
			documentation: new DocBuilder()
				.text("Field").code(".strokeMiterLimit").break()
				.text("A limit on the ratio of the miter length to half the StrokeThickness of a shape element.").break()
				.text(msLearn("microsoft.ui.composition.compositionspriteshape.strokemiterlimit")).build()
		},
		{
			fieldName: "strokeStartCap",
			documentation: new DocBuilder()
				.text("Field").code(".strokeStartCap").break()
				.text("A CompositionStrokeCap enumeration value that specifies how the start of a line is drawn.").break()
				.text(msLearn("microsoft.ui.composition.compositionspriteshape.strokestartcap")).build()
		},
		{
			fieldName: "strokeThickness",
			documentation: new DocBuilder()
				.text("Field").code(".strokeThickness").break()
				.text("The width of the shape outline.").break()
				.text(msLearn("microsoft.ui.composition.compositionspriteshape.strokethickness")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionSpriteShape").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("A CompositionShape that draws Stroked and Filled CompositionGeometry.").break()
		.text(msLearn("microsoft.ui.composition.compositionspriteshape")).build()
};

export const ShapeBuiltins : Record<string, ObjectBuiltin> = {
	"ContainerShape": ContainerShapeBuiltin,
	"SpriteShape": CompositionSpriteShapeBuiltin
};