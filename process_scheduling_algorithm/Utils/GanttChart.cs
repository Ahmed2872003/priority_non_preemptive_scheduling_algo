using process_scheduling_algorithm.Models;
using System.Collections.Generic;

namespace process_scheduling_algorithm.Utils
{
    internal class GanttChart
    {











        public static string Generete(List<Process> processes, Scheduling_Algo.Result AVGS)
        {
            string page, head, header, style, body;

            string processCon = "";

            string gantChartCon = "";

            string infoCon = "";

            string table = "";

            string tableH = "";

            string tableB = "";

            style = @"
                    <style>
                      body {
                        display: flex;
                        flex-direction: column;
                        margin: 0;
                        font-family: sans-serif;
                        box-sizing: border-box;
                        background-color: #3d4c41;
                        border: 2px solid #e6e6e6;
                        min-height: 100vh;
                      }
                      header {
                        color: #e6e6e6;
                        padding: 5px;
                        text-align: center;
                        font-size: 1.2rem;
                        border-bottom: 2px solid;
                        border-color: #e6e6e6;
                        box-shadow: 1px 3px 8px #e6e6e63d;
                      }
                      .gantt-chart-container {
                        display: flex;
                        justify-content: center;
                        flex-direction: column;
                        gap: 20px;
                        flex: 1;
                        flex-grow: 1;
                        padding: 20px;
                      }
                      .gantt-chart {
                        display: flex;
                        align-items: safe center;
                        justify-content: center;
                        overflow-x: scroll;
                        overflow-y: hidden;
                        user-select: none;
                      }

                      ::-webkit-scrollbar {
                        height: 5px;
                      }

                      /* Track */
                      ::-webkit-scrollbar-track {
                        box-shadow: inset 0 0 5px #e6e6e6;
                        border-radius: 10px;
                      }

                      /* Handle */
                      ::-webkit-scrollbar-thumb {
                        background: white;
                        border-radius: 10px;
                      }
                      .box {
                        position: relative;
                        z-index: 2;
                        min-width: 100px;
                        max-width: 260px;
                        flex: 1;
                        height: 200px;
                        height: 80px;
                        background-color: #999999;
                        color: #e6e6e6;
                        border: solid white;
                        border-width: 2px 1px;
                        display: flex;
                        justify-content: center;
                        align-items: center;
                        font-weight: bold;
                        font-size: 1.2rem;
                        margin-bottom: 35px;
                      }

                      .gantt-chart > .box:last-child {
                        border-left-width: 1px;
                        border-right-width: 2px;
                      }
                      .gantt-chart > .box:first-child {
                        border-left-width: 2px;
                        border-right-width: 1px;
                      }
                      .start,
                      .end {
                        position: absolute;
                      }
                      .end {
                        left: 100%;
                        top: calc(100% + 5px);
                      }
                      .start {
                        right: calc(100%);
                        transform: translateX(100%);
                        top: calc(100% + 5px);
                      }
                      .info {
                        display: flex;
                        flex-direction: column;
                        width: 100%;
                        gap: 30px;
                        font-weight: bold;
                        color: #e6e6e6;
                        font-size: 1.5rem;
                      }
                      .details {
                        display: flex;
                        flex-wrap: wrap;
                        align-items: center;
                        justify-content: center;
                        padding-left: 20px;
                      }
                      .details span {
                        margin: 20px;
                      }
                      table {
                        border: 2px solid #e6e6e6;
                        width: 100%;
                        color: #e6e6e6;
                        font-weight: bold;
                      }

                      th,
                      td {
                        border: 1px solid white;
                        text-align: center;
                      }
                    </style>
";


            head = @"<head>
                    <meta charset=""UTF-8"" />
                    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
                    <title>Gantt Chart</title>" + style + "</head>";

            header = @"<header><h1>Gantt Chart</h1></header>";

            for (int i = 0; i < processes.Count; i++)
            {
                Process p = processes[i];

                if (i == 0)
                    processCon += @"
                                <div class=""box"">
                                " + "P" + p.id + @"<span class=""start"">" + p.arrival_time + @"</span> <span class=""end"">" + p.completion_time + @"</span>
                                 </div>
                                ";

                else processCon += @"
                                <div class=""box"">
                                P" + p.id + @"<span class=""end"">" + p.completion_time + @"</span>
                                 </div>
                                ";

            }

            gantChartCon = @"<div class=""gantt-chart-container""> <div class=""gantt-chart"">" + processCon + "</div>";

            infoCon = @"<div class=""info"">
                        <span>AVG</span>
                        <div class=""details"">
                        <span>Turn Around Time = " + AVGS.AVG_turn_around_T + @"</span>
                        <span>Waiting Time = " + AVGS.AVG_wating_T + @"</span>
                        <span>Response Time = " + AVGS.AVG_responce_T + @"</span>
                        </div>";

            tableH = @"
                    <tr>
                    <th>Process</th>
                    <th>Arrival Time</th>
                    <th>Burst Time</th>
                    <th>Waiting Time</th>
                    <th>Turn Around Time</th>
                    <th>Response Time</th>
                    <th>Priority</th>
                    </tr>
";

            table = @"<div class=""table"">
                    <h3>Details</h3>
                    <table>
                    " + tableH;

            for (int i = 0; i < processes.Count; i++)
            {
                Process p = processes[i];

                tableB += @"<tr>
              <td>" + "P" + p.id + @"</td>
              <td>" + p.arrival_time + @"</td>
              <td>" + p.burst_time + @"</td>
              <td>" + p.waiting_time + @"</td>
              <td>" + p.turn_around_time + @"</td>
              <td>" + p.response_time + @"</td>
              <td>" + p.priority + @" </ td >
            </ tr >
            ";
            }

            table += tableB + "" + @"
                    </table></div>";

            infoCon += table + "</div>";

            gantChartCon += infoCon + "</div>";

            body = "<body>" + header + gantChartCon + "</body>";

            page = "<!DOCTYPE html>\r\n<html lang=\"en\">" + head + body + "</html>";

            return page;
        }
    }
}
