using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Convertion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Convert_ServerClick(object sender, EventArgs e)
        {
            
            decimal oldAmount;
            bool success = Decimal.TryParse(US.Value, out oldAmount);
            if (success)
            {
                ListItem item = Currency.Items[Currency.SelectedIndex];
                decimal newAmount = oldAmount * Decimal.Parse(item.Value); ;
                Result.InnerText = oldAmount.ToString() + " U.S. dollars=";
                Result.InnerText += newAmount.ToString() + " "+ item.Text;
            }
            else
            {
                Result.InnerText = "The number you typed in was not in the" +
                    "correct format. Use only numbers.";
            }
        }
      protected void Page_Load(object sender, EventArgs e)
        {
          if (this.IsPostBack == false)
          { Currency.Items.Add(new ListItem("Euro", "0.85"));
          Currency.Items.Add(new ListItem("Japanese Yen", "110.33"));
          Currency.Items.Add(new ListItem("Canadian Dollar", "1.2"));
          
          }
        
        }
    
    }
}