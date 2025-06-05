import { ObjectBuiltin } from './builtin';
import { CompositionObjectBuiltin } from './composition';
import { DocBuilder, msLearn } from './doc';

export const CompositionShadowBuiltin: ObjectBuiltin = {
	typeName: "CompositionShadow",
	parent: CompositionObjectBuiltin,
	fields: [
		...CompositionObjectBuiltin.fields
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionShadow").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Base class for shadows that can be applied to a SpriteVisual.").break()
		.text(msLearn("microsoft.ui.composition.compositionshadow")).build()
};

export const DropShadowBuiltin: ObjectBuiltin = {
	typeName: "DropShadow",
	parent: CompositionShadowBuiltin,
	fields: [
		...CompositionShadowBuiltin.fields,
		{
			fieldName: "blurRadius",
			documentation: new DocBuilder()
				.text("Field").code(".blurRadius").break()
				.text("The radius of the Gaussian blur used to generate the shadow. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.dropshadow.blurradius")).build()
		},
		{
			fieldName: "color",
			documentation: new DocBuilder()
				.text("Field").code(".color").break()
				.text("The color of the shadow. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.dropshadow.color")).build()
		},
		{
			fieldName: "mask",
			documentation: new DocBuilder()
				.text("Field").code(".mask").break()
				.text("Brush used to specify an opacity mask for the shadow. Defaults to the SpriteVisual's brush. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.dropshadow.mask")).build()
		},
		{
			fieldName: "offset",
			documentation: new DocBuilder()
				.text("Field").code(".offset").break()
				.text("Offset of the shadow relative to its SpriteVisual. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.dropshadow.offset")).build()
		},
		{
			fieldName: "opacity",
			documentation: new DocBuilder()
				.text("Field").code(".opacity").break()
				.text("The opacity of the shadow. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.dropshadow.opacity")).build()
		},
		{
			fieldName: "sourcePolicy",
			documentation: new DocBuilder()
				.text("Field").code(".sourcePolicy").break()
				.text("Used to define the shadow masking policy to be used for the shadow.").break()
				.text(msLearn("microsoft.ui.composition.dropshadow.sourcepolicy")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("DropShadow").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("A drop shadow cast by a SpriteVisual or LayerVisual.").break()
		.text(msLearn("microsoft.ui.composition.dropshadow")).build()
};

export const ProjectedShadowBuiltin: ObjectBuiltin = {
	typeName: "ProjectedShadow",
	parent: CompositionShadowBuiltin,
	fields: [
		...CompositionShadowBuiltin.fields,
		{
			fieldName: "blurRadiusMultiplier",
			documentation: new DocBuilder()
				.text("Field").code(".blurRadiusMultiplier").break()
				.text("The multiplier for the shadow's blur radius. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.compositionprojectedshadow.blurradiusmultiplier")).build()
		},
		{
			fieldName: "casters",
			documentation: new DocBuilder()
				.text("Field").code(".casters").break()
				.text("The collection of objects that cast a shadow on the receivers.").break()
				.text(msLearn("microsoft.ui.composition.compositionprojectedshadow.casters")).build()
		},
		{
			fieldName: "lightSource",
			documentation: new DocBuilder()
				.text("Field").code(".lightSource").break()
				.text("The composition light that determines the direction the shadow is cast.").break()
				.text(msLearn("microsoft.ui.composition.compositionprojectedshadow.lightsource")).build()
		},
		{
			fieldName: "maxBlurRadius",
			documentation: new DocBuilder()
				.text("Field").code(".maxBlurRadius").break()
				.text("The maximum blur radius of the shadow. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.compositionprojectedshadow.maxblurradius")).build()
		},
		{
			fieldName: "minBlurRadius",
			documentation: new DocBuilder()
				.text("Field").code(".minBlurRadius").break()
				.text("The minimum blur radius of the shadow. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.compositionprojectedshadow.minblurradius")).build()
		},
		{
			fieldName: "receivers",
			documentation: new DocBuilder()
				.text("Field").code(".receivers").break()
				.text("The collection of objects that the shadow is cast on.").break()
				.text(msLearn("microsoft.ui.composition.compositionprojectedshadow.receivers")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionProjectedShadow").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents a scene-based shadow calculated using the relationship between the light, the visual that casts the shadow, and the visual that receives the shadow, such that the shadow is drawn differently on each receiver.").break()
		.text(msLearn("microsoft.ui.composition.compositionprojectedshadow")).build()
};

export const ShadowBuiltins: Record<string, ObjectBuiltin> = {
	"DropShadow": DropShadowBuiltin,
	"ProjectedShadow": ProjectedShadowBuiltin
};

