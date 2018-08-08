export class Character {
    private name: string;

    constructor(name: string) {
        this.name = name;
    }

    description(): string {
        return `Character named ${this.name}`;
    }
}