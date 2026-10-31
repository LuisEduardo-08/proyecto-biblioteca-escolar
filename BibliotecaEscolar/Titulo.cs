class Titulo
{
    public string Nombre;
    public long Isbn;
    public int Prestamos;
    public bool[] Ejemplares;   // true = disponible, false = prestado

    public Titulo(string nombre, long isbn, int cantidad, int prestamos)
    {
        Nombre = nombre;
        Isbn = isbn;
        Prestamos = prestamos;

        Ejemplares = new bool[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Ejemplares[i] = true;
        }
    }
}