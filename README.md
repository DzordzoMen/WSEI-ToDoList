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
Projekt jest tworzony w Windows Forms(WinForms).

  - Aplikacja pokazuje zadania
  - Widać cztery przyciski Add, Edit, Delete, Change Status
  - Jest jedne CheckBox do zmieniania wyświetlania zadań

### Biblioteka - główna logika
Główna logika została umieszczona w klasie "ToDoList" i "toDoListConnectionString" do połączenia z bazą SQLite i gdzie znajduje się model "Tasks".

Klasa "ToDoList" tworzy jeden prywatny obiekt do połączenia z bazą "_context".

## Opis Klas

##### Klasa `ToDoList`
- `GetTasks`
    - Zwraca Listę obiektów **Tasks**
- `GetNotFinishedTasks`
    - Zwraca Lisę obiektów **Tasks**, które nie zostały jeszcze skończone
- `ChangeStatus`
    - Przyjmuje obiekt klasy **Tasks**
    - Zmienia status zadania na skończony, lub nieskończony i zwraca odpowiednią wiadomość, jeżeli się uda, bądź nie.
- `AddTask`
    - Przyjmuje obiekt klasy **Tasks**
    - Dodaje kolejne zadanie do bazy, ustawia jego status na niewykonany i zwraca odpowiednią wiadomość, jeżeli się uda, bądź nie.
- `EditTask`
    - Przyjmuje obiekt klasy **Tasks**
    - Sprawdza czy w bazie istnieje taki obiekt, po czym zmienia jego nazwę, ustawia jego status na niewykonany i zwraca odpowiednią wiadomość, jeżeli się uda, bądź nie znajdzie takiego zadania w bazie.
- `DeleteTask`
    - Przyjmuje obiekt klasy **Tasks**
    - Sprawdza czy w bazie istnieje taki obiekt, po czym usuwa go zmiany i zwraca odpowiedni komunikat.
 
##### Klasa `toDoListConnectionString`
- `ConnectionStringToDatabase`
    - Pobiera aktualną ścieżkę do projektu i tworzy odpowiedni string do połączenia z bazą 
- `OnModelCreating`
    - Definiuje dla Entity Framework'a jak powinien rozumieć podane Typy w Modelu

##### Model `Tasks`
Odpowiada za poprawne przekazywanie danych do bazy i reprezenuje tabele `tasks` z bazy.
Pola w bazie:
- Id
    - Primary Key | Auto Increment | BIGINT
- Name
    - TEXT
- Check
    - BIGINT | DEFAULT 0 


### Baza

Do projektu jest dodana baza danych typu SQLite "ToDoListDB.db", która przechowuje zadania i ich stan. Baza posiada jedną tabele.

  - Tasks
  
Do połączenia się z bazą została użyta biblioteka "Entity Framework 6".
