namespace HandsOn.DesignPatterns.SOLID
{
    //OCP: The Open Closed Principle: — you should be able to extend a class’s behavior, without modifying it.

    public class ReportGeneration
    {
        /// <summary>
        /// Report type
        /// </summary>
        public string ReportType { get; set; }

        //If we need to generate another report type, then we need another if condition
        public void GenerateReport(Employee em)
        {
            if (ReportType == "CRS")
            {
                // Report generation with employee data in Crystal Report.
            }
            if (ReportType == "PDF")
            {
                // Report generation with employee data in PDF.
            }
        }

    }
    public class Employee
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
    }
    /// <summary>
    /// Moving the Report generation to different class
    /// </summary>
    public class OpenClosed
    {
        public class IReportGeneration
        {
            /// <summary>
            /// Method to generate report
            /// </summary>
            /// <param name="em"></param>
            public virtual void GenerateReport(Employee em)
            {
                // From base
            }
        }
        /// <summary>
        /// Class to generate Crystal report
        /// </summary>
        public class CrystalReportGeneraion : IReportGeneration
        {
            public override void GenerateReport(Employee em)
            {
                // Generate crystal report.
            }
        }
        /// <summary>
        /// Class to generate PDF report
        /// </summary>
        public class PDFReportGeneraion : IReportGeneration
        {
            public override void GenerateReport(Employee em)
            {
                // Generate PDF report.
            }
        }

    }
}
