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
    Console.WriteLine(libro.Nombre + " - copias: " + libro.Ejemplares.Length);
}
libros[2].Prestar();
libros[3].Prestar();
libros[6].Prestar();

Console.WriteLine();
Console.WriteLine("Prueba de préstamos:");

foreach (Titulo libro in libros)
{
    Console.WriteLine(libro.Nombre + " - Disponibles: " + libro.Disponibles() + " - Préstamos: " + libro.Prestamos);
}

for (int i = 1; i < libros.Count; i++)
{
    Titulo actual = libros[i];
    int j = i - 1;

    while (j >= 0 && libros[j].Prestamos < actual.Prestamos)
    {
        libros[j + 1] = libros[j];
        j--;
    }

    libros[j + 1] = actual;
}

Console.WriteLine();
Console.WriteLine("Catálogo ordenado por préstamos:");

foreach (Titulo libro in libros)
{
    Console.WriteLine(libro.Nombre + " - Préstamos: " + libro.Prestamos);
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