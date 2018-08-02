"use strict";
// by default, typescript leaves things in global scope.
// but, any file with "imports" or "exports" statement in it
// becomes a "module", and ONLY puts in global scope
// what you EXPORT.
Object.defineProperty(exports, "__esModule", { value: true });
var Ajax = /** @class */ (function () {
    function Ajax() {
    }
    // in typescript, if you don't specify a type, it's "any" type.
    // this works like "dynamic" in C#, and like everything in JS.
    Ajax.prototype.send = function (url, method, success, fail) {
        var xhr = new XMLHttpRequest();
        xhr.addEventListener("load", function (res) {
            // this will run when the request completes
            if (xhr.status >= 200 && xhr.status < 300) {
                success(xhr.responseText);
            }
            else {
                fail(xhr.statusText);
            }
        });
        xhr.open(method, url);
        xhr.send();
    };
    return Ajax;
}());
exports.Ajax = Ajax;
