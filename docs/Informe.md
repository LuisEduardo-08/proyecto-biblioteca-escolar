# Informe

Proyecto Biblioteca Escolar

Alumno: Luis Eduardo Mendoza Romero

Grupo: 501

## Qué hace el programa

El programa guarda 8 libros de una biblioteca y cada libro tiene diferente número de copias. Se pueden prestar libros, ver cuántas copias quedan, ordenar los libros por préstamos y buscar un libro por ISBN o por título.

## Estructura

Usé `List<Titulo>`. Cada libro guarda su nombre, su ISBN, sus préstamos y un arreglo `bool[]` con sus copias (true es disponible y false es prestado). El arreglo mide lo mismo que las copias del libro, así no quedan espacios vacíos.

## Ordenamiento y búsquedas

- El ordenamiento es por inserción, de más préstamos a menos.
- La búsqueda por ISBN es binaria y se hace en una copia de la lista ordenada por ISBN.
- La búsqueda por título es secuencial, revisa los libros uno por uno.
- Si no encuentra el libro regresa -1 y muestra un mensaje.

## Comparaciones

Busqué 5 ISBN con mi búsqueda binaria y con Array.BinarySearch para comparar.

| ISBN | Libro | Mi búsqueda | Array.BinarySearch |
|---|---|---|---|
| 2508077164968 | El patito feo | 1 | 1 |
| 2508077564065 | Hansel y Gretel | 2 | 2 |
| 2508078096107 | Pinocho | 3 | 3 |
| 2508078875955 | Los tres cerditos | 4 | 4 |
| 2508070000000 | No existe | 3 | 3 |

Las dos hacen las mismas comparaciones y dan el mismo resultado.

## Preguntas

**¿Qué habría pasado si cada título tuviera exactamente cinco ejemplares?**

Todos los libros ocuparían el mismo espacio y se podría usar una tabla normal sin que sobre nada. Pero mis libros no tienen las mismas copias (unos tienen 5 y otros solo 1), por eso usé una lista donde cada libro ocupa solo sus copias.

**¿El ordenamiento preserva el orden alfabético en los empates?**

Sí, porque uso < y si dos libros tienen los mismos préstamos no se mueven. Blancanieves quedó antes que Los tres cerditos y Caperucita Roja antes que Hansel y Gretel.

**¿Por qué la búsqueda binaria exige ordenar por ISBN y no por préstamos?**

Porque compara con el libro de en medio y se va a la izquierda o a la derecha según el ISBN. Si la lista está ordenada por préstamos los ISBN están revueltos y no lo encontraría.

**¿Cómo se ve la evolución en los commits?**

Hice un commit por día y en cada uno se ve lo que agregué.

## Conclusión

El programa hace lo que pide el proyecto: guarda libros con distintas copias sin espacios vacíos, registra préstamos, ordena el catálogo y busca libros.