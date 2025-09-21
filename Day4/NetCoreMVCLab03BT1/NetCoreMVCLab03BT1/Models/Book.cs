namespace NetCoreMVCLab03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Summary { get; set; }

        // Danh sách sách
        public static List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Chi Phố",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/products/b1.jpg",
                    Price = 50000,
                    TotalPage = 250,
                    Summary = ""
                },
                new Book()
                {
                    Id = 2,
                    Title = "",
                    AuthorId = 0,
                    GenreId = 0,
                    Image = "",
                    Price = 0,
                    TotalPage = 0,
                    Summary = ""
                }
            };
            return books;
        }

        // Lấy sách theo ID
        public static Book GetBookById(int id)
        {
            Book book = GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }
    }
}