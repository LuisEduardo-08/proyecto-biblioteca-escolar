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
    Console.WriteLine(libro.Nombre + " - Copias: " + libro.Ejemplares.Length);
}