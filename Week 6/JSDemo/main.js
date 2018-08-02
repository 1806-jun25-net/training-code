//DOM API
//document object model
//basic event handling (object.onevent = function(){})
window.onload = function(){
    let myspan = this.document.getElementById("myspane");
    myspan.innerHTML = "dynamic text";
}

// More modern approach to event handlers
document.addEventListener("DOMContentLoaded", function() {
    let myspan = this.document.getElementById("myspan");
    myspan.innerHTML = "overwritten text";
    // run BEFOR window.onload
    let mylink = document.getElementById("mylink");
    mylink.addEventListener("click", 
    () =>
        {
            event.target.preventDefault();
            alert("You clicked on the link")
        });
});
debugger; //BREAKPOINT
function alertMe() {
    alert("You clicked the button!");
}

// the DOM structure:
//  window
//      document
//          documentElement (<html> element)
//              (all other elements, <head>, <body>, etc.)


let myspan = document.getElementById("myspan");

myspan.innerHTML = "dynamic text";

//dynamic typing - any property on any object
let myrandomobj = {name: "Fred"};
myrandomobj.innerHTML = "null";

let c = newCounter();
alert(c() + " " + c() + " " + c());
// implement newCounter()
let x = 0;
function newCounter(){
    x++;
    return x;
}

function counterAlert(){
    alert(c() + " " + c() + " " + c());
}

