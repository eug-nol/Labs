Console.Write("Ingrese cantidad de filas: ");
int ultimoRenglon = Int32.Parse(Console.ReadLine());
int renglon = 1;
int cantEstrellas = 1;
string estrellas = "*";

Console.Write(estrellas);

while (renglon <= ultimoRenglon)
{
    for (int k = 1; k < cantEstrellas; k = +2)
    {
        estrellas = estrellas + "*";
        Console.Write(estrellas);
    }
    Console.Write("\n");
    cantEstrellas = +2;
    renglon++;
}