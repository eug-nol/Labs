Console.Write("Ingrese la cantidad de números primos gemelos (nro par): ");
int N = Int32.Parse(Console.ReadLine());

int nro = 2;
int gemelo = 0;
int divisor = 1;
int a = 0;

int[] nrosPrimosGemelos = new int[N];


while (a < N) 
{
    // probar si tiene mas de dos divisores
    for (divisor = 2; divisor < nro; divisor++)
    {
        if (nro % divisor  == 0)
        {
            divisor = nro+1;
        }
    }

    //si tiene solo dos divisores, entonces es un numero primo
    if (divisor == nro)
    {
        // tiene gemelo?
        gemelo = nro + 2;
        for (divisor=2; divisor < gemelo; divisor++)
        {
            if (gemelo % divisor == 0)
            {
                divisor = gemelo + 1;
            }
        }

        // es gemelo, por lo que lo agregamos al arreglo
        if (divisor == gemelo)
        {
            nrosPrimosGemelos[a] = nro;
            nrosPrimosGemelos[a + 1] = gemelo;
            // preparamos la sigueinte posicion para ubicar al siguiente par
            a = a+2;
        }

        // si no es gemelo, no se agrega nada, e i sigue aumentando hasta que a llegue a N
    }

    nro++;
}

foreach (int n in nrosPrimosGemelos) {
    Console.WriteLine(n);
}