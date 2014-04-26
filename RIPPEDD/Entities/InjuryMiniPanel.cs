using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RIPPEDD.Controllers;

namespace RIPPEDD.Entities
{
    public class InjuryMiniPanel : Panel
    {
        public TextBox txtInjury;
        public Label lblInjury;
        public string Name;
        
      

        public InjuryMiniPanel(int index, string bodypart)
        {
            Name = bodypart;

            txtInjury = new TextBox();
            txtInjury.TextMode = TextBoxMode.MultiLine;
            txtInjury.Height = 50;
            txtInjury.Width = 220;
            txtInjury.ID = "txtInjury_" + index;
            txtInjury.Style["resize"] = "none";
            lblInjury = new Label();
            lblInjury.Text = bodypart;

            this.CssClass = "injuryMiniPanel";
            this.Attributes["runat"] = "server";
            //this.ID = "pnlInjury_" + HealthInputController.getInjuryID(bodypart);
            
            
            this.Controls.Add(lblInjury);
            this.Controls.Add(new LiteralControl("<br />"));
            this.Controls.Add(txtInjury);

        }


        public void updateID(int index)
        {
           
        }

    }
}