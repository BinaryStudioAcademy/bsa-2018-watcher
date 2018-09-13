using System.Data;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.Shared.Models;

namespace Watcher.Core.Services
{
    public static class GenerateWholeHtml
    {
        public static string GenerateHtml(InstanceAnomalyReport report) // AzureMLAnomalyReport
        {
            var html = "<!DOCTYPE html><html xmlns = 'http://www.w3.org/1999/xhtml'><head><meta charset = 'utf-8'/><title>Analyze </ title ></head>< body >" 
                + "< table >< tr >< td >< br />< span style = 'font-family: Arial; font-size: 14pt'>Hello < b >" + /*UserName + */
                ",</ b >< br />< br /></span></td></tr>< tr >< td width = '100%' align = 'center' valign = 'middle' >< span style = 'font-family: Arial; font-size: 14pt'>Analyze by date - " 
                + report.Date + "< br />< span >< br /></ span >< div style = 'border-top: 3px solid #22BCE5' > </ div ></ span ></td></tr> <tr><td><br/><span style='font-family: Arial; font-size: 14pt'>";

            html = html + GenerateTable(report.AnomalyGroups[0], "CPU") + GenerateTable(report.AnomalyGroups[0], "RAM") + GenerateTable(report.AnomalyGroups[0], "DISC");

            html = html + "</span></ td ></ tr >< tr >< td width = '100%' align = 'right' valign = 'middle' >< br />< span style = 'font-family: Arial; font-size: 14pt' >Best wishes,<br/>" + 
                   "< a style = 'color: #22BCE5' href = 'bsa-watcher.azurewebsites.net' ><b> Watcher </b></a></span></td></tr></table></body></html>";

            return html;
        }

        // title = CPU, RAM and DISK
        public static string GenerateTable(AzureMLAnomalyGroup group, string title)
        {
            var Warnings = group.Warnings;
            var Anomalies = group.Anomalies;
            DataTable dtProcess = new DataTable();
            dtProcess.Columns.Add("Warnings");
            dtProcess.Columns.Add("Anomalies");
            var countRow = Warnings.Count > Anomalies.Count ? Warnings.Count : Anomalies.Count;
            for (var i = 0; i < countRow; i++)
            {
                dtProcess.Rows.Add(Warnings.Count <= i ? "" : StringInColumn(Warnings[i]), Anomalies.Count <= i ? "" : StringInColumn(Anomalies[i]));
            }

            string process = "<table style='width=100%, border=0, cellspacing=5, cellpadding=10' >";
            process += "<tr><td colspan='2' width='100%' align='center' valign='middle' style='font - size: 15pt'><b>" + title + "</b></td></tr>";
            process += "<tr><td width='50%' align='center' valign='middle'><b>Warnings</b></td></tr><tr><td width='50%' align='center' valign='middle'><b>Anomalies</b></td></tr>";
            foreach (DataRow dr in dtProcess.Rows)
            {
                process = process + "<tr><td width='50%' align='left' valign='middle'>" + dr["Warnings"].ToString() + "</td><td width='50%' align='left' valign='middle'>" + dr["Anomalies"].ToString() + "</td></tr>";
            }

            process = process + "</table>";
            return process;
        }

        public static string StringInColumn(AzureMLAnomaly ob) => "" + ob.Time + " : " + ob.Data + " %";
    }
}
