import { ObjectBuiltin } from './builtin';
import { CompositionObjectBuiltin } from './composition';
import { DocBuilder, msLearn } from './doc';

export const ColorGradientStopBuiltin: ObjectBuiltin = {
	typeName: "ColorGradientStop",
	parent: CompositionObjectBuiltin,
	fields: [
		...CompositionObjectBuiltin.fields,
		{
			fieldName: "color",
			documentation: new DocBuilder()
				.text("Field").code(".color").break()
				.text("The color of the gradient stop.").break()
				.text(msLearn("microsoft.ui.composition.compositioncolorgradientstop.color")).build()
		},
		{
			fieldName: "offset",
			documentation: new DocBuilder()
				.text("Field").code(".offset").break()
				.text("The location of the gradient stop within the gradient vector.").break()
				.text(msLearn("microsoft.ui.composition.compositioncolorgradientstop.offset")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionColorGradientStop").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Describes the location and color of a transition point in a gradient.").break()
		.text(msLearn("microsoft.ui.composition.compositioncolorgradientstop")).build()
};

export const ProjectedShadowCasterBuiltin: ObjectBuiltin = {
	typeName: "ProjectedShadowCaster",
	parent: CompositionObjectBuiltin,
	fields: [
		...CompositionObjectBuiltin.fields,
		{
			fieldName: "brush",
			documentation: new DocBuilder()
				.text("Field").code(".brush").break()
				.text("The brush used to draw the shadow.").break()
				.text(msLearn("microsoft.ui.composition.compositionprojectedshadowcaster.brush")).build()
		},
		{
			fieldName: "castingVisual",
			documentation: new DocBuilder()
				.text("Field").code(".castingVisual").break()
				.text("The visual that casts the shadow.").break()
				.text(msLearn("microsoft.ui.composition.compositionprojectedshadowcaster.castingvisual")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionProjectedShadowCaster").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents an object that casts a projected shadow.").break()
		.text(msLearn("microsoft.ui.composition.compositionprojectedshadowcaster")).build()
};

export const ProjectedShadowReceiverBuiltin: ObjectBuiltin = {
	typeName: "ProjectedShadowReceiver",
	parent: CompositionObjectBuiltin,
	fields: [
		...CompositionObjectBuiltin.fields,
		{
			fieldName: "receivingVisual",
			documentation: new DocBuilder()
				.text("Field").code(".receivingVisual").break()
				.text("The Visual that the shadow is cast on.").break()
				.text(msLearn("microsoft.ui.composition.compositionprojectedshadowreceiver.receivingvisual")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionProjectedShadowReceiver").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents an object that can have a projected shadow cast on it.").break()
		.text(msLearn("microsoft.ui.composition.compositionprojectedshadowreceiver")).build()
};

export const ViewBoxBuiltin: ObjectBuiltin = {
	typeName: "ViewBox",
	parent: CompositionObjectBuiltin,
	fields: [
		...CompositionObjectBuiltin.fields,
		{
			fieldName: "horizontalAlignmentRatio",
			documentation: new DocBuilder()
				.text("Field").code(".horizontalAlignmentRatio").break()
				.text("The horizontal alignment ratio of the view box.").break()
				.text(msLearn("microsoft.ui.composition.compositionviewbox.horizontalalignmentratio")).build()
		},
		{
			fieldName: "offset",
			documentation: new DocBuilder()
				.text("Field").code(".offset").break()
				.text("The offset of the view box.").break()
				.text(msLearn("microsoft.ui.composition.compositionviewbox.offset")).build()
		},
		{
			fieldName: "size",
			documentation: new DocBuilder()
				.text("Field").code(".size").break()
				.text("The height and width of the view box.").break()
				.text(msLearn("microsoft.ui.composition.compositionviewbox.size")).build()
		},
		{
			fieldName: "stretch",
			documentation: new DocBuilder()
				.text("Field").code(".stretch").break()
				.text("A value that specifies how content fits into the available space.").break()
				.text(msLearn("microsoft.ui.composition.compositionviewbox.stretch")).build()
		},
		{
			fieldName: "verticalAlignmentRatio",
			documentation: new DocBuilder()
				.text("Field").code(".verticalAlignmentRatio").break()
				.text("The vertical alignment ratio of the view box.").break()
				.text(msLearn("microsoft.ui.composition.compositionviewbox.verticalalignmentratio")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionViewBox").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents a container that maps shape visual tree coordinates onto the visual.").break()
		.text(msLearn("microsoft.ui.composition.compositionviewbox")).build()
};

export const VisualSurfaceBuiltin: ObjectBuiltin = {
	typeName: "VisualSurface",
	parent: CompositionObjectBuiltin,
	fields: [
		...CompositionObjectBuiltin.fields,
		{
			fieldName: "sourceOffset",
			documentation: new DocBuilder()
				.text("Field").code(".sourceOffset").break()
				.text("The coordinates of the top-left corner of the part of the visual surface used for rendering.").break()
				.text(msLearn("microsoft.ui.composition.compositionvisualsurface.sourceoffset")).build()
		},
		{
			fieldName: "sourceSize",
			documentation: new DocBuilder()
				.text("Field").code(".sourceSize").break()
				.text("The height and width of the part of the visual surface used for rendering.").break()
				.text(msLearn("microsoft.ui.composition.compositionvisualsurface.sourcesize")).build()
		},
		{
			fieldName: "sourceVisual",
			documentation: new DocBuilder()
				.text("Field").code(".sourceVisual").break()
				.text("The root of the visual tree that is the target of the visual surface.").break()
				.text(msLearn("microsoft.ui.composition.compositionvisualsurface.sourcevisual")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionVisualSurface").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents a visual tree as an ICompositionSurface that can be used to paint a Visual using a CompositionBrush.").break()
		.text(msLearn("microsoft.ui.composition.compositionvisualsurface")).build()
};

export const MiscBuiltins: Record<string, ObjectBuiltin> = {
	"ColorGradientStop": ColorGradientStopBuiltin,
	"ProjectedShadowCaster": ProjectedShadowCasterBuiltin,
	"ProjectedShadowReceiver": ProjectedShadowReceiverBuiltin,
	"ViewBox": ViewBoxBuiltin,
	"VisualSurface": VisualSurfaceBuiltin
};