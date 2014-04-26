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
        TextBox txtInjury;
        Label lblInjury;
        string name;
        
        
        public InjuryMiniPanel(int index, string bodypart)
        {
            name = bodypart;

            txtInjury = new TextBox();
            lblInjury = new Label();
            lblInjury.Text = bodypart;
            
            this.Attributes["CssClass"] = "miniInjuryPanel";
            this.Attributes["runat"] = "server";
            this.ID = "pnlInjury_" + HealthInputController.getInjuryID(bodypart);
            
            
            this.Controls.Add(lblInjury);
            this.Controls.Add(new LiteralControl("<br />"));
            this.Controls.Add(txtInjury);

        }

        public void updateID(int index)
        {
           
        }

    }
}