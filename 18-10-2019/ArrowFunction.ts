/*let sum = (x: number, y: number): number => {
    return x + y;
}

console.log(sum(10,20));*/

let sum = (x: number, y: number) => x + y;

console.log(sum(3,4));
console.log("------------------------------");

class Employee {
    empCode: number;
    empName: string;

    constructor(code: number, name: string) {
            this.empName = name;
            this.empCode = code;
    }

    display = () => console.log(this.empCode +' ' + this.empName)
}
let emp = new Employee(1, 'Ram');
emp.display();