// anything exported has to be imported to be used.
// you import from a string which means the relative path
// to that file where it's defined.

// when writing good typescript, every class should be in its own file,
// and exported/imported. this is like namespaces/using in c#.

import { Ajax } from "./ajax";
import { SWCharacter } from "./swcharacter";

class Main {
    constructor() {

    }

    // central addition of TypeScript:
    // type annotations e.g. ": void"
    static Main() : void {
        console.log("Hello world");

        let ajax = new Ajax();

        // querySelector, another way to getElementById or by class, etc.
        // in typescript, we cast like this: "<newType> object"
        // or, with "as":

        let btn = document.querySelector("#searchBtn") as HTMLButtonElement;
        btn.addEventListener("click", () => {
            let list = document.querySelector("#searchList") as HTMLOListElement;
            let input = document.querySelector("#searchText") as HTMLInputElement;
            let searchText = input.value;
            let url = "https://swapi.co/api/people/?search=" + searchText;
            ajax.send(
                url,
                'get',
                text => {
                    let result = JSON.parse(text);

                    list.innerHTML = ""; // empty the list
                    for (let i = 0; i < result.results.length; i++) {
                        let char = new SWCharacter(result.results[i].name);
                        let newItem = document.createElement("li");
                        newItem.innerHTML = char.description();
                        list.appendChild(newItem);
                    };
                },
                text => {
                    console.log("error: " + text);
                });

        });
    }
}

// TypeScript also adds classes, interfaces, inheritance,
// access modifiers

Main.Main();
