using System;
namespace Dem0
{
class Sample
{
public string param1, param2;
public Sample(string x, string y)     
{
param1 = x;
param2 = y;
}
}
class Program
{
static void Main(string[] args)
{
Sample obj=new Sample("Welcome","Aspdotnet-Suresh");   
Console.WriteLine(obj.param1 +" to "+ obj.param2);
Console.ReadLine();
}
}
}