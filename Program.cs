﻿Console.Write("Digite um número: ");
int numero   = int.Parse(Console.ReadLine()!);
if(numero % 2 == 0){
Console.WriteLine($"{numero} é par");
}
else{
    Console.Write($"{numero} é ímpar");
}