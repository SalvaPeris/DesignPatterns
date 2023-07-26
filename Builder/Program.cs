using Builder;
using Builder.Reports;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Builder pattern example");
        ReportDirector director = new ReportDirector();

        Console.WriteLine("\n:::: PDF REPORT ::::");
        PDFReport pdfReport = new PDFReport();
        Report report = director.MakeReport(pdfReport);
        report.DisplayReport();

        Console.WriteLine("\n:::: EXCEL REPORT ::::");
        ExcelReport excelReport = new ExcelReport();
        report = director.MakeReport(excelReport);
        report.DisplayReport();

        Console.ReadKey();
    }
}