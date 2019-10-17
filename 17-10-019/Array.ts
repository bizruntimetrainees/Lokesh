var fruits:(string|number)[];
fruits = ['Apple','Banana','PineApple','Orange','DragonFruit','Sapota'];
var d=fruits[3];
console.log("Access elements using index : "+d);
console.log("----------------------");
for(var i=0 ; i<fruits.length ; i++)
{
    console.log("Access elements using For loop : "+fruits[i]);
}
console.log("----------------------");
var e=fruits.pop();
console.log("Remove elemnts at last : "+e);
console.log("----------------------");
for(var i=0 ; i<fruits.length ; i++)
{
    console.log("Access elements using For loop : "+fruits[i]);
}
console.log("----------------------");
var f=fruits.push('Sapota');
console.log("Add elemnts at last : "+f);
console.log("----------------------");
for(var i=0 ; i<fruits.length ; i++)
{
    console.log("Access elements using For loop : "+fruits[i]);
}
console.log("----------------------");
var h=fruits.sort();
console.log("Sort elements ascending order : "+h);
console.log("----------------------");
var j =fruits.concat([4,5]);
console.log("concat two Array : "+j);
console.log("----------------------");
console.log("Index of : "+fruits.indexOf('PineApple'));
console.log("----------------------");
console.log("Joined as string : "+fruits.join());
console.log("----------------------");
console.log("Slice : "+fruits.slice());
console.log("----------------------");