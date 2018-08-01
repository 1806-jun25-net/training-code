// basic event handling (object.onevent = function)
window.onload = function () {
    let myspan = document.getElementById("myspan");
    myspan.innerHTML = "dynamic text";
};

// more modern event handling
document.addEventListener("DOMContentLoaded", function () {
    let myspan = document.getElementById("myspan");
    myspan.innerHTML = "overwritten text";
    // runs BEFORE window.onload

    let mylink = document.getElementById("mylink");
    // debugger; // breakpoint
    // mylink is null?
    mylink.onclick = function () {
        // prevent the browser's default
        // behavior when doing things
        event.target.preventDefault();
        alert("You clicked the link");
    };

    let theTD = document.getElementById("theTD");
    let theTR = theTD.parentElement;
    let theTABLE = theTR.parentElement.parentElement;

    function printName() {
        // string interpolation with backtick and ${}
        console.log(`Event target: ${event.target}`);
        console.log(`This: ${this}`);
    }

    // in all event handlers, "this" is re-bound to the element
    // handling the event.
    // unless it's an arrow function.

    let masterHandler = {
        name: "the master handler",
        handler1: function () {
            alert(this.name); // "this" points to the element the handler is added to, NOT the masterHandler
        },
        handler2: () => {
            alert(this.name); // "this" points to the element the handler is added to, NOT the masterHandler
        } // not working?
    };

    theTD.nextElementSibling.onclick = masterHandler.handler2;

    // with addEventListener, we can have more than one handler on an event.
    theTD.addEventListener("click", () => {
        alert("stopping propagation");
        // stopPropagation stops any handlers AFTER this element
        // event.stopPropagation(); // not great practice
        // stops all future handlers, even ones on THIS element
        event.stopImmediatePropagation();
    });

    // when events happen:
    // 1. capturing phase. we run handlers on the whole
    //  document, then anything nested within.
    // 2. target phase. we run handlers on the target itself.
    // 3. bubbling phase. we run handlers on the parent of
    //  the target, and on up back to the whole document.

    // by default, most event handlers are in the bubbling phase.
    theTD.addEventListener("click", printName);
    theTR.addEventListener("click", printName);
    theTABLE.addEventListener("click", printName);

    // you CAN have event handlers in the capturing phase
    // third parameter true -> capturing
    theTABLE.addEventListener("click", printName, true);

    function addNewText() {
        // making a new element object
        let newElement = document.createElement("p");
        // modifying its contents
        newElement.innerHTML = "new element";
        // appending it to the end of the body
        document.body.appendChild(newElement);
    }

    theTABLE.addEventListener("mouseover", addNewText);

    theTABLE.addEventListener("mouseover", addNewText);

    let c = newCounter();
    alert(c() + ' ' + c() + ' ' + c());
    // gives a popup that says "1 2 3"
});

function alertMe() {
    alert("You clicked the button");
}

function newCounter(){
    let x = 0;
    return function() { x++; return x; };
}



// document.onDOMCreated

//  the DOM structure:
//  window
//    document
//      documentElement (<html> element)
//        (all other elements, <head>, <body>, etc.)
//




// dynamic typing - any property on any object
let myrandomobj = {name: "Fred"};
myrandomobj.innerHTML = "asdf";
