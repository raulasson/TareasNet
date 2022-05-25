int[,] carton = new int[3, 9];
Random num = new Random();
int aux;
int bandera = 0;
int control = 0;
int repetido = 0;
for (int i = 0; i < 3; i++)
{
    bandera = 0;
    for (int j = 0; j < 9; j++)
    {
        control = 0;
        repetido = 0;
        if (i == 2 && carton[i-1,j]!=0 && carton[i-2,j]!=0)
        {
            control = 1;
        }
        aux = num.Next(2);
        if (aux==0 && control!=1 && bandera<5)
        {
            switch (j)
            {
                case 0:
                    aux = num.Next(10);
                    if (i==2 && (aux == carton[i - 1, j] || aux == carton[i - 2, j]))
                    {
                        while (repetido==0)
                        {
                            aux = num.Next(10);
                            if (aux != carton[i - 1, j] && aux != carton[i - 2, j])
                            {
                                repetido++;
                                carton[i,j] = aux;
                            }
                        }
                        
                        bandera++;
                    }
                    if (i == 1 && aux == carton[i - 1, j])
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(10);
                            if (aux != carton[i - 1, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (repetido==0)
                    {
                        carton[i, j] = num.Next(10);
                        bandera++;
                    }
                    break;
                case 1:
                    aux = num.Next(11,20);
                    if (i == 2 && (aux == carton[i - 1, j] || aux == carton[i - 2, j]))
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(11,20);
                            if (aux != carton[i - 1, j] && aux != carton[i - 2, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (i == 1 && aux == carton[i - 1, j])
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(11,20);
                            if (aux != carton[i - 1, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (repetido == 0)
                    {
                        carton[i, j] = num.Next(11,20);
                        bandera++;
                    }
                    break;
                case 2:
                    aux = num.Next(21,30);
                    if (i == 2 && (aux == carton[i - 1, j] || aux == carton[i - 2, j]))
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(21,30);
                            if (aux != carton[i - 1, j] && aux != carton[i - 2, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (i == 1 && aux == carton[i - 1, j])
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(21,30);
                            if (aux != carton[i - 1, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (repetido == 0)
                    {
                        carton[i, j] = num.Next(21,30);
                        bandera++;
                    }
                    break;
                case 3:
                    aux = num.Next(31,40);
                    if (i == 2 && (aux == carton[i - 1, j] || aux == carton[i - 2, j]))
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(31,40);
                            if (aux != carton[i - 1, j] && aux != carton[i - 2, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (i == 1 && aux == carton[i - 1, j])
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(31,40);
                            if (aux != carton[i - 1, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (repetido == 0)
                    {
                        carton[i, j] = num.Next(31,40);
                        bandera++;
                    }
                    break;
                case 4:
                    aux = num.Next(41,50);
                    if (i == 2 && (aux == carton[i - 1, j] || aux == carton[i - 2, j]))
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(41,50);
                            if (aux != carton[i - 1, j] && aux != carton[i - 2, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (i == 1 && aux == carton[i - 1, j])
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(41,50);
                            if (aux != carton[i - 1, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (repetido == 0)
                    {
                        carton[i, j] = num.Next(41,50);
                        bandera++;
                    }
                    break;
                case 5:
                    aux = num.Next(51,60);
                    if (i == 2 && (aux == carton[i - 1, j] || aux == carton[i - 2, j]))
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(51,60);
                            if (aux != carton[i - 1, j] && aux != carton[i - 2, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (i == 1 && aux == carton[i - 1, j])
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(51,60);
                            if (aux != carton[i - 1, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (repetido == 0)
                    {
                        carton[i, j] = num.Next(51,60);
                        bandera++;
                    }
                    break;
                case 6:
                    aux = num.Next(61,70);
                    if (i == 2 && (aux == carton[i - 1, j] || aux == carton[i - 2, j]))
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(61,70);
                            if (aux != carton[i - 1, j] && aux != carton[i - 2, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (i == 1 && aux == carton[i - 1, j])
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(61,70);
                            if (aux != carton[i - 1, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (repetido == 0)
                    {
                        carton[i, j] = num.Next(61,70);
                        bandera++;
                    }
                    break;
                case 7:
                    aux = num.Next(71,80);
                    if (i == 2 && (aux == carton[i - 1, j] || aux == carton[i - 2, j]))
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(71,80);
                            if (aux != carton[i - 1, j] && aux != carton[i - 2, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (i == 1 && aux == carton[i - 1, j])
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(71,80);
                            if (aux != carton[i - 1, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (repetido == 0)
                    {
                        carton[i, j] = num.Next(71,80);
                        bandera++;
                    }
                    break;
                case 8:
                    aux = num.Next(81,90);
                    if (i == 2 && (aux == carton[i - 1, j] || aux == carton[i - 2, j]))
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(81,90);
                            if (aux != carton[i - 1, j] && aux != carton[i - 2, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (i == 1 && aux == carton[i - 1, j])
                    {
                        while (repetido == 0)
                        {
                            aux = num.Next(81,90);
                            if (aux != carton[i - 1, j])
                            {
                                repetido++;
                                carton[i, j] = aux;
                            }
                        }

                        bandera++;
                    }
                    if (repetido == 0)
                    {
                        carton[i, j] = num.Next(81,90);
                        bandera++;
                    }
                    break;
            }
        }
        if (j==8 && bandera<5)
        {
            j = -1;
            bandera = 0;
            for (int k = 0; k < 9; k++)
            {
                carton[i, k] = 0;
            }
        }
        if (bandera==5)
        {
            break;
        }
    }
}
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write(carton[i,j] + "   ");
    }
    Console.WriteLine();
}