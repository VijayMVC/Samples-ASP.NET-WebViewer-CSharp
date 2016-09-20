using System;
using System.Data;
using Stimulsoft.Report;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void StiWebViewer1_GetReport(object sender, Stimulsoft.Report.Web.StiReportDataEventArgs e)
    {
        string reportPath = Server.MapPath("Reports/SimpleList.mrt");
        e.Report = new StiReport();
        e.Report.Load(reportPath);

        string dataPath = Server.MapPath("Data/Demo.xml");
        DataSet data = new DataSet();
        data.ReadXml(dataPath);
        e.Report.RegData(data);
    }
}
