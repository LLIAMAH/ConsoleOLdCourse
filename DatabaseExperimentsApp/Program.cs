using DatabaseExperimentsLib;
using DatabaseExperimentsLib.Entities;
using Microsoft.EntityFrameworkCore;

var ctx = new AppDbCtx();

var authors = await ctx.Authors
    .Include(o => o.AuthorBooks)
    .ToListAsync();

var book = await ctx.Books
    .Include(o => o.BookType)
    .Include(o => o.Publisher)
    .Include(o => o.Author)
    .ThenInclude(o => o.AuthorBooks)
    .FirstOrDefaultAsync(o => o.Title.Equals("Тёмный Охотник"));

foreach (var author in book.Author)
{
    Console.WriteLine($"Author name: {author.FullName}");
    foreach (var authorAuthorBook in author.AuthorBooks)
    {
        Console.WriteLine($"{authorAuthorBook.Title}; {authorAuthorBook.BookType.Name}; {authorAuthorBook.Publisher.Name}; {GetAuthors(authorAuthorBook.Author)}");
    }

    Console.WriteLine("=====================================");
}


//await AddNewAuthors();

//await NewMultipleAuthorBooks();

//foreach (var book in (await ctx.Books
//             .Include(o => o.BookType)
//             .Include(o => o.Publisher)
//             .Include(o => o.Author).ToListAsync()))
//{
//    Console.WriteLine($"{book.Title}; {book.BookType.Name}; {book.Publisher.Name}; {GetAuthors(book.Author)}");
//}

Console.Write("Write some value to exit: ");
var t = Console.ReadLine();

string GetAuthors(ICollection<Author> bookAuthor)
{
    var fullNames = bookAuthor.Select(o => o.FullName).ToList();
    return string.Join(", ", fullNames);
}

async Task NewMultipleAuthorBooks()
{
    //var bookType = await ctx.BookTypes.FirstOrDefaultAsync(o => o.Name.Equals("Фентази"));
    //var publisher = await ctx.Publishers.FirstOrDefaultAsync(o => o.Name.Equals("ACT"));
    var authors = await ctx.Authors.Where(o => 
        o.LastName.Equals("Турчанинова") || 
        o.LastName.Equals("Бычкова") || 
        o.LastName.Equals("Пехов")).ToListAsync();

    var books = new List<Book>()
    {
        new Book() { Title = "Тёмный Охотник", Author = authors, PublisherId = 1, BookTypeId = 1, Year = 2006 },
        new Book() { Title = "Ночь летнего солнцестояния", Author = authors, PublisherId = 1, BookTypeId = 1, Year = 2007 },
        new Book() { Title = "Немного покоя во время чумы", Author = authors, PublisherId = 1, BookTypeId = 1, Year = 2009 },
        new Book() { Title = "Киндрэт. Кровные братья", Author = authors, PublisherId = 1, BookTypeId = 1, Year = 2005 },
        new Book() { Title = "Колдун из клана Смерти", Author = authors, PublisherId = 1, BookTypeId = 1, Year = 2005 },
        new Book() { Title = "Основатель", Author = authors, PublisherId = 1, BookTypeId = 1, Year = 2009 },
        new Book() { Title = "Новые боги", Author = authors, PublisherId = 1, BookTypeId = 1, Year = 2010 }
    };

    await ctx.AddRangeAsync(books);
    await ctx.SaveChangesAsync();
}

async Task AddNewAuthors()
{
    var authors = new List<Author>()
    {
        new Author() { FirstName = "Елена", LastName = "Бычкова" },
        new Author() { FirstName = "Наталья", LastName = "Турчанинова" },
    };

    await ctx.AddRangeAsync(authors);
    await ctx.SaveChangesAsync();
}

async Task AddNewBooksAndAuthors()
{
    var bookType = await ctx.BookTypes.FirstOrDefaultAsync(o => o.Name.Equals("Фентази"));
    var publisher = await ctx.Publishers.FirstOrDefaultAsync(o => o.Name.Equals("ACT"));

    var authors = new List<Author>()
    {
        new Author()
        {
            FirstName = "Алексей", LastName = "Пехов",
        },
        new Author()
        {
            FirstName = "Андрей", LastName = "Земляной",
        }
    };

    var books = new List<Book>()
    {
        new Book() { BookType = bookType, Publisher = publisher, Title = "Крадущийся в тени", Author =new List<Author>()
        {
            authors.First(o=>o.FirstName.Equals("Алексей") && o.LastName.Equals("Пехов"))
        }},
        new Book() { BookType = bookType, Publisher = publisher, Title = "Джанго с тенями" , Author =new List<Author>()
        {
            authors.First(o=>o.FirstName.Equals("Алексей") && o.LastName.Equals("Пехов"))
        }},
        new Book() { BookType = bookType, Publisher = publisher, Title = "Один на миллион" , Author =new List<Author>()
        {
            authors.First(o=>o.FirstName.Equals("Андрей") && o.LastName.Equals("Земляной"))
        }},
        new Book() { BookType = bookType, Publisher = publisher, Title = "Шагнуть за горизонт" , Author =new List<Author>()
        {
            authors.First(o=>o.FirstName.Equals("Андрей") && o.LastName.Equals("Земляной"))
        }},
        new Book() { BookType = bookType, Publisher = publisher, Title = "Игра без правил" , Author =new List<Author>()
        {
            authors.First(o=>o.FirstName.Equals("Андрей") && o.LastName.Equals("Земляной"))
        }}
    };

    await ctx.AddRangeAsync(books);
    await ctx.SaveChangesAsync();
}


async Task AddSomeData()
{
    var author2 = await ctx.Authors
        .Select(o => new { FullName = $"{o.FirstName} {o.LastName}" })
        .FirstOrDefaultAsync();

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
            Title = "Ведьмак 1", Author = new List<Author>() { author }, BookTypeId = bookType.Id,
            PublisherId = publisher.Id,
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
            Title = "Ведьмак 4", Author = new List<Author>() { author }, BookType = bookType, Publisher = publisher,
            Year = 1997
        },
        new Book()
        {
            Title = "Ведьмак 5", Author = new List<Author>() { author }, BookType = bookType, Publisher = publisher,
            Year = 1998
        },
        new Book()
        {
            Title = "Ведьмак 6", Author = new List<Author>() { author }, BookType = bookType, Publisher = publisher,
            Year = 1999
        },
        new Book()
        {
            Title = "Ведьмак 7", Author = new List<Author>() { author }, BookType = bookType, Publisher = publisher,
            Year = 2000
        },
        new Book()
        {
            Title = "Ведьмак 8", Author = new List<Author>() { author }, BookType = bookType, Publisher = publisher,
            Year = 2001
        }
    };

    await ctx.AddRangeAsync(list); // << ==========
    await ctx.SaveChangesAsync();
}