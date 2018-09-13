using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DataAccumulator.Shared.Models;

namespace Watcher.wwwroot
{
    public class GenerateHtmlTable
    {
        public void GenerateAllTables(AzureMLAnomalyReport report)
        {
            GenerateTable(report.AnomalyGroups[0], "CPU");
            GenerateTable(report.AnomalyGroups[0], "RAM");
            GenerateTable(report.AnomalyGroups[0], "DISK");
        }

        // title = CPU, RAM and DISK
        public void GenerateTable(AzureMLAnomalyGroup group, string title)
        {
            var Warnings = group.Warnings;
            var Anomalies = group.Anomalies;
            DataTable dtProcess = new DataTable();
            dtProcess.Columns.Add("Warnings");
            dtProcess.Columns.Add("Anomalies");
            var countRow = Warnings.Count > Anomalies.Count ? Warnings.Count : Anomalies.Count;
            for (int i = 0; i < countRow; i++)
                dtProcess.Rows.Add(Warnings.Count <= i ? "" : StringIncolumn(Warnings[i]), Anomalies.Count <= i ? "" : StringIncolumn(Anomalies[i]));

            string process = "<table style='width=100%, border=0, cellspacing=5, cellpadding=10' >";
            process += "<tr><td colspan='2' width='100%' align='center' valign='middle'>" + title + "</td></tr>";
            process += "<tr><td width='60%' align='center' valign='middle'><b>Warnings</b></td></tr><tr><td width='40%' align='center' valign='middle'><b>Anomalies</b></td></tr>";
            foreach (DataRow dr in dtProcess.Rows)
            {
                process = process + "<tr><td width='60%' align='left' valign='middle'>" + dr["Warnings"].ToString() + "</td><td width='40%' align='left' valign='middle'>" + dr["Anomalies"].ToString() + "</td></tr>";
            }

            process = process + "</table>";
            switch (title)
            {
                case "CPU":
                    dvTableContentCPU.InnerHtml = process;
                    break;
                case "RAM":
                    dvTableContentRAM.InnerHtml = process;
                    break;
                case "DISK":
                    dvTableContentDISK.InnerHtml = process;
                    break;
            }
        }

        public string StringIncolumn(AzureMLAnomaly ob) => "" + ob.Time + " : " + ob.Data + " %";
    }
}
