# Proyecto Integrador 1


# Proyecto Biblioteca Escolar

- Materia: Estructura de datos
- Docente: Roberto Rosario Cruz
- Grupo: 501
- Alumno: Luis Eduardo Mendoza Romero (@LuisEduardo-08)

## Contexto 

Una biblioteca escolar presta libros que no siempre tienen la misma
cantidad de ejemplares: algunos títulos tienen cinco copias, otros una sola. El
bibliotecario necesita saber qué títulos están disponibles, ordenar el catálogo por
cantidad de préstamos históricos y localizar un libro por su código ISBN.

## Objetivos 

Elegir entre arreglo escalonado y `List<T>` para representar títulos con
distinta cantidad de ejemplares; implementar el ordenamiento por inserción para
preservar el orden alfabético entre títulos con igual número de préstamos; aplicar
búsqueda binaria sobre una copia ordenada por ISBN.

## Carpetas

- docs: documentos del proyecto (Diseño preliminar, Prueba de escritorio, Informe y Salida completa)
- BibliotecaEscolar: código del programa

## Cómo correrlo

```
cd proyecto-biblioteca-escolar
dotnet run --project BibliotecaEscolar
```