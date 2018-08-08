//DOM -- structure of the HTML page in memory
window.onload = function () {
    let myspan = document.getElementById("myspan");
    myspan.innerHTML = "dynamic text";
};

//allows us to have multiple event handlers on one event
document.addEventListener("DOMContentLoaded", function () {
    let myspan = document.getElementById("myspan");
    myspan.innerHTML ="first text";

    //debugger; //how to add a breakpoint
    let mylink = document.getElementById("mylink");
    mylink.onclick = function () {
            //prevent the browsers default behavior
            //when clicking link
            event.preventDefault();
            alert("You clicked the link");
    };

    let theTD = document.getElementById("theTD");
    let theTR = theTD.parentElement;
    let theTABLE = theTR.parentElement.parentElement;

    function printName() {
        console.log(`Event target: ${event.target}`);
        console.log(`This: ${this}`);
    }

    theTD.addEventListener("click", printName);
    theTR.addEventListener("click", printName);
    theTABLE.addEventListener("click", printName);

    
    let a = newCounter();
    //alert(a() + ' ' + a() + ' ' + a());

    let btn = document.getElementById("ajax");
    let list = document.getElementById("list");
    let input = document.getElementById("input")

    btn.addEventListener("click", () => {
        let x = input.value;
        let url = `https://pokeapi.co/api/v2/pokemon/${x}`;
        ajaxGet(url,
            text => {
                let result = JSON.parse(text)
                list.innerHTML = "";
                debugger;
                result.foreach(el => {
                    let newItem = document.createElement("li");
                    newItem.innerHTML = el.name;
                    list.appendChild(newItem);
                })
            },
            text => {
                console.log(`error: ${text}`)
            })
    });
});

function ajaxGet(url, success, failure) {
    let xhr = new XMLHttpRequest();
    let verb = "get";

    xhr.open(verb, url);
    xhr.addEventListener("load", Response => {
        if(xhr.status >= 200 && xhr.status < 300) {
            success(xhr.responseText)
        }
        else {
            failure(xhr.statusText)
        }
    });

    xhr.send();
}

function alertMe() {
    alert("You clicked the button.");
}

function newCounter() {
    var c = 0;
    return function () {
        c++;
        return c; 
    };
};