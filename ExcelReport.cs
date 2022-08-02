namespace BuilderDesignPattern;


public class ExcelReport : ReportBuilder
{
    public override void SetReportContent()
    {
        reportObject.ReportContent = "PDF Content Section";
    }

    public override void SetReportFooter()
    {
        reportObject.ReportFooter = "PDF Footer";
    }

    public override void SetReportHeader()
    {
        reportObject.ReportHeader = "PDF Header";
    }

    public override void SetReportType()
    {
        reportObject.ReportType = "PDF";
    }
}