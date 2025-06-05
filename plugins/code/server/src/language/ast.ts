export abstract class Node {
	constructor(
		public type: string,
		public start: number,
		public end: number
	) {}

	public abstract getScope(position: number, providerPrefix: string | undefined): {
		scopeType: "root" | "declaration" | "object" | "property" | "string" | "sharp",
		provider: string | undefined,
	};
}

export class RootNode extends Node {
	public getScope(position: number, _providerPrefix: string | undefined = undefined): {
		scopeType: "root" | "declaration" | "object" | "property" | "string" | "sharp",
		provider: string | undefined,
	} {
		if (this.declaration && position >= this.declaration.start && position <= this.declaration.end) {
			return this.declaration.getScope(position);
		}
		for (const obj of this.body) {
			if (position >= obj.start && position <= obj.end) {
				return obj.getScope(position);
			}
		}
		return { scopeType: 'root', provider: 'root' };
	}
	public declaration?: DeclarationNode;
	public body: ObjectNode[];

	constructor(start: number, end: number, body: ObjectNode[] = [], declaration?: DeclarationNode) {
		super("Root", start, end);
		this.body = body;
		this.declaration = declaration;
	}
}

export class DeclarationNode extends Node {
	public getScope(position: number, _providerPrefix: string | undefined = undefined): {
		scopeType: "root" | "declaration" | "object" | "property" | "string" | "sharp",
		provider: string | undefined,
	} {
		for (const property of this.properties) {
			if (position >= property.start && position <= property.end) {
				return property.getScope(position, "dc");
			}
		}
		return { scopeType: 'declaration', provider: "dc" };
	}
	public properties: PropertyNode[];

	constructor(start: number, end: number, properties: PropertyNode[] = []) {
		super("Declaration", start, end);
		this.properties = properties;
	}
}

export class PropertyNode extends Node {
	public getScope(position: number, providerPrefix: string | undefined = undefined): {
		scopeType: "root" | "declaration" | "object" | "property" | "string" | "sharp",
		provider: string | undefined,
	} {
		if (this.value && this.value.start <= position && this.value.end >= position) {
			return this.value.getScope(position);
		}
		const provider = providerPrefix ? `${providerPrefix}/${this.name}` : this.name;
		return { scopeType: 'property', provider };
	}
	public name: string;
	public value?: ExpressionNode;

	constructor(start: number, end: number, name: string, value?: ExpressionNode) {
		super("Property", start, end);
		this.name = name;
		this.value = value;
	}
}

export class ObjectNode extends Node {
	public getScope(position: number, _providerPrefix: string | undefined = undefined): {
		scopeType: "root" | "declaration" | "object" | "property" | "string" | "sharp",
		provider: string | undefined,
	} {
		for (const child of this.children) {
			if (position >= child.start && position <= child.end) {
				return child.getScope(position);
			}
		}
		for (const property of this.properties) {
			if (position >= property.start && position <= property.end) {
				return property.getScope(position, this.objectType);
			}
		}
		return { scopeType: 'object', provider: this.objectType };
	}
	public name?: string;
	public objectType: string;
	public properties: PropertyNode[];
	public children: ObjectNode[];

	constructor(
		start: number,
		end: number,
		objectType: string,
		properties: PropertyNode[] = [],
		children: ObjectNode[] = [],
		name?: string
	) {
		super("Object", start, end);
		this.objectType = objectType;
		this.properties = properties;
		this.children = children;
		this.name = name;
	}
}

export class CollectionNode extends Node {
	public getScope(position: number, _providerPrefix: string | undefined = undefined): {
		scopeType: "root" | "declaration" | "object" | "property" | "string" | "sharp",
		provider: string | undefined,
	} {
		for (const item of this.items) {
			if (position >= item.start && position <= item.end) {
				return item.getScope(position);
			}
		}
		return { scopeType: 'object', provider: 'collection' };
	}
	public items: ExpressionNode[];

	constructor(start: number, end: number, items: ExpressionNode[] = []) {
		super("Collection", start, end);
		this.items = items;
	}
}

export class StringLiteralNode extends Node {
	public getScope(_position: number, _providerPrefix: string | undefined = undefined): {
		scopeType: "root" | "declaration" | "object" | "property" | "string" | "sharp",
		provider: string | undefined,
	} {
		return { scopeType: 'string', provider: this.value };
	}
	public value: string;

	constructor(start: number, end: number, value: string) {
		super("StringLiteral", start, end);
		this.value = value;
	}
}

export class SharpCodeNode extends Node {
	public getScope(_position: number, _providerPrefix: string | undefined = undefined): {
		scopeType: "root" | "declaration" | "object" | "property" | "string" | "sharp",
		provider: string | undefined,
	} {
		return { scopeType: 'sharp', provider: this.value };
	}
	public value: string;

	constructor(start: number, end: number, value: string) {
		super("SharpCode", start, end);
		this.value = value;
	}
}

// Union types remain unchanged
export type SingleExpressionNode = StringLiteralNode | SharpCodeNode | ObjectNode;
export type ExpressionNode = SingleExpressionNode | CollectionNode;