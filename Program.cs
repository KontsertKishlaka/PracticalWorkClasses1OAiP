namespace PracticalWorkClasses1OAiP;

public class Program
{
    public static void Main(string[] args)
    {
        Car car = new("Лада", 2008);
        car.DisplayInfo();

        Book book = new("Пикник на обочине", "Стругацкие");
        book.DisplayInfo();

        Rectangle rectangle = new(2, 5);
        rectangle.DisplayArea();
    }
}

public class Car
{
    public string? Make;
    public int Year;

    public Car(string? make, int year)
    {
        Make = make;
        Year = year;
    }

    public void DisplayInfo() => Console.WriteLine(
        $"Марка машины: {Make}\n" +
        $"Год выкуска: {Year}\n\n");
}

public class Book
{
    private string? _title;
    private string? _author;

    public string? Title => _title;
    public string? Author => _author; 

    public Book(string? title, string? author)
    {
        _title = title;
        _author = author;
    }

    public void DisplayInfo() => Console.WriteLine(
        $"Название книги: {_title}\n" +
        $"Автор: {_author}\n\n");
}

public class Rectangle()
{
    private float _width;
    private float _height;

    public Rectangle(float width, float height) : this()
    {
        Width = width;
        Height = height;
    }

    public float Width
    {
        get => _width;
        set => _width = value <= .0f ? 1f : value;
    }

    public float Height
    {
        get => _height;
        set => _height = value <= .0f ? 1f : value;
    }

    public void DisplayArea()
    {
        Console.WriteLine($"Площадь прямоугольника: {_width * _height}");
    }
}