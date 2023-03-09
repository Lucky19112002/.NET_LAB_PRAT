using System;

namespace p8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button1_Click1(object sender, EventArgs e)
        {
            string name = TextBox1.Text; // Get NAME
            string meals = "";
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected == true)
                    meals += CheckBoxList1.Items[i].Value.ToString() + ","; // Get Meals Selected 
            }
            string val = "";
            val = RadioButtonList1.SelectedValue; // Get Vaccination Status
            String vaciName = DropDownList1.SelectedValue; // Get Vaccination Type

            Response.Write("<h1 style='color:green'>Name: " + name + "</h1>");
            Response.Write("<h1 style='color:red'>Meals " + meals + "</h1>");
            Response.Write("<h1 style='color:pink'>Vaccination Status " + val + "</h1>");
            Response.Write("<h1 style='color:maroon'>Vaccine Name " + vaciName + "</h1>");
        }
    }
}