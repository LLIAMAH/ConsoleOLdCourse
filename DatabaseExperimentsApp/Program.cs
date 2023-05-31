using DatabaseExperimentsLib;
using DatabaseExperimentsLib.Entities;
using Microsoft.EntityFrameworkCore;

var ctx = new AppDbCtx();

//var book = new Book()
//{
//    Title = "Война и мир",
//    Author = new List<Author>()
//    {
//        new Author() { FirstName = "Лев", LastName = "Толстой" }
//    },
//    BookType = new BookType()
//    {
//        Name = "Исторический роман"
//    },
//    Publisher = new Publisher()
//    {
//        Name = "Самиздат"
//    },
//    Year = 1973
//};

var author = await ctx.Authors.Where(o => o.FirstName.Equals("Анджей") && o.LastName.Equals("Сапковский"))
    .FirstOrDefaultAsync();
if (author == null)
{
    author = new Author() { FirstName = "Анджей", LastName = "Сапковский" };
    await ctx.AddAsync(author);
    await ctx.SaveChangesAsync();
}

var bookType = await ctx.BookTypes.FirstOrDefaultAsync(o => o.Name.Equals("Фентази"));
if (bookType == null)
{
    bookType = new BookType() { Name = "Фентази" };
    await ctx.AddAsync(bookType);
    //await ctx.BookTypes.AddAsync(bookType);
    await ctx.SaveChangesAsync();
}

var publisher = await ctx.Publishers.FirstOrDefaultAsync(o => o.Name.Equals("ACT"));
if (publisher == null)
{
    publisher = new Publisher() { Name = "ACT" };
    await ctx.AddAsync(publisher);
    await ctx.SaveChangesAsync();
}

var list = new List<Book>()
{
    new Book()
    {
        Title = "Ведьмак 1", Author = new List<Author>() { author }, BookTypeId = bookType.Id, PublisherId = publisher.Id,
        Year = 1994
    },
    new Book()
    {
        Title = "Ведьмак 2", Author = new List<Author>() { author }, BookType = bookType, Publisher = publisher,
        Year = 1995
    },
    new Book()
    {
        Title = "Ведьмак 3", Author = new List<Author>() { author }, BookType = bookType, Publisher = publisher,
        Year = 1996
    },
    new Book()
    {
        Title = "Ведьмак 4", Author = new List<Author>() { author }, BookType = bookType, Publisher = publisher, Year = 1997
    },
    new Book()
    {
        Title = "Ведьмак 5", Author = new List<Author>() { author }, BookType = bookType, Publisher = publisher, Year = 1998
    },
    new Book()
    {
        Title = "Ведьмак 6", Author = new List<Author>() { author }, BookType = bookType, Publisher = publisher, Year = 1999
    },
    new Book()
    {
        Title = "Ведьмак 7", Author = new List<Author>() { author }, BookType = bookType, Publisher = publisher, Year = 2000
    },
    new Book()
    {
        Title = "Ведьмак 8", Author = new List<Author>() { author }, BookType = bookType, Publisher = publisher, Year = 2001
    }
};

await ctx.AddRangeAsync(list);
await ctx.SaveChangesAsync();

Console.Write("Write some value to exit: ");
var t = Console.ReadLine();
