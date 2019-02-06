# Dokumentacja WseiToDoList
Aplikacja okienkowa do przeglądania zadań, stworzona przez Macieja Romanowskiego na potrzeby projektu semestralnego do zaliczenai przedmiotu "Programowanie Obiektowe C#" na uczelni [WSEI](https://www.wsei.edu.pl/).

# Użyte pakiety zewnętrzne

  - Entity Framework 6
  - System.Data.SQLite
  - System.Data.SQLite.Core
  - System.Data.SQLite.EF6
  - System.Data.SQLite.Linq


## Aspekty Techniczne

### Aplikacja okienkowa

  - Aplikacja pokazuje zadania
  - Widać cztery przyciski Add, Edit, Delete, Change Status
  - Jest jedne CheckBox do zmieniania wyświetlania zadań

### Biblioteka



### Baza

Do projektu jest dodana baza danych typu SQLite "ToDoListDB.db", która przechowuje zadania i ich stan. Baza posiada jedną tabele.

  - Tasks
  
Do połączenia się z bazą została użyta biblioteka "Entity Framework 6".
