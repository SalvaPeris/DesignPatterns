using Strategy;
using Strategy.Interfaces;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("This is a Strategy design pattern demo: \n");

        ICompression strategy = new ZipCompression();

        CompressionContext ctx = new CompressionContext(strategy);
        ctx.CreateArchive("DotNetDesignPattern");

        ctx.SetStrategy(new RarCompression());
        ctx.CreateArchive("DotNetDesignPattern");

        Console.Read();
    }
}