var num = 0;
int[] numeros = new int[10];
var acum = 0;
int aux = 0;
int aux1=0;
int prom;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Ingrese un numero para sumar");
    num = int.Parse(Console.ReadLine());
    acum += num;
    numeros[i] = num;
}
aux = numeros[0];
aux1 = aux;
for (int i = 0; i <10; i++)
{
    if (aux>numeros[i])
    {
        aux = numeros[i];
    }
    if (aux1<numeros[i])
    {
        aux1 = numeros[i];
    }
}
prom = acum / 10;
Console.Clear();
Console.WriteLine($"se acumulo: {acum}");
Console.WriteLine($"max : {aux1}   min : {aux}");
Console.WriteLine($"El promedio de lo acumulado es: {prom}");
Console.WriteLine("los numeros ingresados son:");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($" {numeros[i]}");
}



