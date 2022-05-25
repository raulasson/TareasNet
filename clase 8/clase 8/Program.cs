Console.WriteLine("ingrese cantidad de columnas");
int colum = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese cantidad de filas");
int filas = int.Parse(Console.ReadLine());
int[,] numeros = new int[filas,colum];
double[] prom = new double[colum];
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < colum; j++)
    {
        Console.Clear();
        Console.WriteLine($"ingresar el valor de la fila {i+1} columna {j+1}");
        numeros[i,j] = int.Parse(Console.ReadLine());
    }
}
Console.Clear();
Console.WriteLine("la matriz ingresada fue:");
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < colum; j++)
    {
        Console.Write($"{numeros[i,j]} \t");
       // Console.Write("   ");
    }
    Console.WriteLine("");
}

for (int i = 0; i < colum; i++)
{
    for (int j = 0; j < filas; j++)
    {
        prom[i] += numeros[j, i];
    }
    prom[i] /= filas;
}

for (int i = 0; i < prom.Length; i++)
{
    Console.WriteLine($"el promedio de la columna {i+1} es: {prom[i]}");
}
