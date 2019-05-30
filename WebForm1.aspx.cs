using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sorting_a_List_of_Numbers
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ListItem item1 = new ListItem("Insertion","Insertion");
                ListItem item2 = new ListItem("Bubble","Bubble");
                DropDownList1.Items.Add(item1);
                DropDownList1.Items.Add(item2);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] words = TextBox1.Text.Split(',');
            int[] arr = Array.ConvertAll(words,int.Parse);

            if (DropDownList1.SelectedValue == "Insertion")
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {


                    for (int k = 0; k <= arr.Length - 2; k++)
                    {

                        if (arr[k] > arr[k + 1])
                        {
                            int temp = arr[k + 1];
                            arr[k + 1] = arr[k];
                            arr[k] = temp;

                        }


                    }
                }
                string result = string.Join(",", arr);

                TextBox2.Text = result;


            }


            else if (DropDownList1.SelectedValue == "Bubble")
            {
                int smallest;



                for (int i = 0; i < arr.Length; i++)
                {
                    smallest = i;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] < arr[smallest])
                        {
                            smallest = j;
                        }
                    }
                    swap(i, smallest);
                }
                string result = string.Join(",", arr);
                void swap(int first, int second)
                {
                    int temp = arr[first];
                    arr[first] = arr[second];
                    arr[second] = temp;

                }
                TextBox2.Text = result;



            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}