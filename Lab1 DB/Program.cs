namespace Lab1_DB
{
    class Program
    {
        static void Main()
        {
            Book[] books = new Book[3] { 
                new Book(1, "Чак Паланик", "Бойцовский клуб", 1996, 3, 2), 
                new Book(2, "Эрих Фромм", "Искусство любить", 1956 , 1, 3),
                new Book(3, "Хосе Ортега-и-Гассет", "Восстание масс", 1930, 1, 2)};
            Reader[] readers = new Reader[3]
            {
                new Reader(1, "Белов Василий Иванович", 122, new Dictionary<int, DateTime> { { 1, DateTime.Parse("2022/11/12") }, { 2, DateTime.Parse("2022/10/28") } }, 
                                                            new Dictionary<int, DateTime> { { 1, DateTime.Parse("2022/11/30") }, { 2, DateTime.Parse("2022/11/10") } }),
                new Reader(2, "Малькова Оля Олеговна", 102, new Dictionary<int, DateTime> { { 2, DateTime.Parse("2022/12/09") }, { 3, DateTime.Parse("2022/12/20") } },
                                                            new Dictionary<int, DateTime> { { 2, DateTime.Parse("2022/11/20") }, { 3, DateTime.Parse("2022/12/10") } }),
                new Reader(3, "Копылов Иван Фёдорович", 115, new Dictionary<int, DateTime> { { 1, DateTime.Parse("2022/09/13") }, { 3, DateTime.Parse("2022/10/27") } },
                                                            new Dictionary<int, DateTime> { { 1, DateTime.Parse("2020/10/20") }, { 3, DateTime.Parse("2020/12/10") } })
            };
            //Book[] books = LoadData.ReadBooks("books.csv");
            //Reader[] readers = LoadData.ReadReaders("readers.csv", "readerBooks.csv");
            //foreach (Reader reader in readers)
            //{
            //    Console.WriteLine(reader.ToString(books[1]));
            //    Console.WriteLine();
            //}
            Console.WriteLine(Reader.ToString(readers, books[2]));
        }
    }
}