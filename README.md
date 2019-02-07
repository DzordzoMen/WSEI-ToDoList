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
  - Jest jeden CheckBox do zmieniany wyświetlania zadań

#### Opis aplikacji okienkowej:

##### Frontend:

- `DataGrid`
    - Miejsce do wyświetlenia zadań pobranych z bazy
    - Używa metody `DataGridOnStart`
- `NewTaskField`
    - Pole do wpisywania nazyw nowego zadania 
- `AddBtn`
    - Przycisk do dodawania nowych zadań
    - Używa metody `AddTask`
- `ShowAllChekcBox`
    - CheckBox do zmiany wyświetlania zadań (jeżeli jest zaznaczony to pokazuje wszystkie zadania, jeżeli jest odznaczony to pokazuje tylko te niewykonane)
    - Używa metody `DisplayChange`
- `EditBtn`
    - Przycisk do zmiany nazwy zadania
    - Używa metody `EditTask`
- `ChangeStatusBtn`
    -  Przycisk do zmiany nazwy danego zadania, po zmianie już wykonanego wcześniej zadania, ustawia jego status na "niewykonany"
    -  Używa metody `EditTask`
- `DeleteBtn`
    - Przycisk do usunięcia wybranego zadania
    - Używa metody `DeleteTask`

##### Backend:

###### Pola:

- `_toDoList` - obiekt klasy `ToDoList` do używania metod bilioteki.
- `_showAll` - status wyświetlania zadań | bool

###### Metody:

- `GetRecords`
    - Sprawdza status `_showAll` i na podstawie jego używa jednej z metod
    - Używa metod `GetTasks` lub `GetNotFinishedTasks` z biblioteki `ToDoList`
- `DataGridOnStart`
    - Wywołuje metodę `GetRecords` na początku uruchomienia aplikacji 
- `AddTask`
    -  Pobiera nazwę z `NewTaskField` i używa metody `AddTask` z biblioteki `ToDoList`, po czym odświeża listę
    -  Używa metod `AddTask` z biblioteki `ToDoList` i `GetRecords`
- `EditTask`
    - Pobiera nową nazwę z aktualnie wybranego zadania i używa metody `EditTask`z biblioteki `ToDoList`, po czym odświeża listę
    - Używa metod `EditTask` z biblioteki `ToDoList` i `GetRecords`
- `DeleteTask`
    - Pobiera inforamcję o wybranym zadaniu i używa metody `DeleteTask` z biblioteki `ToDoList`, po czym odświeża listę
    - Używa metod `DeleteTask` z biblioteki `ToDoList` i `GetRecords`
- `ChangeTaskStatus`
    - Pobiera informację o wybranym zadaniu i używa metody `ChangeStatus` z biblioteki `ToDoList`, po czym odświeża listę 
    - Używa metod `ChangeStatus` z biblioteki `ToDoList` i `GetRecords`
- `DisplayChange`
    - Zmienia aktualny stan pola `_showAll` na przeciwny i wywołuje metodę `GetRecords`
    - Użyta metody `GetRecords`

### Biblioteka - główna logika
Główna logika została umieszczona w klasie `ToDoList` i `toDoListConnectionString` do połączenia z bazą SQLite i gdzie znajduje się model `Tasks`.

## Opis Klas

##### Klasa `ToDoList`
###### Pola:
- `_context` - obiekt klasy `toDoListConnectionString` do połączenia się z bazą.
###### Metody:
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
###### Metody:
- `ConnectionStringToDatabase`
    - Pobiera aktualną ścieżkę do projektu i tworzy odpowiedni string do połączenia z bazą 
- `OnModelCreating`
    - Definiuje dla Entity Framework'a jak powinien rozumieć podane Typy w Modelu

##### Model `Tasks`
Odpowiada za poprawne przekazywanie danych do bazy i reprezenuje tabele `tasks` z bazy.
Pola:
- Id
    - Primary Key | Auto Increment | BIGINT
- Name
    - TEXT
- Check
    - BIGINT | DEFAULT "0"


### Baza

Do projektu jest dodana baza danych typu SQLite `ToDoListDB.db`, która przechowuje zadania i ich stan. Baza posiada jedną tabele.

  - Tasks
  
Do połączenia się z bazą została użyta biblioteka "Entity Framework 6".
