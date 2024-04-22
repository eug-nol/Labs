int[] numeros;
numeros = new int[101];

int[] pares;
pares = new int[52];

int k = 0;

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = i;
    if (numeros[i] % 2 == 0)
    {
        pares[k] = i;
        k++;
    }
}

foreach (int par in pares)
{
    Console.WriteLine(par);
}