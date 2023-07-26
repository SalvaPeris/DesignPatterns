namespace Builder.Reports
{
    public class ExcelReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "Excel content";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Excel footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Excel header";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "Excel";
        }
    }
}
