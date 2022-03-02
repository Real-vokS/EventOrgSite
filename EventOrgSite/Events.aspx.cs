using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace EventOrgSite
{
    public partial class Events : System.Web.UI.Page
    {

        public bool isAdmin = false;

        static List<OrginizedEvent> events = new List<OrginizedEvent>();

        public static void EventList()
        {
            events.Clear();

            //foreach loop senere
            //når data basen er connected
            for(int i = 0; i < 100; i++)
            {
                OrginizedEvent orgEvent = new OrginizedEvent();

                orgEvent.EventTitle = (i + 1).ToString();
                orgEvent.Participants = 20 + i;
                orgEvent.CreatedDate = DateTime.Now;
                orgEvent.Deadline = orgEvent.CreatedDate.AddDays(7);

                events.Add(orgEvent);
            }


        }

        static string getDivElements()
        {

            StringWriter sw = new StringWriter();

            using (HtmlTextWriter writer = new HtmlTextWriter(sw))
            {
                string classValueDiv1 = "list-group";
                writer.AddAttribute(HtmlTextWriterAttribute.Class, classValueDiv1);
                writer.RenderBeginTag(HtmlTextWriterTag.Div);

                foreach (var orgEvent in events)
                {

                    string classValueA = "list-group-item list-group-item-action flex-column align-items-start";
                    string classValueDiv2 = "d-flex w-100 justify-content-between";
                    string classValueH5 = "mb-1";


                    writer.AddAttribute(HtmlTextWriterAttribute.Href, "#");
                    writer.AddAttribute(HtmlTextWriterAttribute.Class, classValueA);
                    writer.RenderBeginTag(HtmlTextWriterTag.A); // Begin #2

                    writer.AddAttribute(HtmlTextWriterAttribute.Class, classValueDiv2);
                    writer.RenderBeginTag(HtmlTextWriterTag.Div);

                    writer.AddAttribute(HtmlTextWriterAttribute.Class, classValueH5);
                    writer.RenderBeginTag(HtmlTextWriterTag.H5);
                    writer.Write(orgEvent.EventTitle);
                    writer.RenderEndTag();

                    writer.RenderBeginTag(HtmlTextWriterTag.Small); // Begin #2
                    writer.Write("Deltagere: " + orgEvent.Participants);
                    writer.RenderEndTag();

                    writer.RenderBeginTag(HtmlTextWriterTag.Small);
                    writer.Write("Sidste tilmelding " + orgEvent.Deadline);
                    writer.RenderEndTag();

                    writer.RenderBeginTag(HtmlTextWriterTag.Small); // Begin #2
                    writer.Write("3 days ago");
                    writer.RenderEndTag();

                    writer.RenderEndTag();

                    writer.AddAttribute(HtmlTextWriterAttribute.Class, classValueH5);
                    writer.RenderBeginTag(HtmlTextWriterTag.P);
                    writer.Write("Dette er en beskrivelse af event nummer " + orgEvent.EventTitle + " hvor der står alt mugligt om dette event og nu fylder jeg bare teksten ud så det ser nogenlunde godt ud tror jeg men er ikke helt sikker så der er bare tekst ligenu.");
                    writer.RenderEndTag();

                    writer.RenderBeginTag(HtmlTextWriterTag.Small);
                    writer.Write("Posted Date " + orgEvent.CreatedDate);
                    writer.RenderEndTag();

                    writer.RenderEndTag();

                }
                writer.RenderEndTag();
            }
            return sw.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(isAdmin == true)
            {
                CreateEvent.Visible = true;
            }
            else
            {
                CreateEvent.Visible = false;
            }

            if(events.Count == 0) {
            EventList();
            events.Reverse();
            }


            ContentDiv.InnerHtml = getDivElements();

        }

        
    }
}