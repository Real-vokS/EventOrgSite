using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventOrgSite
{
    public partial class EventPage : System.Web.UI.Page
    {

        static List<OrginizedEvent> events = new List<OrginizedEvent>();

        public static void EventList()
        {
            events.Clear();

            //foreach loop senere
            //når data basen er connected
            for (int i = 0; i < 100; i++)
            {
                OrginizedEvent orgEvent = new OrginizedEvent();

                orgEvent.EventId = i;
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
                string classValueDiv1 = "container";
                string classValueDiv2 = "row clearfix";
                string classValueDiv3 = "col-md-12 column";

                string classValueTable1 = "table table-bordered table-hover";
                string idValueTable1 = "tab_logic";

                string classValueTh1 = "text-center";

                string idValueTr1 = "addr0";
                string idValueTr2 = "addr1";

                string idValueA1 = "add_row";
                string idValueA2 = "delete_row";
                string classValueA1 = "btn btn-default pull-left";
                string classValueA2 = "pull-right btn btn-default";

                string classValueInput1 = "form-control";


                //start of 1st div
                writer.AddAttribute(HtmlTextWriterAttribute.Class, classValueDiv1);
                writer.RenderBeginTag(HtmlTextWriterTag.Div);

                //start of 2nd div
                writer.AddAttribute(HtmlTextWriterAttribute.Class, classValueDiv2);
                writer.RenderBeginTag(HtmlTextWriterTag.Div);

                //start of 3rd div
                writer.AddAttribute(HtmlTextWriterAttribute.Class, classValueDiv3);
                writer.RenderBeginTag(HtmlTextWriterTag.Div);

                //start of table
                writer.AddAttribute(HtmlTextWriterAttribute.Class, classValueTable1);
                writer.AddAttribute(HtmlTextWriterAttribute.Id, idValueTable1);
                writer.RenderBeginTag(HtmlTextWriterTag.Table);

                //start of thead
                writer.RenderBeginTag(HtmlTextWriterTag.Thead);

                //start of tr
                writer.RenderBeginTag(HtmlTextWriterTag.Tr);

                //start of th #
                writer.AddAttribute(HtmlTextWriterAttribute.Class, classValueTh1);
                writer.RenderBeginTag(HtmlTextWriterTag.Th);
                writer.Write("#");
                writer.RenderEndTag(); //end of th #

                //start of th Option Name
                writer.AddAttribute(HtmlTextWriterAttribute.Class, classValueTh1);
                writer.RenderBeginTag(HtmlTextWriterTag.Th);
                writer.Write("Option Name");
                writer.RenderEndTag(); //end of th Option Name

                //start of th Amount
                writer.AddAttribute(HtmlTextWriterAttribute.Class, classValueTh1);
                writer.RenderBeginTag(HtmlTextWriterTag.Th);
                writer.Write("Amount");
                writer.RenderEndTag(); //end of th Amount

                writer.RenderEndTag(); //end of tr
                writer.RenderEndTag(); //end of thead

                //start of Tbody
                writer.RenderBeginTag(HtmlTextWriterTag.Tbody);

                //start of tr addr0
                writer.AddAttribute(HtmlTextWriterAttribute.Id, idValueTr1);
                writer.RenderBeginTag(HtmlTextWriterTag.Tr);

                //start of td #
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write("1");
                writer.RenderEndTag(); //end of td #

                //start of td Option Name
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                //start of input
                writer.AddAttribute(HtmlTextWriterAttribute.Type, "text");
                writer.AddAttribute(HtmlTextWriterAttribute.Name, "name0");
                writer.AddAttribute("placeholder", "Name");
                writer.AddAttribute(HtmlTextWriterAttribute.Class, classValueInput1);
                writer.RenderBeginTag(HtmlTextWriterTag.Input);
                writer.RenderEndTag(); //end of input
                writer.RenderEndTag(); //end of td Option Name

                //start of td Option Name
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                //start of input
                writer.AddAttribute(HtmlTextWriterAttribute.Type, "text");
                writer.AddAttribute(HtmlTextWriterAttribute.Name, "amount0");
                writer.AddAttribute("placeholder", "Amount");
                writer.AddAttribute(HtmlTextWriterAttribute.Class, classValueInput1);
                writer.RenderBeginTag(HtmlTextWriterTag.Input);
                writer.RenderEndTag(); //end of input
                writer.RenderEndTag(); //end of td Option Name

                writer.RenderEndTag(); // end of tr addr0

                //start of tr addr1
                writer.AddAttribute(HtmlTextWriterAttribute.Id, idValueTr2);
                writer.RenderBeginTag(HtmlTextWriterTag.Tr);
                writer.RenderEndTag(); //end of tr addr 1

                writer.RenderEndTag(); //end of Tbody
                writer.RenderEndTag(); //end of table
                writer.RenderEndTag(); //end of 3rd div
                writer.RenderEndTag(); //end of 2nd div

                //start of a add_row
                writer.AddAttribute(HtmlTextWriterAttribute.Id, idValueA1);
                writer.AddAttribute(HtmlTextWriterAttribute.Class, classValueA1);
                writer.RenderBeginTag(HtmlTextWriterTag.A);
                writer.Write("Add Row");
                writer.RenderEndTag(); //end of a add_row

                //start of a delete_row
                writer.AddAttribute(HtmlTextWriterAttribute.Id, idValueA2);
                writer.AddAttribute(HtmlTextWriterAttribute.Class, classValueA2);
                writer.RenderBeginTag(HtmlTextWriterTag.A);
                writer.Write("Delete Row");
                writer.RenderEndTag(); //end of a delete_row

                writer.RenderEndTag(); //end of 1st div
            }
            return sw.ToString();
        }

            protected void Page_Load(object sender, EventArgs e)
            {

                EventList();


                if (events.FirstOrDefault().EventId < events.LastOrDefault().EventId)
                {
                    events.Reverse();
                }

                RightSide.InnerHtml = getDivElements();

            }
        }
    }