


using ABC_ConsoleApp1;

Box<Book> bookBox = new Box<Book>();
bookBox.list.Add(new Book { Name = "Muhammad Ibn Ali Reza", Price = 5 });


Box<Shirt> shirtBox = new Box<Shirt>();
shirtBox.list.Add(new Shirt { Name = "Summer Shirt", Color = "White" });



List<Book> books = bookBox.GetItems<List<Book>>();
LinkedList<Book> list = bookBox.GetItems<LinkedList<Book>>();

