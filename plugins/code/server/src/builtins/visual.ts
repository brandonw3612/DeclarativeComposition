import { ObjectBuiltin } from './builtin';
import { CompositionObjectBuiltin } from './composition';
import { DocBuilder, msLearn } from './doc';

export const VisualBuiltin: ObjectBuiltin = {
	typeName: "Visual",
	parent: CompositionObjectBuiltin,
	fields: [
		...CompositionObjectBuiltin.fields,
		{
			fieldName: "anchorPoint",
			documentation: new DocBuilder()
				.text("Field").code(".anchorPoint").break()
				.text("The point on the visual to be positioned at the visual's offset. Value is normalized with respect to the size of the visual. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.visual.anchorpoint")).build()
		},
		{
			fieldName: "backfaceVisibility",
			documentation: new DocBuilder()
				.text("Field").code(".backfaceVisibility").break()
				.text("Specifies whether the back face of the visual should be visible during a 3D transform.").break()
				.text(msLearn("microsoft.ui.composition.visual.backfacevisibility")).build()
		},
		{
			fieldName: "borderMode",
			documentation: new DocBuilder()
				.text("Field").code(".borderMode").break()
				.text("Specifies how to compose the edges of bitmaps and clips associated with a visual, or with all visuals in the subtree rooted at this visual. Setting BorderMode at a parent Visual will affect all children visuals in the subtree and can be selectively turned off at each child visual.").break()
				.text(msLearn("microsoft.ui.composition.visual.bordermode")).build()
		},
		{
			fieldName: "centerPoint",
			documentation: new DocBuilder()
				.text("Field").code(".centerPoint").break()
				.text("The point about which rotation or scaling occurs. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.visual.centerpoint")).build()
		},
		{
			fieldName: "clip",
			documentation: new DocBuilder()
				.text("Field").code(".clip").break()
				.text("Specifies the clipping region for the visual. When a visual is rendered, only the portion of the visual that falls inside the clipping region is displayed, while any content that extends outside the clipping region is clipped (that is, not displayed).").break()
				.text(msLearn("microsoft.ui.composition.visual.clip")).build()
		},
		{
			fieldName: "compositeMode",
			documentation: new DocBuilder()
				.text("Field").code(".compositeMode").break()
				.text("Specifies how a visual's bitmap is blended with the screen.").break()
				.text(msLearn("microsoft.ui.composition.visual.compositemode")).build()
		},
		{
			fieldName: "isHitTestVisible",
			documentation: new DocBuilder()
				.text("Field").code(".isHitTestVisible").break()
				.text("A value that indicates whether the visual sub-tree rooted at this visual participates in hit testing.").break()
				.text(msLearn("microsoft.ui.composition.visual.ishittestvisible")).build()
		},
		{
			fieldName: "isPixelSnappingEnabled",
			documentation: new DocBuilder()
				.text("Field").code(".isPixelSnappingEnabled").break()
				.text("A value that indicates whether the composition engine aligns the rendered visual with a pixel boundary.").break()
				.text(msLearn("microsoft.ui.composition.visual.ispixelsnappingenabled")).build()
		},
		{
			fieldName: "isVisible",
			documentation: new DocBuilder()
				.text("Field").code(".isVisible").break()
				.text("Indicates whether the visual and its entire subtree of child visuals is visible.").break()
				.text(msLearn("microsoft.ui.composition.visual.isvisible")).build()
		},
		{
			fieldName: "offset",
			documentation: new DocBuilder()
				.text("Field").code(".offset").break()
				.text("The offset of the visual relative to its parent or for a root visual the offset relative to the upper-left corner of the windows that hosts the visual. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.visual.offset")).build()
		},
		{
			fieldName: "opacity",
			documentation: new DocBuilder()
				.text("Field").code(".opacity").break()
				.text("The opacity of the visual. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.visual.opacity")).build()
		},
		{
			fieldName: "orientation",
			documentation: new DocBuilder()
				.text("Field").code(".orientation").break()
				.text("A quaternion describing an orientation and rotation in 3D space that will be applied to the visual. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.visual.orientation")).build()
		},
		{
			fieldName: "parentForTransform",
			documentation: new DocBuilder()
				.text("Field").code(".parentForTransform").break()
				.text("Visual specifying the coordinate system in which this visual is composed.").break()
				.text(msLearn("microsoft.ui.composition.visual.parentfortransform")).build()
		},
		{
			fieldName: "relativeOffsetAdjustment",
			documentation: new DocBuilder()
				.text("Field").code(".relativeOffsetAdjustment").break()
				.text("Specifies the offset of the visual with respect to the size of its parent visual.").break()
				.text(msLearn("microsoft.ui.composition.visual.relativeoffsetadjustment")).build()
		},
		{
			fieldName: "relativeSizeAdjustment",
			documentation: new DocBuilder()
				.text("Field").code(".relativeSizeAdjustment").break()
				.text("The size of the visual with respect to the size of its parent visual.").break()
				.text(msLearn("microsoft.ui.composition.visual.relativesizeadjustment")).build()
		},
		{
			fieldName: "rotationAngle",
			documentation: new DocBuilder()
				.text("Field").code(".rotationAngle").break()
				.text("The rotation angle in radians of the visual. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.visual.rotationangle")).build()
		},
		{
			fieldName: "rotationAngleInDegrees",
			documentation: new DocBuilder()
				.text("Field").code(".rotationAngleInDegrees").break()
				.text("The rotation angle of the visual in degrees. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.visual.rotationangleindegrees")).build()
		},
		{
			fieldName: "rotationAxis",
			documentation: new DocBuilder()
				.text("Field").code(".rotationAxis").break()
				.text("The axis to rotate the visual around. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.visual.rotationaxis")).build()
		},
		{
			fieldName: "scale",
			documentation: new DocBuilder()
				.text("Field").code(".scale").break()
				.text("The scale to apply to the visual.").break()
				.text(msLearn("microsoft.ui.composition.visual.scale")).build()
		},
		{
			fieldName: "size",
			documentation: new DocBuilder()
				.text("Field").code(".size").break()
				.text("The width and height of the visual. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.visual.size")).build()
		},
		{
			fieldName: "transformMatrix",
			documentation: new DocBuilder()
				.text("Field").code(".transformMatrix").break()
				.text("The transformation matrix to apply to the visual. Animatable.").break()
				.text(msLearn("microsoft.ui.composition.visual.transformmatrix")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("Visual").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("The base visual object in the visual hierarchy.").break()
		.text(msLearn("microsoft.ui.composition.visual")).build()
};

export const ContainerVisualBuiltin: ObjectBuiltin = {
	typeName: "ContainerVisual",
	parent: VisualBuiltin,
	fields: [
		...VisualBuiltin.fields,
		{
			fieldName: "children",
			documentation: new DocBuilder()
				.text("Field").code(".children").break()
				.text("The children of the ContainerVisual.").break()
				.text(msLearn("microsoft.ui.composition.containervisual.children")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("ContainerVisual").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("A node in the visual tree that can have children.").break()
		.text(msLearn("microsoft.ui.composition.containervisual")).build()
};

export const LayerVisualBuiltin: ObjectBuiltin = {
	typeName: "LayerVisual",
	parent: ContainerVisualBuiltin,
	fields: [
		...ContainerVisualBuiltin.fields
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("LayerVisual").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("A ContainerVisual whose children are flattened into a single layer.").break()
		.text(msLearn("microsoft.ui.composition.layervisual")).build()
};

export const RedirectVisualBuiltin: ObjectBuiltin = {
	typeName: "RedirectVisual",
	parent: ContainerVisualBuiltin,
	fields: [
		...ContainerVisualBuiltin.fields,
		{
			fieldName: "source",
			documentation: new DocBuilder()
				.text("Field").code(".source").break()
				.text("The Visual that this RedirectVisual gets its content from.").break()
				.text(msLearn("microsoft.ui.composition.redirectvisual.source")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("RedirectVisual").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents a visual that gets its content from another visual.").break()
		.text(msLearn("microsoft.ui.composition.redirectvisual")).build()
};

export const SceneVisualBuiltin: ObjectBuiltin = {
	typeName: "SceneVisual",
	parent: ContainerVisualBuiltin,
	fields: [
		...ContainerVisualBuiltin.fields,
		{
			fieldName: "root",
			documentation: new DocBuilder()
				.text("Field").code(".root").break()
				.text("The root node of the 3D scene.").break()
				.text(msLearn("microsoft.ui.composition.scenes.scenevisual.root")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("SceneVisual").text("in namespace").code("Microsoft.UI.Composition.Scenes").break()
		.text("Represents a container visual for the nodes of a 3D scene.").break()
		.text(msLearn("microsoft.ui.composition.scenes.scenevisual")).build()
};

export const ShapeVisualBuiltin: ObjectBuiltin = {
	typeName: "ShapeVisual",
	parent: ContainerVisualBuiltin,
	fields: [
		...ContainerVisualBuiltin.fields,
		{
			fieldName: "shapes",
			documentation: new DocBuilder()
				.text("Field").code(".shapes").break()
				.text("The collection of CompositionShapes that this shape visual tree is composed of.").break()
				.text(msLearn("microsoft.ui.composition.shapevisual.shapes")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("ShapeVisual").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents a visual tree node that is the root of a CompositionShape.").break()
		.text(msLearn("microsoft.ui.composition.shapevisual")).build()
};

export const SpriteVisualBuiltin: ObjectBuiltin = {
	typeName: "SpriteVisual",
	parent: ContainerVisualBuiltin,
	fields: [
		...ContainerVisualBuiltin.fields,
		{
			fieldName: "brush",
			documentation: new DocBuilder()
				.text("Field").code(".brush").break()
				.text("A CompositionBrush describing how the SpriteVisual is painted.").break()
				.text(msLearn("microsoft.ui.composition.spritevisual.brush")).build()
		},
		{
			fieldName: "shadow",
			documentation: new DocBuilder()
				.text("Field").code(".shadow").break()
				.text("The shadow for the SpriteVisual.").break()
				.text(msLearn("microsoft.ui.composition.spritevisual.shadow")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("SpriteVisual").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Hosts 2D boxed content of type CompositionBrush. Any part of the visual not covered by pixels from the brush are rendered as transparent pixels. CompositionBrush can be either a CompositionBackdropBrush, CompositionColorBrush, a CompositionSurfaceBrush or a CompositionEffectBrush.").break()
		.text(msLearn("microsoft.ui.composition.spritevisual")).build()
};

export const VisualBuiltins: Record<string, ObjectBuiltin> = {
	"ContainerVisual": ContainerVisualBuiltin,
	"LayerVisual": LayerVisualBuiltin,
	"RedirectVisual": RedirectVisualBuiltin,
	"SceneVisual": SceneVisualBuiltin,
	"ShapeVisual": ShapeVisualBuiltin,
	"SpriteVisual": SpriteVisualBuiltin
};