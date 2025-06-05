import { ObjectBuiltin } from './builtin';
import { CompositionObjectBuiltin } from './composition';
import { DocBuilder, msLearn } from './doc';

export const CompositionLightBuiltin: ObjectBuiltin = {
	typeName: "CompositionLight",
	parent: CompositionObjectBuiltin,
	fields: [
		...CompositionObjectBuiltin.fields,
		{
			fieldName: "exclusionsFromTargets",
			documentation: new DocBuilder()
				.text("Field").code(".exclusionsFromTargets").break()
				.text("A collection of Visuals that are not targeted by the light.").break()
				.text(msLearn("microsoft.ui.composition.compositionlight.exclusionsfromtargets")).build()
		},
		{
			fieldName: "isEnabled",
			documentation: new DocBuilder()
				.text("Field").code(".isEnabled").break()
				.text("A value that determines whether the composition light is on.").break()
				.text(msLearn("microsoft.ui.composition.compositionlight.isenabled"))
				.build()
		},
		{
			fieldName: "targets",
			documentation: new DocBuilder()
				.text("Field").code(".targets").break()
				.text("The collection of Visuals targeted by the light.").break()
				.text(msLearn("microsoft.ui.composition.compositionlight.targets")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionLight").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Base class for a light source that can target a UI scene.").break()
		.text(msLearn("microsoft.ui.composition.compositionlight")).build(),
};

export const AmbientLightBuiltin: ObjectBuiltin = {
	typeName: "AmbientLight",
	parent: CompositionLightBuiltin,
	fields: [
		...CompositionLightBuiltin.fields,
		{
			fieldName: "color",
			documentation: new DocBuilder()
				.text("Field").code(".color").break()
				.text("Color of the light.").break()
				.text(msLearn("microsoft.ui.composition.ambientlight.color")).build()
		},
		{
			fieldName: "intensity",
			documentation: new DocBuilder()
				.text("Field").code(".intensity").break()
				.text("The intensity of the light.").break()
				.text(msLearn("microsoft.ui.composition.ambientlight.intensity")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("AmbientLight").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("A light that illuminates every targeted Visual equally.").break()
		.text(msLearn("microsoft.ui.composition.ambientlight")).build()
};

export const DistantLightBuiltin: ObjectBuiltin = {
	typeName: "DistantLight",
	parent: CompositionLightBuiltin,
	fields: [
		...CompositionLightBuiltin.fields,
		{
			fieldName: "color",
			documentation: new DocBuilder()
				.text("Field").code(".color").break()
				.text("Color of the emitted DistantLight.").break()
				.text(msLearn("microsoft.ui.composition.distantlight.color")).build()
		},
		{
			fieldName: "coordinateSpace",
			documentation: new DocBuilder()
				.text("Field").code(".coordinateSpace").break()
				.text("The Visual used to determine the light's direction. The light's Direction property is relative to this Visual's coordinate space.").break()
				.text(msLearn("microsoft.ui.composition.distantlight.coordinatespace")).build()
		},
		{
			fieldName: "direction",
			documentation: new DocBuilder()
				.text("Field").code(".direction").break()
				.text("The direction in which the light is pointing, specified relative to its CoordinateSpace Visual.").break()
				.text(msLearn("microsoft.ui.composition.distantlight.direction")).build()
		},
		{
			fieldName: "intensity",
			documentation: new DocBuilder()
				.text("Field").code(".intensity").break()
				.text("The intensity of the light.").break()
				.text(msLearn("microsoft.ui.composition.distantlight.intensity")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("DistantLight").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("An infinitely large distant light source that emits light in a single direction. For example, a distant light could be used to represent sunlight.").break()
		.text(msLearn("microsoft.ui.composition.distantlight")).build()
};

export const PointLightBuiltin: ObjectBuiltin = {
	typeName: "PointLight",
	parent: CompositionLightBuiltin,
	fields: [
		...CompositionLightBuiltin.fields,
		{
			fieldName: "color",
			documentation: new DocBuilder()
				.text("Field").code(".color").break()
				.text("Color of the light.").break()
				.text(msLearn("microsoft.ui.composition.pointlight.color")).build()
		},
		{
			fieldName: "constantAttenuation",
			documentation: new DocBuilder()
				.text("Field").code(".constantAttenuation").break()
				.text("The constant coefficient in the light's attenuation equation. Controls light intensity.").break()
				.text(msLearn("microsoft.ui.composition.pointlight.constantattenuation")).build()
		},
		{
			fieldName: "coordinateSpace",
			documentation: new DocBuilder()
				.text("Field").code(".coordinateSpace").break()
				.text("The Visual used to determine the light's offset. The light's offset property is relative to this Visual's coordinate space. PointLight.CoordinateSpace is a required property. If PointLight.CoordinateSpace is not set, the PointLight will not render.").break()
				.text(msLearn("microsoft.ui.composition.pointlight.coordinatespace")).build()
		},
		{
			fieldName: "intensity",
			documentation: new DocBuilder()
				.text("Field").code(".intensity").break()
				.text("The intensity of the light.").break()
				.text(msLearn("microsoft.ui.composition.pointlight.intensity")).build()
		},
		{
			fieldName: "linearAttenuation",
			documentation: new DocBuilder()
				.text("Field").code(".linearAttenuation").break()
				.text("The linear coefficient in the light's attenuation equation that determines how the light falls-off with distance.").break()
				.text(msLearn("microsoft.ui.composition.pointlight.linearattenuation")).build()
		},
		{
			fieldName: "maxAttenuationCutoff",
			documentation: new DocBuilder()
				.text("Field").code(".maxAttenuationCutoff").break()
				.text("The maximum range at which this light is effective.").break()
				.text(msLearn("microsoft.ui.composition.pointlight.maxattenuationcutoff")).build()
		},
		{
			fieldName: "minAttenuationCutoff",
			documentation: new DocBuilder()
				.text("Field").code(".minAttenuationCutoff").break()
				.text("The minimum range at which this light is effective.").break()
				.text(msLearn("microsoft.ui.composition.pointlight.minattenuationcutoff")).build()
		},
		{
			fieldName: "offset",
			documentation: new DocBuilder()
				.text("Field").code(".offset").break()
				.text("Offset of the light source relative to its coordinate space Visual.").break()
				.text(msLearn("microsoft.ui.composition.pointlight.offset")).build()
		},
		{
			fieldName: "quadraticAttenuation",
			documentation: new DocBuilder()
				.text("Field").code(".quadraticAttenuation").break()
				.text("The quadratic portion of the attenuation equation that determines how the light falls off with distance.").break()
				.text(msLearn("microsoft.ui.composition.pointlight.quadraticattenuation")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("PointLight").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("A point source of light that emanates light in all directions. For example, a point light could be used to represent a light bulb.").break()
		.text(msLearn("microsoft.ui.composition.pointlight")).build()
};

export const SpotLightBuiltin: ObjectBuiltin = {
	typeName: "SpotLight",
	parent: CompositionLightBuiltin,
	fields: [
		...CompositionLightBuiltin.fields,
		{
			fieldName: "constantAttenuation",
			documentation: new DocBuilder()
				.text("Field").code(".constantAttenuation").break()
				.text("The constant coefficient in the light's attenuation equation. Controls light intensity. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.spotlight.constantattenuation")).build()
		},
		{
			fieldName: "coordinateSpace",
			documentation: new DocBuilder()
				.text("Field").code(".coordinateSpace").break()
				.text("The Visual used to determine the light's direction and offset. The light's offset and direction properties are relative to this Visual's coordinate space. SpotLight.CoordinateSpace is a required property. If SpotLight.CoordinateSpace is not set, the SpotLight will not render.").break()
				.text(msLearn("microsoft.ui.composition.spotlight.coordinatespace")).build()
		},
		{
			fieldName: "direction",
			documentation: new DocBuilder()
				.text("Field").code(".direction").break()
				.text("The direction in which the light is pointing, specified relative to its CoordinateSpace Visual.").break()
				.text(msLearn("microsoft.ui.composition.spotlight.direction")).build()
		},
		{
			fieldName: "innerConeAngle",
			documentation: new DocBuilder()
				.text("Field").code(".innerConeAngle").break()
				.text("The SpotLight's inner cone angle, expressed as a semi-vertical angle in radians. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.spotlight.innerconeangle")).build()
		},
		{
			fieldName: "innerConeAngleInDegrees",
			documentation: new DocBuilder()
				.text("Field").code(".innerConeAngleInDegrees").break()
				.text("The SpotLight's inner cone angle, expressed as a semi-vertical angle in degrees. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.spotlight.innerconeangleindegrees")).build()
		},
		{
			fieldName: "innerConeColor",
			documentation: new DocBuilder()
				.text("Field").code(".innerConeColor").break()
				.text("Color of the spotlight's inner cone. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.spotlight.innerconecolor")).build()
		},
		{
			fieldName: "innerConeIntensity",
			documentation: new DocBuilder()
				.text("Field").code(".innerConeIntensity").break()
				.text("The intensity of the light in the spotlight's inner cone.").break()
				.text(msLearn("microsoft.ui.composition.spotlight.innerconeintensity")).build()
		},
		{
			fieldName: "linearAttenuation",
			documentation: new DocBuilder()
				.text("Field").code(".linearAttenuation").break()
				.text("The linear coefficient in the light's attenuation equation that determines how the light falls off with distance. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.spotlight.linearattenuation")).build()
		},
		{
			fieldName: "maxAttenuationCutoff",
			documentation: new DocBuilder()
				.text("Field").code(".maxAttenuationCutoff").break()
				.text("The maximum range at which this light is effective.").break()
				.text(msLearn("microsoft.ui.composition.spotlight.maxattenuationcutoff")).build()
		},
		{
			fieldName: "minAttenuationCutoff",
			documentation: new DocBuilder()
				.text("Field").code(".minAttenuationCutoff").break()
				.text("The minimum range at which this light is effective.").break()
				.text(msLearn("microsoft.ui.composition.spotlight.minattenuationcutoff")).build()
		},
		{
			fieldName: "offset",
			documentation: new DocBuilder()
				.text("Field").code(".offset").break()
				.text("Offset of the light source relative to its CoordinateSpace Visual. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.spotlight.offset")).build()
		},
		{
			fieldName: "outerConeAngle",
			documentation: new DocBuilder()
				.text("Field").code(".outerConeAngle").break()
				.text("The SpotLight's outer cone angle, expressed as a semi-vertical angle in radians. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.spotlight.outerconeangle")).build()
		},
		{
			fieldName: "outerConeAngleInDegrees",
			documentation: new DocBuilder()
				.text("Field").code(".outerConeAngleInDegrees").break()
				.text("The semi-vertical angle, in degrees, of the SpotLight's outer cone. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.spotlight.outerconeangleindegrees")).build()
		},
		{
			fieldName: "outerConeColor",
			documentation: new DocBuilder()
				.text("Field").code(".outerConeColor").break()
				.text("The color of the spotlight's outer cone. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.spotlight.outerconecolor")).build()
		},
		{
			fieldName: "outerConeIntensity",
			documentation: new DocBuilder()
				.text("Field").code(".outerConeIntensity").break()
				.text("The intensity of the light in the spotlight's outer cone.").break()
				.text(msLearn("microsoft.ui.composition.spotlight.outerconeintensity")).build()
		},
		{
			fieldName: "quadraticAttenuation",
			documentation: new DocBuilder()
				.text("Field").code(".quadraticAttenuation").break()
				.text("The quadratic portion of the attenuation equation that determines how the light falls off with distance. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.spotlight.quadraticattenuation")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("SpotLight").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("A light source that casts inner and outer cones of light. For example, a flashlight.").break()
		.text(msLearn("microsoft.ui.composition.spotlight")).build()
};

export const LightBuiltins: Record<string, ObjectBuiltin> = {
	"AmbientLight": AmbientLightBuiltin,
	"DistantLight": DistantLightBuiltin,
	"PointLight": PointLightBuiltin,
	"SpotLight": SpotLightBuiltin
};