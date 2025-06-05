import { MarkupContent } from 'vscode-languageserver';
import { DeclarationBuiltin } from './dc';
import { LightBuiltins } from './light';
import { BrushBuiltins } from './brush';
import { ShapeBuiltins } from './shape';
import { VisualBuiltins } from './visual';
import { ShadowBuiltins } from './shadow';
import { GeometryBuiltins } from './geometry';
import { ClipBuiltins } from './clip';
import { MiscBuiltins } from './misc';

export interface ObjectBuiltin {
	typeName: string;
	parent?: ObjectBuiltin;
	fields: (FieldBuiltin | BuiltinEnumField)[];
	children?: ObjectBuiltin;
	documentation: MarkupContent;
}

export interface FieldBuiltin {
	fieldName: string;
	details?: string;
	documentation: MarkupContent;
}

export interface BuiltinEnumField extends FieldBuiltin {
	candidates: string[];
}

export const DeclarableBuiltins: Record<string, ObjectBuiltin> = {
	...LightBuiltins,
	...BrushBuiltins,
	...ShapeBuiltins,
	...VisualBuiltins,
	...ShadowBuiltins,
	...GeometryBuiltins,
	...ClipBuiltins,
	...MiscBuiltins
};

export const BuiltinObjects: Record<string, ObjectBuiltin> = {
	"dc": DeclarationBuiltin,
	...DeclarableBuiltins
};