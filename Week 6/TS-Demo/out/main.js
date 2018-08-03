"use strict";
// anything exported has to be imported to be used.
// you import from a string which means the relative path
// to that file where it's defined.
Object.defineProperty(exports, "__esModule", { value: true });
// when writing good typescript, every class should be in its own file,
// and exported/imported. this is like namespaces/using in c#.
var ajax_1 = require("./ajax");
var swcharacter_1 = require("./swcharacter");
var Main = /** @class */ (function () {
    function Main() {
    }
    // central addition of TypeScript:
    // type annotations e.g. ": void"
    Main.Main = function () {
        console.log("Hello world");
        var ajax = new ajax_1.Ajax();
        // querySelector, another way to getElementById or by class, etc.
        // in typescript, we cast like this: "<newType> object"
        // or, with "as":
        var btn = document.querySelector("#searchBtn");
        btn.addEventListener("click", function () {
            var list = document.querySelector("#searchList");
            var input = document.querySelector("#searchText");
            var searchText = input.value;
            var url = "https://swapi.co/api/people/?search=" + searchText;
            ajax.send(url, 'get', function (text) {
                var result = JSON.parse(text);
                list.innerHTML = ""; // empty the list
                for (var i = 0; i < result.results.length; i++) {
                    var char = new swcharacter_1.SWCharacter(result.results[i].name);
                    var newItem = document.createElement("li");
                    newItem.innerHTML = char.description();
                    list.appendChild(newItem);
                }
                ;
            }, function (text) {
                console.log("error: " + text);
            });
        });
    };
    return Main;
}());
// TypeScript also adds classes, interfaces, inheritance,
// access modifiers
Main.Main();
