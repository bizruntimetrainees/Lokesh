let num11:number=1;
function letDeclaration() { 
    let num2:number = 2; 

    if (num2 > num11) { 
        let num3: number = 3;
        num3++; 
    } 

    while(num11 < num2) { 
        let num4: number = 4;
        num11++;
    }

    console.log(num11);
    console.log(num2);
    //console.log(num3);
    //console.log(num4);

}
letDeclaration();