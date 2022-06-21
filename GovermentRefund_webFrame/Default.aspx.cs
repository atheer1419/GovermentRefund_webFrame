using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;


namespace GovermentRefund_webFrame
{
    public partial class _Default : Page
    {
        public static string Ticket_Number;
        public static TextBox lbl;
        public static string[] arrayTextBox;
        public static int count;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void btnSave_Click(object sender, EventArgs e)
        {
            Ticket_Number = form__input2.Text;
            count = Convert.ToInt32(Ticket_Number);
            arrayTextBox = new string[count];
            for (int i = 0; i < count; i++)
            {
                lbl = new TextBox();
                lbl.ID = "TextBox" + i;
                pnlTextBox.Controls.Add(lbl);
                arrayTextBox[i] = lbl.Text;
            }
            //Response.Write(arrayTextBox[0].ToString());
        }
        public void btnCreate_Click(object sender, EventArgs e)
        {
            string file = @"C:\Users\WinDows\Desktop\Letter1.txt";
            string[] lines = File.ReadAllLines(file);
            string[] arrayLines = new string[lines.Length];

            Boolean flag = false;
            int inex = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                int j = i;
                if (flag == false && lines[i].StartsWith("DOCUMENT"))
                {
                    flag = true;
                    do
                    {
                        arrayLines[inex] += " " + lines[j].ToString();
                        if (j < lines.Length - 1)
                        {
                            j++;
                        }
                        else
                        {
                            break;
                        }
                    } while (!lines[j].StartsWith("DOCUMENT") == true);
                    flag = false;
                    inex++;
                }
            }

            int value = 0;
            for (int i = 0; i < arrayLines.Length; i++)
            {
                if (arrayLines[i] != null)
                {
                    value++;
                }

            }
            string[] swap = new string[value];
            for (int i = 0; i < value; i++)
            {
                swap[i] = arrayLines[i];
            }
            string msq = null;
            foreach (TextBox textBox in pnlTextBox.Controls.OfType<TextBox>())
            {
                msq += textBox.ID + " : " + textBox.Text + "\\n";
                Response.Write("ghada");
            }
            Response.Write(msq);
            //*********print Array * ************
            for (int j = 0; j < swap.Length; j++)
            {
                String[] s = new string[System.Text.RegularExpressions.Regex.Split(swap[j], @"\s{1,}").Length];

                s = System.Text.RegularExpressions.Regex.Split(swap[j], @"\s{1,}");

                for (int i = 0; i < s.Length; i++)
                {
                    //for (int c = 0; c < count; c++)
                    //{
                    //    String z = arrayTextBox[c].ToString();


                    //    Response.Write(z);
                    //    if (z == null)
                    //    {
                    //        Response.Write("sad");
                    //    }
                    //    else
                    //    {
                    //        Response.Write("sad^4");
                    //    }
                    //}
                }

            }
        }
    }
}