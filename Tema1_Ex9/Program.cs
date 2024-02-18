/*Ex 9
Scrieti un program care interschimba valoarea a doua variabile intregi.*/

Console.WriteLine("Introduceti prima valoare:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti a doua valoare:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Valori initiale:");
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);

// interschimbare
int temp = a;
a = b;
b = temp;

Console.WriteLine("Valori după interschimbare:");
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);