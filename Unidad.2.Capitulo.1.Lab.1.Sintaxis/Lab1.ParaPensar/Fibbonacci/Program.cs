using System.Data;

int[] fibonacci;
fibonacci = new int[6];

fibonacci[0] = 0; fibonacci[1] = 1;
int i = 0;
int j = 1;

for (int k = 2; k < 6; k++, i++, j++)
{
    fibonacci[k] = fibonacci[j] + fibonacci[i];
}

foreach (int nro in fibonacci) Console.WriteLine(nro);