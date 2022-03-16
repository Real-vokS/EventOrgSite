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
        int options = 0;
        static int maxAmount = 5;

        string[] thLabel = { "#", "Name", "Amount" };

        static bool isAdmin = true;
        bool hasOptions = true;
        bool EventCreation = true;

        static List<OptionRows> optRow = new List<OptionRows>();


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

                string classValueTh1 = "text-center";

                string idValueTr1 = "addr0";
                string idValueTr2 = "addr1";

                string idValueA1 = "add_row";
                string idValueA2 = "delete_row";
                string classValueA1 = "btn btn-default pull-left";
                string classValueA2 = "pull-right btn btn-default";

                string classValueInput1 = "form-control";

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
                writer.AddAttribute(HtmlTextWriterAttribute.Type, "number");
                writer.AddAttribute(HtmlTextWriterAttribute.Name, "amount0");
                writer.AddAttribute("placeholder", "Amount");
                writer.AddAttribute("max", $"{maxAmount}");
                writer.AddAttribute("min", "0");
                writer.AddAttribute("step", "1");
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

            if (EventCreation == true)
            {
                participate.Visible = false;
                cEvent.Visible = true;
            }
            else
            {
                participate.Visible = true;
                cEvent.Visible = false;
            }

            if(optRow.Count > 0) {
            options = optRow.Last().Id;
            }

            dt.Rows.Add(CreateTableHead());

            if (!this.IsPostBack)
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.AddRange(new System.Data.DataColumn[3]{
                    new System.Data.DataColumn("#"),
                    new System.Data.DataColumn("Name"),
                    new System.Data.DataColumn("Amount") });


                string addRowText = optionName.Text;
                string addAmountText = optionAmount.Text;

                dt.Rows.Add(1, addRowText, addAmountText);


                gridService.DataSource = dt;
                gridService.DataBind();
                gridService.UseAccessibleHeader = true;
            }
            
        }

        void showTableRows()
        {
            foreach (var item in optRow)
            {
                TableRow row = new TableRow();
                TableCell cell_id = new TableCell();
                cell_id.Text = item.Id.ToString();
                row.Cells.Add(cell_id);

                TableCell cell_name = new TableCell();
                TextBox name = new TextBox();
                cell_name.Controls.Add(name);
                name.Text = item.Name;
                row.Cells.Add(cell_name);

                TableCell cell_amount = new TableCell();
                TextBox amount = new TextBox();
                amount.TextMode = TextBoxMode.Number;
                cell_amount.Controls.Add(amount);
                amount.Text = item.MaxAmount.ToString();
                row.Cells.Add(cell_amount);

                dt.Rows.Add(row);
            }

        }

        TableHeaderRow CreateTableHead()
        {
            TableHeaderRow thRow = new TableHeaderRow();
            foreach (var item in thLabel)
            {
                TableHeaderCell thCell = new TableHeaderCell();
                thCell.Text = item;
                thCell.CssClass = "text-center";
                thCell.Scope = TableHeaderScope.Column;
                thRow.Cells.Add(thCell);
            }
            return thRow;
        }

        protected void AddRow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
            }

            if (optRow.Count > 0)
            {
                foreach(var option in optRow)
                {
                }
            }



            OptionRows oRow = new OptionRows();
            oRow.Id = Convert.ToInt32(options + 1);
            optRow.Add(oRow);

            showTableRows();
            
        }

        protected void DeleteRow_Click(object sender, EventArgs e)
        {
            if (optRow.Count > 0)
            {
                optRow.RemoveAt(optRow.Count - 1);
            }

            showTableRows();

        }
    }
}