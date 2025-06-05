import { ObjectBuiltin } from './builtin';
import { DocBuilder } from './doc';

export const DeclarationBuiltin: ObjectBuiltin = {
	typeName: "dc",
	documentation: new DocBuilder()
		.code("dc").break()
		.text("Required header for a DCL source. Contains necessary metadata for the auto-generated C# class.")
		.build(),
	fields: [
		{
			fieldName: "class",
			details: "Full class name",
			documentation: new DocBuilder()
				.text("Field").code(".class").break()
				.text("Name of the auto-generated C# class.")
				.build()
		},
		{
			fieldName: "initializer",
			details: "Composition UI initializer",
			candidates: ["constructor", "independent"],
			documentation: new DocBuilder()
				.text("Field").code(".initializer").break()
				.text("Indicates whether the construction of the composition elements are included in the constructor or an independent method.")
				.build()
		}
	],
	children: undefined,
};