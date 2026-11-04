List<Titulo> libros = new List<Titulo>();

libros.Add(new Titulo("Blancanieves", 2508071141804, 3, 25));
libros.Add(new Titulo("Caperucita Roja", 2508077140122, 2, 18));
libros.Add(new Titulo("El patito feo", 2508077164968, 2, 12));
libros.Add(new Titulo("El principito", 2508072952911, 5, 31));
libros.Add(new Titulo("Hansel y Gretel", 2508077564065, 1, 18));
libros.Add(new Titulo("Los tres cerditos", 2508078875955, 4, 25));
libros.Add(new Titulo("Mulan", 2508077354444, 1, 7));
libros.Add(new Titulo("Pinocho", 2508078096107, 2, 4));

Console.WriteLine("Libros en la biblioteca: " + libros.Count);
Console.WriteLine();

foreach (Titulo libro in libros)
{
    Console.WriteLine(libro.Nombre + "  copias: " + libro.Ejemplares.Length);
}
libros[2].Prestar();
libros[3].Prestar();
libros[6].Prestar();

Console.WriteLine();
Console.WriteLine("Prueba de préstamos:");

foreach (Titulo libro in libros)
{
    Console.WriteLine(libro.Nombre + "  Disponibles: " + libro.Disponibles() + "  Préstamos: " + libro.Prestamos);
}

OrdenarPorPrestamos(libros);

Console.WriteLine();
Console.WriteLine("Catálogo ordenado por préstamos:");

foreach (Titulo libro in libros)
{
    Console.WriteLine(libro.Nombre + "  Préstamos: " + libro.Prestamos);
}

Console.WriteLine();
Console.WriteLine("Libros con los mismos préstamos:");

for (int i = 0; i < libros.Count - 1; i++)
{
    if (libros[i].Prestamos == libros[i + 1].Prestamos)
    {
        Console.WriteLine(libros[i].Nombre + " va antes que " + libros[i + 1].Nombre + " (" + libros[i].Prestamos + " préstamos)");
    }
}

List<Titulo> porIsbn = new List<Titulo>(libros);

for (int i = 1; i < porIsbn.Count; i++)
{
    Titulo actual = porIsbn[i];
    int j = i - 1;

    while (j >= 0 && porIsbn[j].Isbn > actual.Isbn)
    {
        porIsbn[j + 1] = porIsbn[j];
        j--;
    }

    porIsbn[j + 1] = actual;
}

Console.WriteLine();
Console.WriteLine("Búsqueda por ISBN:");

long[] isbns = { 2508077564065, 2508070000000 };

foreach (long isbn in isbns)
{
    int posicion = BuscarPorIsbn(porIsbn, isbn);

    if (posicion == -1)
    {
        Console.WriteLine(isbn + "  No existe ningún libro con ese ISBN");
    }
    else
    {
        Console.WriteLine(isbn + " - " + porIsbn[posicion].Nombre + "  Disponibles: " + porIsbn[posicion].Disponibles());
    }
}

Console.WriteLine();
Console.WriteLine("Búsqueda por título:");

string[] nombres = { "Mulan", "Peter Pan" };

foreach (string nombre in nombres)
{
    int posicion = BuscarPorTitulo(libros, nombre);

    if (posicion == -1)
    {
        Console.WriteLine(nombre + "  No existe ningún libro con ese título");
    }
    else
    {
        Console.WriteLine(nombre + "  Disponibles: " + libros[posicion].Disponibles());
    }
}

Console.WriteLine();
Console.WriteLine("Catálogo antes de los préstamos:");

foreach (Titulo libro in libros)
{
    Console.WriteLine(libro.Nombre + "  Disponibles: " + libro.Disponibles() + "  Préstamos: " + libro.Prestamos);
}

Console.WriteLine();
Console.WriteLine("Préstamos registrados:");

long[] nuevosPrestamos = { 2508078875955, 2508077564065, 2508078096107 };

foreach (long isbn in nuevosPrestamos)
{
    int posicion = BuscarPorIsbn(porIsbn, isbn);

    if (posicion == -1)
    {
        Console.WriteLine(isbn + "  No existe ningún libro con ese ISBN");
    }
    else
    {
        porIsbn[posicion].Prestar();
        Console.WriteLine(porIsbn[posicion].Nombre + "  Disponibles: " + porIsbn[posicion].Disponibles() + "  Préstamos: " + porIsbn[posicion].Prestamos);
    }
}

OrdenarPorPrestamos(libros);

Console.WriteLine();
Console.WriteLine("Catálogo después de los préstamos:");

foreach (Titulo libro in libros)
{
    Console.WriteLine(libro.Nombre + "  Disponibles: " + libro.Disponibles() + "  Préstamos: " + libro.Prestamos);
}

int BuscarPorIsbn(List<Titulo> lista, long isbn)
{
    int inicio = 0;
    int fin = lista.Count - 1;

    while (inicio <= fin)
    {
        int medio = (inicio + fin) / 2;

        if (lista[medio].Isbn == isbn)
        {
            return medio;
        }
        else if (lista[medio].Isbn < isbn)
        {
            inicio = medio + 1;
        }
        else
        {
            fin = medio - 1;
        }
    }

    return -1;
}

int BuscarPorTitulo(List<Titulo> lista, string nombre)
{
    for (int i = 0; i < lista.Count; i++)
    {
        if (lista[i].Nombre == nombre)
        {
            return i;
        }
    }

    return -1;
}

void OrdenarPorPrestamos(List<Titulo> lista)
{
    for (int i = 1; i < lista.Count; i++)
    {
        Titulo actual = lista[i];
        int j = i - 1;

        while (j >= 0 && lista[j].Prestamos < actual.Prestamos)
        {
            lista[j + 1] = lista[j];
            j--;
        }

        lista[j + 1] = actual;
    }
}