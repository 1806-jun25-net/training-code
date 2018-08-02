// by default, typescript leaves things in global scope.
// but, any file with "imports" or "exports" statement in it
// becomes a "module", and ONLY puts in global scope
// what you EXPORT.

export class Ajax {
    constructor() {
    }

    // in typescript, if you don't specify a type, it's "any" type.
    // this works like "dynamic" in C#, and like everything in JS.

    send(
        url: string,
        method: string,
        success: (text: string) => void,
        fail: (text: string) => void): void
        {
        let xhr = new XMLHttpRequest();

        xhr.addEventListener("load", res => {
            // this will run when the request completes
            if (xhr.status >= 200 && xhr.status < 300) {
                success(xhr.responseText);
            } else {
                fail(xhr.statusText);
            }
        });

        xhr.open(method, url);
        xhr.send();
    }
}
