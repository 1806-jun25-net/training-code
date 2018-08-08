export class Ajax {
    constructor() {
        
    }

    send(url: string,
        method: string,
        success: (text: string) => void,
        failure: (text: string) => void): void {
        let xhr = new XMLHttpRequest();
        
        xhr.addEventListener("load", Response => {
            if(xhr.status >= 200 && xhr.status < 300) {
                success(xhr.responseText)
            }
            else {
                failure(xhr.statusText)
            }
        });

        xhr.open(method, url);
        xhr.send();
    }
}