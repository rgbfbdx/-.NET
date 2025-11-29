using System;

class Book : IDisposable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int Pages { get; set; }

    public Book(string title, string author, int year, int pages)
    {
        Title = title;
        Author = author;
        Year = year;
        Pages = pages;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Назва: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Рік видання: {Year}");
        Console.WriteLine($"Сторінок: {Pages}");
    }

    public void Dispose()
    {
        Console.WriteLine($"Dispose викликано для книги: {Title}");
        GC.SuppressFinalize(this);
    }

    ~Book()
    {
        Console.WriteLine($"Фіналізатор викликано для книги: {Title}");
    }
}
