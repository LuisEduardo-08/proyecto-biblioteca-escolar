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
    
        public int Disponibles()
    {
        int contador = 0;

        for (int i = 0; i < Ejemplares.Length; i++)
        {
            if (Ejemplares[i] == true)
            {
                contador++;
            }
        }

        return contador;
    }

   public void Prestar()
    {
        for (int i = 0; i < Ejemplares.Length; i++)
        {
            if (Ejemplares[i] == true)
            {
                Ejemplares[i] = false;
                Prestamos++;
                return;
            }
        }

        Console.WriteLine("No hay copias disponibles de " + Nombre);
    }
}


