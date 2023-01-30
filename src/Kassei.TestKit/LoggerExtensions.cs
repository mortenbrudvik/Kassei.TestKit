namespace Kassei.TestKit;

public static class LoggerExtensions
{
    public static IEnumerable<T> Log<T>(this IEnumerable<T> source)
    {
        var elements = source.ToList();
        foreach (var element in elements)
        {
            XunitContext.WriteLine("" + element);
        }
        return elements;
    }
}