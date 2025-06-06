int numeroDigitado;
int numeroExibido = 0;

Console.Write("-- Números pares entre 0 e ? ");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

while (numeroExibido <= numeroDigitado)
{
    Console.Write($"{numeroExibido} ");
    numeroExibido += 2;
}

Console.WriteLine("\n\nPressione uma tecla para finalizar...");
Console.ReadKey(true);