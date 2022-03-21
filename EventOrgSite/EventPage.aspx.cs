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
        static int maxAmount = 5;
        public int optionCount = 0;

        static bool isAdmin = true;
        bool hasOptions = true;
        bool EventCreation = true;


        List<Option> options = new List<Option>();


        protected void Page_Load(object sender, EventArgs e)
        {

            if (EventCreation == true)
            {
                participate.Visible = false;
                cEvent.Visible = true;
                tablogic.Visible = true;
                optionButtons.Visible = true;
            }
            else
            {
                rightSide.InnerHtml = createUserTable();
                participate.Visible = true;
                cEvent.Visible = false;
                tablogic.Visible = false;
                optionButtons.Visible = false;
            }
        }

        string createUserTable()
        {
            StringWriter sw = new StringWriter();

            using (HtmlTextWriter writer = new HtmlTextWriter(sw))
            {

                string idValueTr = "addr" + optionCount;


                //start of 1st div
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "container");
                writer.RenderBeginTag(HtmlTextWriterTag.Div);

                //start of 2nd div
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "row clearfix");
                writer.RenderBeginTag(HtmlTextWriterTag.Div);

                //start of 3rd div
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "col-md-12 column");
                writer.RenderBeginTag(HtmlTextWriterTag.Div);

                //start of table
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "table table-bordered table-hover");
                writer.AddAttribute(HtmlTextWriterAttribute.Id, "tab_logic");
                writer.RenderBeginTag(HtmlTextWriterTag.Table);

                //start of thead
                writer.RenderBeginTag(HtmlTextWriterTag.Thead);

                //start of tr
                writer.RenderBeginTag(HtmlTextWriterTag.Tr);

                //start of th #
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "text-center");
                writer.RenderBeginTag(HtmlTextWriterTag.Th);
                writer.Write("#");
                writer.RenderEndTag(); //end of th #

                //start of th Option Name
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "text-center");
                writer.RenderBeginTag(HtmlTextWriterTag.Th);
                writer.Write("Option Name");
                writer.RenderEndTag(); //end of th Option Name

                //start of th Amount
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "text-center");
                writer.RenderBeginTag(HtmlTextWriterTag.Th);
                writer.Write("Amount");
                writer.RenderEndTag(); //end of th Amount

                writer.RenderEndTag(); //end of tr
                writer.RenderEndTag(); //end of thead

                //start of Tbody
                writer.RenderBeginTag(HtmlTextWriterTag.Tbody);


                if (hasOptions == true)
                {
                    foreach (var option in options)
                    {
                        //start of TR id addr(optionCount)
                        writer.AddAttribute(HtmlTextWriterAttribute.Id, idValueTr + "_user");
                        writer.AddAttribute(HtmlTextWriterAttribute.Class, "text-center");
                        writer.RenderBeginTag(HtmlTextWriterTag.Tr);

                        //start of td #
                        writer.RenderBeginTag(HtmlTextWriterTag.Td);
                        writer.Write(optionCount + 1);
                        writer.RenderEndTag(); //end of td #

                        //start of td Option Name
                        writer.RenderBeginTag(HtmlTextWriterTag.Td);
                        //start of input
                        writer.AddAttribute(HtmlTextWriterAttribute.Type, "text");
                        writer.AddAttribute(HtmlTextWriterAttribute.Name, "name" + optionCount);
                        writer.AddAttribute("placeholder", option.name);
                        writer.AddAttribute("disabled", "true");
                        writer.AddAttribute("style", "background: white; color: black;");
                        writer.AddAttribute(HtmlTextWriterAttribute.Id, "addr" + optionCount + "_nameUser");
                        writer.AddAttribute(HtmlTextWriterAttribute.Class, "form-control");
                        writer.RenderBeginTag(HtmlTextWriterTag.Input);
                        writer.RenderEndTag(); //end of input
                        writer.RenderEndTag(); //end of td Option Name

                        //start of td Option Name
                        writer.RenderBeginTag(HtmlTextWriterTag.Td);
                        //start of input
                        writer.AddAttribute(HtmlTextWriterAttribute.Type, "number");
                        writer.AddAttribute(HtmlTextWriterAttribute.Name, "amount" + optionCount);
                        writer.AddAttribute("min", "0");
                        writer.AddAttribute("max", option.maxAmount.ToString());
                        writer.AddAttribute("step", "1");
                        writer.AddAttribute(HtmlTextWriterAttribute.Id, "amount" + optionCount + "_amountUser");
                        writer.AddAttribute(HtmlTextWriterAttribute.Class, "form-control");
                        writer.RenderBeginTag(HtmlTextWriterTag.Input);
                        writer.RenderEndTag(); //end of input
                        writer.RenderEndTag(); //end of td Option Name

                        writer.RenderEndTag(); // end of tr
                        optionCount++;
                    }
                }

                writer.RenderEndTag(); //end of Tbody
                writer.RenderEndTag(); //end of table
                writer.RenderEndTag(); //end of 3rd div
                writer.RenderEndTag(); //end of 2nd div

                writer.RenderEndTag(); //end of 1st div
            }
            return sw.ToString();
        }

    }
}