export class SWCharacter {
    // shorthand syntax for having private "name" member,
    // set from constructor
    constructor(private name: string) {
    }

    description(): string {
        return `Character named ${this.name}`
    }
}
