class Animal{

    constructor(name){
        this.name=name;
    }
    eats(){
        console.log(this.name+" eats food");
    }
}

class Allligator extends Animal{
    eats(){
        super.eats();
        console.log(this.name+" eats fishes");
    }
}

let murphy = new Allligator("Murphy");
murphy.eats();