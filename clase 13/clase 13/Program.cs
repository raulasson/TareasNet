using clase_13.modelo;
decimal total;
billetera billetera1 = new billetera();
billetera billetera2 = new billetera();

billetera1.BilletesDe10 = 3;
billetera1.BilletesDe20 = 1;
billetera1.BilletesDe50 = 1;
billetera1.BilletesDe100 = 3;
billetera1.BilletesDe200 = 1;
billetera1.BilletesDe500 = 1;
billetera1.BilletesDe1000 = 3;

billetera2.BilletesDe10 = 5;
billetera2.BilletesDe20 = 7;
billetera2.BilletesDe50 = 1;
billetera2.BilletesDe100 = 3;
billetera2.BilletesDe200 = 5;
billetera2.BilletesDe500 = 2;
billetera2.BilletesDe1000 = 3;

total = billetera1.Total();
Console.WriteLine($"El total de la billetera1 es : ${total}\n\n");

total = billetera2.Total();
Console.WriteLine($"El total de la billetera2 es : ${total}\n\n");

Console.WriteLine("Ahora combinamos las billeteras!! \n\n");

billetera billeteracomb = billetera1.Combinar(billetera2);
Console.WriteLine($"Billetera1: {billetera1.Total()}");
Console.WriteLine($"Billetera2: {billetera2.Total()}");
Console.WriteLine($"Billetera combinada: {billeteracomb.Total()}");

Console.WriteLine($"\n\nLos billetes de la billetera combinada son:\n");
billeteracomb.MostrarBilletes();






