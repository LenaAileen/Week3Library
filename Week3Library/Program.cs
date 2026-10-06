using Week3Library;

Book firstBook = new Book();
// add new book
Book secondBook = new Book();

// This is info for a book class
firstBook.Title = "C# for beginners";
firstBook.Author = "Heathcliff";
firstBook.ISBN = 4536764;

// call methode
firstBook.DisplayInfo();

secondBook.Title = "Pride and prejudice";
secondBook.Author = "Peader O'Donnell";
secondBook.ISBN = 889899;

secondBook.DisplayInfo();