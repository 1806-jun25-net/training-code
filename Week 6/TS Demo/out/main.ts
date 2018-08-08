import { Ajax } from "./ajax";
import { Character } from "./character";

class Main {
    constructor() {
        
    }

    static Main() : void {
        console.log("Hello world");

        let ajax = new Ajax();
        
        let btn = document.querySelector("#searchBtn") as HTMLButtonElement;
        let list = document.querySelector("#searchList") as HTMLOListElement;
        let input = document.querySelector("#searchText") as HTMLInputElement;

        btn.addEventListener("click", () => {
            let x = input.value;
            let url = `https://pokeapi.co/api/v2/pokemon/${x}`;
            ajax.send(url, "get",
                text => {
                    let result = JSON.parse(text)
                    list.innerHTML = "";
                    debugger;
                    result.foreach(el => {
                        let char = new Character(el.name);
                        let newItem = document.createElement("li");
                        newItem.innerHTML = el.description;
                        list.appendChild(newItem);
                    })
                },
                text => {
                    console.log(`error: ${text}`)
                })
        });
    }
}

Main.Main();