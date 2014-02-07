using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AntalVersaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button_Click(object sender, EventArgs e)
        {

            //Om inte textboxen inte är "tom" utförs följande .... 
            if (Textbox.Text != String.Empty)
            {
                //Skapar en variabel av typen "string" och tilldelar den den inmatade texten i textboxen.
                string text = Textbox.Text;

                /*Skapar en variabel av typen "int" och tilldelar den antalet Versaler, som räknats ut genom
                klassen "Textanalyzer" via metoden "GetNumberOfCapitals".*/
                int upper = Model.TextAnalyzer.GetNumberOfCapitals(text);

                //Presenterar placeholdern tillsammans med innehållande p-tagg.
                PlaceHolder1.Visible = true;
                
                //Presenterar resultatet av antal versaler (labeln som ligger i placeholdern). 
                Label1.Text = upper.ToString();

                //Ser till att resultatet av versaler verkligen visas i labeln.
                Label1.Visible = true;

                // Gör så att textboxen blir grå och ej går att redigera.
                Textbox.Enabled = false;
                
                //Presenterar "rensa-knappen" efter att resultatet visats för en ny chans till inmatning.
                ClearButton.Visible = true;

                //Döljer knappen, som bekräftar inmatningen första gången. 
                Button.Visible = false;
            
            }

        }





        }
    }

            



        