namespace Kassei.TestKit;

public static class LoggerExtensions
{
    public static IEnumerable<T> Log<T>(this IEnumerable<T> source)
    {
        foreach (var element in source)
        {
            XunitContext.WriteLine("" + element);
            yield return element;
        }
    }
}