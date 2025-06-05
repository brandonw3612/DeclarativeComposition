import { ObjectBuiltin } from './builtin';
import { CompositionObjectBuiltin } from './composition';
import { DocBuilder, msLearn } from './doc';

export const CompositionClipBuiltin: ObjectBuiltin = {
	typeName: "CompositionClip",
	parent: CompositionObjectBuiltin,
	fields: [
		...CompositionObjectBuiltin.fields,
		{
			fieldName: "anchorPoint",
			documentation: new DocBuilder()
				.text("Field").code(".anchorPoint").break()
				.text("The point on the clip to be positioned at the clip's offset. Value is normalized with respect to the size of the visual.").break()
				.text(msLearn("microsoft.ui.composition.compositionclip.anchorpoint")).build()
		},
		{
			fieldName: "centerPoint",
			documentation: new DocBuilder()
				.text("Field").code(".centerPoint").break()
				.text("The point about which rotation or scaling occurs.").break()
				.text(msLearn("microsoft.ui.composition.compositionclip.centerpoint")).build()
		},
		{
			fieldName: "offset",
			documentation: new DocBuilder()
				.text("Field").code(".offset").break()
				.text("The offset of the clip relative to the visual on which the clip is applied.").break()
				.text(msLearn("microsoft.ui.composition.compositionclip.offset")).build()
		},
		{
			fieldName: "rotationAngle",
			documentation: new DocBuilder()
				.text("Field").code(".rotationAngle").break()
				.text("The angle of rotation applied to the clip, in radians.").break()
				.text(msLearn("microsoft.ui.composition.compositionclip.rotationangle")).build()
		},
		{
			fieldName: "rotationAngleInDegrees",
			documentation: new DocBuilder()
				.text("Field").code(".rotationAngleInDegrees").break()
				.text("The angle of rotation applied to the clip, in degrees.").break()
				.text(msLearn("microsoft.ui.composition.compositionclip.rotationangleindegrees")).build()
		},
		{
			fieldName: "scale",
			documentation: new DocBuilder()
				.text("Field").code(".scale").break()
				.text("The scale to apply to the clip.").break()
				.text(msLearn("microsoft.ui.composition.compositionclip.scale")).build()
		},
		{
			fieldName: "transformMatrix",
			documentation: new DocBuilder()
				.text("Field").code(".transformMatrix").break()
				.text("The 3x2 transformation matrix to apply to the clip.").break()
				.text(msLearn("microsoft.ui.composition.compositionclip.transformmatrix")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionClip").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Base class for clipping objects such as InsetClip.").break()
		.text(msLearn("microsoft.ui.composition.compositionclip")).build()
};

export const GeometricClipBuiltin: ObjectBuiltin = {
	typeName: "GeometricClip",
	parent: CompositionClipBuiltin,
	fields: [
		...CompositionClipBuiltin.fields,
		{
			fieldName: "geometry",
			documentation: new DocBuilder()
				.text("Field").code(".geometry").break()
				.text("CompositionGeometry that defines the shape of the clip.").break()
				.text(msLearn("microsoft.ui.composition.compositiongeometricclip.geometry")).build()
		},
		{
			fieldName: "viewBox",
			documentation: new DocBuilder()
				.text("Field").code(".viewBox").break()
				.text("A CompositionViewBox that maps the shape visual tree coordinates onto the visual.").break()
				.text(msLearn("microsoft.ui.composition.compositiongeometricclip.viewbox")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("GeometricClip").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents a shape that clips a portion of a visual. The visible portion of the visual is a shape defined by a CompositionGeometry. The portion of the visual outside the geometry is clipped.").break()
		.text(msLearn("microsoft.ui.composition.compositiongeometricclip")).build()
};

export const InsetClipBuiltin: ObjectBuiltin = {
	typeName: "InsetClip",
	parent: CompositionClipBuiltin,
	fields: [
		...CompositionClipBuiltin.fields,
		{
			fieldName: "bottomInset",
			documentation: new DocBuilder()
				.text("Field").code(".bottomInset").break()
				.text("The offset from the bottom of the visual. The portion of the visual below the BottomInset will be clipped. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.insetclip.bottominset")).build()
		},
		{
			fieldName: "leftInset",
			documentation: new DocBuilder()
				.text("Field").code(".leftInset").break()
				.text("The offset from the left of the visual. The portion of the visual to the left of the LeftInset will be clipped. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.insetclip.leftinset")).build()
		},
		{
			fieldName: "rightInset",
			documentation: new DocBuilder()
				.text("Field").code(".rightInset").break()
				.text("The offset from the right of the visual. The portion of the visual to the right of the RightInset will be clipped. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.insetclip.rightinset")).build()
		},
		{
			fieldName: "topInset",
			documentation: new DocBuilder()
				.text("Field").code(".topInset").break()
				.text("The offset from the top of the visual. The portion of the visual above the TopInset will be clipped. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.insetclip.topinset")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("InsetClip").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents a rectangle that clips a portion of a visual. The portion of the visual inside the rectangle is visible; the portion of the visual outside the rectangle is clipped.").break()
		.text(msLearn("microsoft.ui.composition.insetclip")).build()
};

export const RectangleClipBuiltin: ObjectBuiltin = {
	typeName: "RectangleClip",
	parent: CompositionClipBuiltin,
	fields: [
		...CompositionClipBuiltin.fields,
		{
			fieldName: "bottom",
			documentation: new DocBuilder()
				.text("Field").code(".bottom").break()
				.text("The offset from the bottom of the visual. The portion of the visual below the edge defined by Bottom will be clipped. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.rectangleclip.bottom")).build()
		},
		{
			fieldName: "bottomLeftRadius",
			documentation: new DocBuilder()
				.text("Field").code(".bottomLeftRadius").break()
				.text("The amount by which the bottom left corner of the rectangle is rounded.").break()
				.text(msLearn("microsoft.ui.composition.rectangleclip.bottomleftradius")).build()
		},
		{
			fieldName: "bottomRightRadius",
			documentation: new DocBuilder()
				.text("Field").code(".bottomRightRadius").break()
				.text("The amount by which the bottom right corner of the rectangle is rounded.").break()
				.text(msLearn("microsoft.ui.composition.rectangleclip.bottomrightradius")).build()
		},
		{
			fieldName: "left",
			documentation: new DocBuilder()
				.text("Field").code(".left").break()
				.text("The offset from the left of the visual. The portion of the visual to the left of the edge defined by Left will be clipped. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.rectangleclip.left")).build()
		},
		{
			fieldName: "right",
			documentation: new DocBuilder()
				.text("Field").code(".right").break()
				.text("The amount from the right of the visual. The portion of the visual to the right the edge defined by Right will be clipped. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.rectangleclip.right")).build()
		},
		{
			fieldName: "top",
			documentation: new DocBuilder()
				.text("Field").code(".top").break()
				.text("The offset from the top of the visual. The portion of the visual above the edge defined by Top will be clipped. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.rectangleclip.top")).build()
		},
		{
			fieldName: "topLeftRadius",
			documentation: new DocBuilder()
				.text("Field").code(".topLeftRadius").break()
				.text("The amount by which the top left corner of the rectangle is rounded.").break()
				.text(msLearn("microsoft.ui.composition.rectangleclip.topleftradius")).build()
		},
		{
			fieldName: "topRightRadius",
			documentation: new DocBuilder()
				.text("Field").code(".topRightRadius").break()
				.text("The amount by which the top right corner of the rectangle is rounded.").break()
				.text(msLearn("microsoft.ui.composition.rectangleclip.toprightradius")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("RectangleClip").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents a rectangle with optional rounded corners that clips a portion of a visual. The portion of the visual inside the rectangle is visible; the portion of the visual outside the rectangle is clipped.").break()
		.text(msLearn("microsoft.ui.composition.rectangleclip")).build()
};

export const ClipBuiltins : Record<string, ObjectBuiltin> = {
	"GeometricClip": GeometricClipBuiltin,
	"InsetClip": InsetClipBuiltin,
	"RectangleClip": RectangleClipBuiltin
};