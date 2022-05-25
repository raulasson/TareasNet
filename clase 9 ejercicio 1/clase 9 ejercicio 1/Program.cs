Console.WriteLine("ingrese el tamaño del vector");
int longitud = int.Parse(Console.ReadLine());
int [] vector = new int[longitud];
Random num = new Random();
int aux;
for (int i = 0; i < longitud; i++)
{
    vector[i] = num.Next(100);
}
Console.WriteLine("el vector ingresado es:");
for (int i = 0; i < longitud; i++)
{
    Console.Write($"{vector[i]}   ");
}
Console.WriteLine();
for (int i = 0; i < longitud/2; i++)
{
    aux = vector[i];
    vector[i] = vector[longitud - 1 - i];
    vector[longitud - 1 - i] = aux;
}
Console.WriteLine();
Console.WriteLine("El vector invertido queda:");
for (int i = 0; i < longitud; i++)
{
    Console.Write($"{vector[i]}   ");
}
