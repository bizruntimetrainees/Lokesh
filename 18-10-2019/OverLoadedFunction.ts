function add(a:string, b:string):string;

function add(a:number, b:number): number;

function add(a:string, b:number):any;

function add(a: any, b:any): any {
    return a + b;
}
console.log(add(500,764));
console.log(add("lokesh ","kumar"));
console.log(add("Lokesh ",33));
