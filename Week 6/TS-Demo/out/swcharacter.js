"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var SWCharacter = /** @class */ (function () {
    // shorthand syntax for having private "name" member,
    // set from constructor
    function SWCharacter(name) {
        this.name = name;
    }
    SWCharacter.prototype.description = function () {
        return "Character named " + this.name;
    };
    return SWCharacter;
}());
exports.SWCharacter = SWCharacter;
