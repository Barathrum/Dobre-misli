using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dobre_misli
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Application["misli"] == null)
            {
                List<Label> li2 = new List<Label>();
                Application["misli"] = li2;
            }

            misli.Controls.Clear();
            List<Label> li = (List<Label>)Application["misli"];
            foreach(Label l in li)
            {
                misli.Controls.AddAt(0, l);

            }
            
        }

        protected void dodajMisel_Click(object sender, EventArgs e)
        {
            List<Label> li = (List<Label>)Application["misli"];
            Label label = new Label();
            label.Text = misel.Text + "<br ;";
            li.Add(label);
            Application["misli"] = li;
            Server.TransferRequest(Request.Url.AbsolutePath, false);
        }
    }
    
}