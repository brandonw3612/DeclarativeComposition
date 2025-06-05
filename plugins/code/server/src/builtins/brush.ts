import { ObjectBuiltin } from './builtin';
import { CompositionObjectBuiltin } from './composition';
import { DocBuilder, msLearn } from './doc';

export const CompositionBrushBuiltin: ObjectBuiltin = {
	typeName: "CompositionBrush",
	parent: CompositionObjectBuiltin,
	fields: [
		...CompositionObjectBuiltin.fields,
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionBrush").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Base class for brushes used to paint a SpriteVisual.").break()
		.text(msLearn("microsoft.ui.composition.compositionbrush")).build()
};

export const BackdropBrushBuiltin: ObjectBuiltin = {
	typeName: "BackdropBrush",
	parent: CompositionBrushBuiltin,
	fields: [
		...CompositionBrushBuiltin.fields,
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionBackdropBrush").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("A brush that applies an effect (or a chain of effects) to the region behind a SpriteVisual.").break()
		.text(msLearn("microsoft.ui.composition.compositionbackdropbrush")).build()
};

export const ColorBrushBuiltin: ObjectBuiltin = {
	typeName: "ColorBrush",
	parent: CompositionBrushBuiltin,
	fields: [
		...CompositionBrushBuiltin.fields,
		{
			fieldName: "color",
			documentation: new DocBuilder()
				.text("Field").code(".color").break()
				.text("The color used to fill a SpriteVisual. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.compositioncolorbrush.color")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionColorBrush").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("A brush that paints a SpriteVisual with a solid color.").break()
		.text(msLearn("microsoft.ui.composition.compositioncolorbrush")).build()
};

export const EffectBrushBuiltin: ObjectBuiltin = {
	typeName: "EffectBrush",
	parent: CompositionBrushBuiltin,
	fields: [
		...CompositionBrushBuiltin.fields,
		// TODO: Implement the EffectBrush definition
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionEffectBrush").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("A brush that paints a SpriteVisual with the output of a filter effect. The filter effect description is defined using the CompositionEffectFactory class.").break()
		.text(msLearn("microsoft.ui.composition.compositioneffectbrush")).build()
};

export const GradientBrushBuiltin: ObjectBuiltin = {
	typeName: "GradientBrush",
	parent: CompositionBrushBuiltin,
	fields: [
		...CompositionBrushBuiltin.fields,
		{
			fieldName: "anchorPoint",
			documentation: new DocBuilder()
				.text("Field").code(".anchorPoint").break()
				.text("The point on the brush to be positioned at the brush's offset.").break()
				.text(msLearn("microsoft.ui.composition.compositiongradientbrush.anchorpoint")).build()
		},
		{
			fieldName: "centerPoint",
			documentation: new DocBuilder()
				.text("Field").code(".centerPoint").break()
				.text("The point about which the brush is rotated and scaled.").break()
				.text(msLearn("microsoft.ui.composition.compositiongradientbrush.centerpoint")).build()
		},
		{
			fieldName: "colorStops",
			documentation: new DocBuilder()
				.text("Field").code(".colorStops").break()
				.text("The brush's gradient stops.").break()
				.text(msLearn("microsoft.ui.composition.compositiongradientbrush.colorstops")).build()
		},
		{
			fieldName: "extendMode",
			documentation: new DocBuilder()
				.text("Field").code(".extendMode").break()
				.text("A value that specifies how to draw the gradient outside the brush's gradient vector or space.").break()
				.text(msLearn("microsoft.ui.composition.compositiongradientbrush.extendmode")).build()
		},
		{
			fieldName: "interpolationSpace",
			documentation: new DocBuilder()
				.text("Field").code(".interpolationSpace").break()
				.text("A value that specifies how the gradient's colors are interpolated.").break()
				.text(msLearn("microsoft.ui.composition.compositiongradientbrush.interpolationspace")).build()
		},
		{
			fieldName: "mappingMode",
			documentation: new DocBuilder()
				.text("Field").code(".mappingMode").break()
				.text("A value that indicates whether the gradient brush's positioning coordinates (StartPoint, EndPoint) are absolute or relative to the output area.").break()
				.text(msLearn("microsoft.ui.composition.compositiongradientbrush.mappingmode")).build()
		},
		{
			fieldName: "offset",
			documentation: new DocBuilder()
				.text("Field").code(".offset").break()
				.text("The offset of the brush relative to the object being painted.").break()
				.text(msLearn("microsoft.ui.composition.compositiongradientbrush.offset")).build()
		},
		{
			fieldName: "rotationAngle",
			documentation: new DocBuilder()
				.text("Field").code(".rotationAngle").break()
				.text("The rotation angle of the brush in radians.").break()
				.text(msLearn("microsoft.ui.composition.compositiongradientbrush.rotationangle")).build()
		},
		{
			fieldName: "rotationAngleInDegrees",
			documentation: new DocBuilder()
				.text("Field").code(".rotationAngleInDegrees").break()
				.text("The rotation angle of the brush in degrees.").break()
				.text(msLearn("microsoft.ui.composition.compositiongradientbrush.rotationangleindegrees")).build()
		},
		{
			fieldName: "scale",
			documentation: new DocBuilder()
				.text("Field").code(".scale").break()
				.text("The scale to apply to the brush.").break()
				.text(msLearn("microsoft.ui.composition.compositiongradientbrush.scale")).build()
		},
		{
			fieldName: "transformMatrix",
			documentation: new DocBuilder()
				.text("Field").code(".transformMatrix").break()
				.text("The matrix of transforms to apply to the brush.").break()
				.text(msLearn("microsoft.ui.composition.compositiongradientbrush.transformmatrix")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionGradientBrush").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Base class for brushes that describe a gradient, composed of gradient stops.").break()
		.text(msLearn("microsoft.ui.composition.compositiongradientbrush")).build()
};

export const LinearGradientBrushBuiltin: ObjectBuiltin = {
	typeName: "LinearGradientBrush",
	parent: GradientBrushBuiltin,
	fields: [
		...GradientBrushBuiltin.fields,
		{
			fieldName: "endPoint",
			documentation: new DocBuilder()
				.text("Field").code(".endPoint").break()
				.text("The ending two-dimensional coordinates of the linear gradient.").break()
				.text(msLearn("microsoft.ui.composition.compositionlineargraidentbrush.endpoint")).build()
		},
		{
			fieldName: "startPoint",
			documentation: new DocBuilder()
				.text("Field").code(".startPoint").break()
				.text("The starting two-dimensional coordinates of the linear gradient.").break()
				.text(msLearn("microsoft.ui.composition.compositionlineargraidentbrush.startpoint")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionLinearGradientBrush").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents a brush that paints an area with a linear gradient.").break()
		.text(msLearn("microsoft.ui.composition.compositionlineargraidentbrush")).build()
};

export const RadialGradientBrushBuiltin: ObjectBuiltin = {
	typeName: "RadialGradientBrush",
	parent: GradientBrushBuiltin,
	fields: [
		...GradientBrushBuiltin.fields,
		{
			fieldName: "ellipseCenter",
			documentation: new DocBuilder()
				.text("Field").code(".ellipseCenter").break()
				.text("The two-dimensional coordinates of the center of the ellipse that contains the gradient.").break()
				.text(msLearn("microsoft.ui.composition.compositionradialgradientbrush.ellipsecenter")).build()
		},
		{
			fieldName: "ellipseRadius",
			documentation: new DocBuilder()
				.text("Field").code(".ellipseRadius").break()
				.text("The radii of the ellipse that contains the gradient.").break()
				.text(msLearn("microsoft.ui.composition.compositionradialgradientbrush.ellipseradius")).build()
		},
		{
			fieldName: "gradientOriginOffset",
			documentation: new DocBuilder()
				.text("Field").code(".gradientOriginOffset").break()
				.text("The two-dimensional coordinates of the origin of the gradient.").break()
				.text(msLearn("microsoft.ui.composition.compositionradialgradientbrush.gradientoriginoffset")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionRadialGradientBrush").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents a brush that paints an area with a radial gradient.").break()
		.text(msLearn("microsoft.ui.composition.compositionradialgradientbrush")).build()
};

export const MaskBrushBuiltin: ObjectBuiltin = {
	typeName: "MaskBrush",
	parent: CompositionBrushBuiltin,
	fields: [
		...CompositionBrushBuiltin.fields,
		{
			fieldName: "mask",
			documentation: new DocBuilder()
				.text("Field").code(".mask").break()
				.text("A brush that contains the opacity mask with which the Source brush's content is to be masked. Can be of type CompositionSurfaceBrush or CompositionNineGridBrush.").break()
				.text(msLearn("microsoft.ui.composition.compositionmaskbrush.mask")).build()
		},
		{
			fieldName: "source",
			documentation: new DocBuilder()
				.text("Field").code(".source").break()
				.text("A brush whose content is to be masked by the opacity mask. Can be of type CompositionSurfaceBrush, CompositionColorBrush, or CompositionNineGridBrush.").break()
				.text(msLearn("microsoft.ui.composition.compositionmaskbrush.source")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionMaskBrush").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Paints a SpriteVisual with a CompositionBrush with an opacity mask applied to it. The source of the opacity mask can be any CompositionBrush of type CompositionColorBrush, CompositionLinearGradientBrush, CompositionSurfaceBrush, CompositionEffectBrush or a CompositionNineGridBrush. The opacity mask must be specified as a CompositionSurfaceBrush.").break()
		.text(msLearn("microsoft.ui.composition.compositionmaskbrush")).build()
};

export const NineGridBrushBuiltin: ObjectBuiltin = {
	typeName: "NineGridBrush",
	parent: CompositionBrushBuiltin,
	fields: [
		...CompositionBrushBuiltin.fields,
		{
			fieldName: "bottomInset",
			documentation: new DocBuilder()
				.text("Field").code(".bottomInset").break()
				.text("Inset from the bottom edge of the source content that specifies the thickness of the bottom row. Defaults to 0.0f.").break()
				.text(msLearn("microsoft.ui.composition.compositionninegridbrush.bottominset")).build()
		},
		{
			fieldName: "bottomInsetScale",
			documentation: new DocBuilder()
				.text("Field").code(".bottomInsetScale").break()
				.text("Scale to be applied to BottomInset. Defaults to 1.0f.").break()
				.text(msLearn("microsoft.ui.composition.compositionninegridbrush.bottominsetscale")).build()
		},
		{
			fieldName: "isCenterHollow",
			documentation: new DocBuilder()
				.text("Field").code(".isCenterHollow").break()
				.text("Indicates whether the center of the Nine-Grid is drawn.").break()
				.text(msLearn("microsoft.ui.composition.compositionninegridbrush.iscenterhollow")).build()
		},
		{
			fieldName: "leftInset",
			documentation: new DocBuilder()
				.text("Field").code(".leftInset").break()
				.text("Inset from the left edge of the source content that specifies the thickness of the left column. Defaults to 0.0f.").break()
				.text(msLearn("microsoft.ui.composition.compositionninegridbrush.leftinset")).build()
		},
		{
			fieldName: "leftInsetScale",
			documentation: new DocBuilder()
				.text("Field").code(".leftInsetScale").break()
				.text("Scale to be applied to LeftInset. Defaults to 1.0f.").break()
				.text(msLearn("microsoft.ui.composition.compositionninegridbrush.leftinsetscale")).build()
		},
		{
			fieldName: "rightInset",
			documentation: new DocBuilder()
				.text("Field").code(".rightInset").break()
				.text("Inset from the right edge of the source content that specifies the thickness of the right column. Defaults to 0.0f.").break()
				.text(msLearn("microsoft.ui.composition.compositionninegridbrush.rightinset")).build()
		},
		{
			fieldName: "rightInsetScale",
			documentation: new DocBuilder()
				.text("Field").code(".rightInsetScale").break()
				.text("Scale to be applied to RightInset. Defaults to 1.0f.").break()
				.text(msLearn("microsoft.ui.composition.compositionninegridbrush.rightinsetscale")).build()
		},
		{
			fieldName: "source",
			documentation: new DocBuilder()
				.text("Field").code(".source").break()
				.text("The brush whose content is to be Nine-Grid stretched. Can be of type CompositionSurfaceBrush or CompositionColorBrush.").break()
				.text(msLearn("microsoft.ui.composition.compositionninegridbrush.source")).build()
		},
		{
			fieldName: "topInset",
			documentation: new DocBuilder()
				.text("Field").code(".topInset").break()
				.text("Inset from the top edge of the source content that specifies the thickness of the top row. Defaults to 0.0f.").break()
				.text(msLearn("microsoft.ui.composition.compositionninegridbrush.topinset")).build()
		},
		{
			fieldName: "topInsetScale",
			documentation: new DocBuilder()
				.text("Field").code(".topInsetScale").break()
				.text("Scale to be applied to TopInset. Defaults to 1.0f.").break()
				.text(msLearn("microsoft.ui.composition.compositionninegridbrush.topinsetscale")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionNineGridBrush").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Paints a SpriteVisual with a CompositionBrush after applying Nine-Grid Stretching to the contents of the Source brush. The source of the nine-grid stretch can be any CompositionBrush of type CompositionColorBrush, CompositionSurfaceBrush or a CompositionEffectBrush.").break()
		.text(msLearn("microsoft.ui.composition.compositionninegridbrush")).build()
};

export const SurfaceBrushBuiltin: ObjectBuiltin = {
	typeName: "SurfaceBrush",
	parent: CompositionBrushBuiltin,
	fields: [
		...CompositionBrushBuiltin.fields,
		{
			fieldName: "anchorPoint",
			documentation: new DocBuilder()
				.text("Field").code(".anchorPoint").break()
				.text("The point on the brush to be positioned at the brush's offset. Value is normalized with respect to the size of the SpriteVisual.").break()
				.text(msLearn("microsoft.ui.composition.compositionsurfacebrush.anchorpoint")).build()
		},
		{
			fieldName: "bitmapInterpolationMode",
			documentation: new DocBuilder()
				.text("Field").code(".bitmapInterpolationMode").break()
				.text("Specifies the algorithm used for interpolating pixels from ICompositionSurface when they do not form a one-to-one mapping to pixels on SpriteVisual.").break()
				.text(msLearn("microsoft.ui.composition.compositionsurfacebrush.bitmapinterpolationmode")).build()
		},
		{
			fieldName: "centerPoint",
			documentation: new DocBuilder()
				.text("Field").code(".centerPoint").break()
				.text("The point about which the brush is rotated and scaled.").break()
				.text(msLearn("microsoft.ui.composition.compositionsurfacebrush.centerpoint")).build()
		},
		{
			fieldName: "horizontalAlignmentRatio",
			documentation: new DocBuilder()
				.text("Field").code(".horizontalAlignmentRatio").break()
				.text("Controls the positioning of the vertical axis of content with respect to the vertical axis of the SpriteVisual. Value is clamped from 0.0f to 1.0f.").break()
				.text(msLearn("microsoft.ui.composition.compositionsurfacebrush.horizontalalignmentratio")).build()
		},
		{
			fieldName: "offset",
			documentation: new DocBuilder()
				.text("Field").code(".offset").break()
				.text("The offset of the brush relative to its SpriteVisual.").break()
				.text(msLearn("microsoft.ui.composition.compositionsurfacebrush.offset")).build()
		},
		{
			fieldName: "rotationAngle",
			documentation: new DocBuilder()
				.text("Field").code(".rotationAngle").break()
				.text("The rotation angle, in radians, of the brush.").break()
				.text(msLearn("microsoft.ui.composition.compositionsurfacebrush.rotationangle")).build()
		},
		{
			fieldName: "rotationAngleInDegrees",
			documentation: new DocBuilder()
				.text("Field").code(".rotationAngleInDegrees").break()
				.text("The rotation angle, in degrees, of the brush.").break()
				.text(msLearn("microsoft.ui.composition.compositionsurfacebrush.rotationangleindegrees")).build()
		},
		{
			fieldName: "scale",
			documentation: new DocBuilder()
				.text("Field").code(".scale").break()
				.text("The scale to apply to the brush.").break()
				.text(msLearn("microsoft.ui.composition.compositionsurfacebrush.scale")).build()
		},
		{
			fieldName: "snapToPixels",
			documentation: new DocBuilder()
				.text("Field").code(".snapToPixels").break()
				.text("Gets or sets a value that indicates whether the surface brush aligns with pixels.").break()
				.text(msLearn("microsoft.ui.composition.compositionsurfacebrush.snaptopixels")).build()
		},
		{
			fieldName: "stretch",
			documentation: new DocBuilder()
				.text("Field").code(".stretch").break()
				.text("Controls the scaling that is applied to the contents the ICompositionSurface with respect to the size of the SpriteVisual that is being painted.").break()
				.text(msLearn("microsoft.ui.composition.compositionsurfacebrush.stretch")).build()
		},
		{
			fieldName: "surface",
			documentation: new DocBuilder()
				.text("Field").code(".surface").break()
				.text("The ICompositionSurface associated with the CompositionSurfaceBrush.").break()
				.text(msLearn("microsoft.ui.composition.compositionsurfacebrush.surface")).build()
		},
		{
			fieldName: "transformMatrix",
			documentation: new DocBuilder()
				.text("Field").code(".transformMatrix").break()
				.text("The transformation matrix to apply to the brush.").break()
				.text(msLearn("microsoft.ui.composition.compositionsurfacebrush.transformmatrix")).build()
		},
		{
			fieldName: "verticalAlignmentRatio",
			documentation: new DocBuilder()
				.text("Field").code(".verticalAlignmentRatio").break()
				.text("Controls the positioning of the horizontal axis of content with respect to the horizontal axis of the SpriteVisual. Value is clamped from 0.0f to 1.0f.").break()
				.text(msLearn("microsoft.ui.composition.compositionsurfacebrush.verticalalignmentratio")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionSurfaceBrush").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Paints a SpriteVisual with pixels from an ICompositionSurface.").break()
		.text(msLearn("microsoft.ui.composition.compositionsurfacebrush")).build()
};

export const BrushBuiltins: Record<string, ObjectBuiltin> = {
	"BackdropBrush": BackdropBrushBuiltin,
	"ColorBrush": ColorBrushBuiltin,
	"EffectBrush": EffectBrushBuiltin,
	"LinearGradientBrush": LinearGradientBrushBuiltin,
	"RadialGradientBrush": RadialGradientBrushBuiltin,
	"MaskBrush": MaskBrushBuiltin,
	"NineGridBrush": NineGridBrushBuiltin,
	"SurfaceBrush": SurfaceBrushBuiltin
};