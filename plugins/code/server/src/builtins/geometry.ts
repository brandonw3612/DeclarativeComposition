import { ObjectBuiltin } from './builtin';
import { CompositionObjectBuiltin } from './composition';
import { DocBuilder, msLearn } from './doc';

export const CompositionGeometryBuiltin: ObjectBuiltin = {
	typeName: "CompositionGeometry",
	parent: CompositionObjectBuiltin,
	fields: [
		...CompositionObjectBuiltin.fields,
		{
			fieldName: "trimEnd",
			documentation: new DocBuilder()
				.text("Field").code(".trimEnd").break()
				.text("The amount to trim the end of the geometry path.").break()
				.text(msLearn("microsoft.ui.composition.compositiongeometry.trimend")).build()
		},
		{
			fieldName: "trimOffset",
			documentation: new DocBuilder()
				.text("Field").code(".trimOffset").break()
				.text("The amount to offset trimming the geometry path.").break()
				.text(msLearn("microsoft.ui.composition.compositiongeometry.trimoffset")).build()
		},
		{
			fieldName: "trimStart",
			documentation: new DocBuilder()
				.text("Field").code(".trimStart").break()
				.text("The amount to trim the start of the geometry path.").break()
				.text(msLearn("microsoft.ui.composition.compositiongeometry.trimstart")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionGeometry").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Base class for geometry objects used in composition.").break()
		.text(msLearn("microsoft.ui.composition.compositiongeometry")).build()
};

export const CompositionEllipseGeometryBuiltin: ObjectBuiltin = {
	typeName: "EllipseGeometry",
	parent: CompositionGeometryBuiltin,
	fields: [
		...CompositionGeometryBuiltin.fields,
		{
			fieldName: "center",
			documentation: new DocBuilder()
				.text("Field").code(".center").break()
				.text("The center point of the ellipse.").break()
				.text(msLearn("microsoft.ui.composition.compositionellipsegeometry.center")).build()
		},
		{
			fieldName: "radius",
			documentation: new DocBuilder()
				.text("Field").code(".radius").break()
				.text("The radius of the ellipse.").break()
				.text(msLearn("microsoft.ui.composition.compositionellipsegeometry.radius")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionEllipseGeometry").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents an ellipse geometry.").break()
		.text(msLearn("microsoft.ui.composition.compositionellipsegeometry")).build()
};

export const CompositionLineGeometryBuiltin: ObjectBuiltin = {
	typeName: "LineGeometry",
	parent: CompositionGeometryBuiltin,
	fields: [
		...CompositionGeometryBuiltin.fields,
		{
			fieldName: "start",
			documentation: new DocBuilder()
				.text("Field").code(".start").break()
				.text("The starting point of the line.").break()
				.text(msLearn("microsoft.ui.composition.compositionlinegeometry.start")).build()
		},
		{
			fieldName: "end",
			documentation: new DocBuilder()
				.text("Field").code(".end").break()
				.text("The end point of the line.").break()
				.text(msLearn("microsoft.ui.composition.compositionlinegeometry.end")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionLineGeometry").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents a straight line between two points.").break()
		.text(msLearn("microsoft.ui.composition.compositionlinegeometry")).build()
};

export const CompositionPathGeometryBuiltin: ObjectBuiltin = {
	typeName: "PathGeometry",
	parent: CompositionGeometryBuiltin,
	fields: [
		...CompositionGeometryBuiltin.fields,
		{
			fieldName: "path",
			documentation: new DocBuilder()
				.text("Field").code(".path").break()
				.text("The data that defines the lines and curves of the path.").break()
				.text(msLearn("microsoft.ui.composition.compositionpathgeometry.path")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionPathGeometry").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents a series of connected lines and curves.").break()
		.text(msLearn("microsoft.ui.composition.compositionpathgeometry")).build()
};

export const CompositionRectangleGeometryBuiltin: ObjectBuiltin = {
	typeName: "RectangleGeometry",
	parent: CompositionGeometryBuiltin,
	fields: [
		...CompositionGeometryBuiltin.fields,
		{
			fieldName: "offset",
			documentation: new DocBuilder()
				.text("Field").code(".offset").break()
				.text("The offset of the rectangle.").break()
				.text(msLearn("microsoft.ui.composition.compositionrectanglegeometry.offset")).build()
		},
		{
			fieldName: "size",
			documentation: new DocBuilder()
				.text("Field").code(".size").break()
				.text("The height and width of the rectangle.").break()
				.text(msLearn("microsoft.ui.composition.compositionrectanglegeometry.size")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionRectangleGeometry").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents a rectangle shape of the specified size.").break()
		.text(msLearn("microsoft.ui.composition.compositionrectanglegeometry")).build()
};

export const CompositionRoundedRectangleGeometryBuiltin: ObjectBuiltin = {
	typeName: "RoundedRectangleGeometry",
	parent: CompositionGeometryBuiltin,
	fields: [
		...CompositionGeometryBuiltin.fields,
		{
			fieldName: "cornerRadius",
			documentation: new DocBuilder()
				.text("Field").code(".cornerRadius").break()
				.text("The degree to which the corners are rounded.").break()
				.text(msLearn("microsoft.ui.composition.compositionroundedrectanglegeometry.cornerradius")).build()
		},
		{
			fieldName: "offset",
			documentation: new DocBuilder()
				.text("Field").code(".offset").break()
				.text("The offset of the rectangle.").break()
				.text(msLearn("microsoft.ui.composition.compositionroundedrectanglegeometry.offset")).build()
		},
		{
			fieldName: "size",
			documentation: new DocBuilder()
				.text("Field").code(".size").break()
				.text("The height and width of the rectangle.").break()
				.text(msLearn("microsoft.ui.composition.compositionroundedrectanglegeometry.size")).build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionRoundedRectangleGeometry").text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Represents a rectangle shape of the specified size with rounded corners.").break()
		.text(msLearn("microsoft.ui.composition.compositionroundedrectanglegeometry")).build()
};

export const GeometryBuiltins: Record<string, ObjectBuiltin> = {
	"EllipseGeometry": CompositionEllipseGeometryBuiltin,
	"LineGeometry": CompositionLineGeometryBuiltin,
	"PathGeometry": CompositionPathGeometryBuiltin,
	"RectangleGeometry": CompositionRectangleGeometryBuiltin,
	"RoundedRectangleGeometry": CompositionRoundedRectangleGeometryBuiltin
};