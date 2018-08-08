"use strict";
//Object.defineProperty(exports, "__esModule", { value: true });
var ajax_1 = require("./ajax");
var character_1 = require("./character");
var Main = /** @class */ (function () {
    function Main() {
    }
    Main.Main = function () {
        console.log("Hello world");
        var ajax = new ajax_1.Ajax();
        var btn = document.querySelector("#searchBtn");
        var list = document.querySelector("#searchList");
        var input = document.querySelector("#searchText");
        btn.addEventListener("click", function () {
            var x = input.value;
            var url = "https://pokeapi.co/api/v2/pokemon/" + x;
            ajax.send(url, "get", function (text) {
                var result = JSON.parse(text);
                list.innerHTML = "";
                debugger;
                result.foreach(function (el) {
                    var char = new character_1.Character(el.name);
                    var newItem = document.createElement("li");
                    newItem.innerHTML = el.description;
                    list.appendChild(newItem);
                });
            }, function (text) {
                console.log("error: " + text);
            });
        });
    };
    return Main;
}());
Main.Main();
