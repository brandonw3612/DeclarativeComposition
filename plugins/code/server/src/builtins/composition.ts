import { ObjectBuiltin } from './builtin';
import { DocBuilder, msLearn } from './doc';

export const CompositionObjectBuiltin : ObjectBuiltin = {
	typeName: "CompositionObject",
	parent: undefined,
	fields: [
		{
			fieldName: "comment",
			documentation: new DocBuilder()
				.text("Field").code(".comment").break()
				.text("A string to associate with the CompositionObject.").break()
				.text(msLearn("microsoft.ui.composition.compositionobject.comment"))
				.build()
		}
	],
	children: undefined,
	documentation: new DocBuilder()
		.text("Class").code("CompositionObject")
		.text("in namespace").code("Microsoft.UI.Composition").break()
		.text("Base class of the composition API representing a node in the visual tree structure.").break()
		.text(msLearn("microsoft.ui.composition.compositionobject"))
		.build()
};