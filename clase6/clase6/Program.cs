int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
int intento = 0;
int cont = 1;
while (intento != numeroSecreto)
{
    Console.WriteLine("Adivine que numero 1 al 20 genero la computadora");
    intento = int.Parse(Console.ReadLine());
    if (intento < numeroSecreto)
    {
        Console.WriteLine("El numero ingresado es menor, intente de nuevo");
    }
    else if (intento > numeroSecreto)
    {
        Console.WriteLine("El numero ingresado es mayor, intente de nuevo");
    }
    else
    {
        Console.WriteLine($"Felicitaciones, has adivinado el numero secreto que era: {numeroSecreto}");
        Console.WriteLine($"Lo has logrado en {cont} intentos");
    }
    cont++;
}