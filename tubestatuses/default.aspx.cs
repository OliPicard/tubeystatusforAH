using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data;
using System.Drawing;
using Newtonsoft.Json;


namespace tubestatuses
{
    public partial class tubestation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetStatus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GetStatus();
        }

        public void GetStatus()
        {
            var uri = ("https://api.tfl.gov.uk/line/mode/tube,overground,dlr,tram,national-rail,cable-car,river-bus,river-tour/status");
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(uri);
            var data = JsonConvert.DeserializeObject<IEnumerable<Line>>(content);
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Status", typeof(string)));
            dt.Columns.Add(new DataColumn("Reason", typeof(string)));


            foreach (var line in data)
            {
                var firstLineStatus = line.lineStatuses.FirstOrDefault();
                var lineDescription = "";
                var lineStatusDescription = "No Status Provided.";

                if (firstLineStatus != null)
                {
                    lineStatusDescription = firstLineStatus.statusSeverityDescription;
                    lineDescription = firstLineStatus.reason;
                }
                DataRow dr = dt.NewRow();
                
                dt.Rows.Add(line.name, lineStatusDescription, lineDescription);
                


            }
            GridView1.DataSource = dt;
               GridView1.DataBind();
        }
        protected void RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
       
                    if (e.Row.Cells[1].Text == "Good Service")
                    {
                        e.Row.Cells[1].BackColor = Color.LightGreen;
                    }
                    else if (e.Row.Cells[1].Text == "Severe Delays")
                    {
                        e.Row.Cells[1].BackColor = Color.LightPink;
                        
                    }
                    else if (e.Row.Cells[1].Text == "Minor Delays")
                    {
                        e.Row.Cells[1].BackColor = Color.Yellow;
                    }
                    else if (e.Row.Cells[1].Text == "Special Service")
                    {
                        e.Row.Cells[1].BackColor = Color.PowderBlue;
                    }
                    else e.Row.Cells[1].BackColor = Color.White;

                }

            }
        }
     }
