# Diseño preliminar

## Problema

No todos los libros tienen el mismo número de ejemplares (por ejemplo, El principito tiene 5 y Mulan 1). Hay que guardarlos sin dejar espacios vacíos.

## Opción 1: Arreglo escalonado

Un arreglo de arreglos donde cada fila tiene su propio tamaño.

- Pro: no deja espacios vacíos.
- Contra: el nombre, el ISBN y los préstamos van en otros arreglos, y al ordenar hay que moverlos todos.

## Opción 2: `List<int[]>`

Una lista donde cada libro tiene un arreglo con sus ejemplares.

- Pro: no deja espacios vacíos y se pueden agregar libros.
- Contra: los demás datos del libro también van separados.

## Opción 3: `List<Titulo>`

Una lista de objetos. Cada `Titulo` guarda su nombre, ISBN, préstamos y su arreglo de ejemplares.

- Pro: todos los datos del libro están juntos y no deja espacios vacíos.
- Contra: hay que crear una clase.

## Decisión

Elegí `List<Titulo>` porque así es más fácil ordenar y buscar sin que se revuelvan los datos.