using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AntalVersaler.Model
{
    public static class TextAnalyzer
    {
        
        //Skapar en statisk metod.
        public static int GetNumberOfCapitals(string text)
        { 
            //Skapar en variabel som håller koll på antal versalerna.
            int upperLetters = 0;

            //Skapar en for-each sats som går igenom  text strängen.
            foreach (char c in text)
            {
                /*Skapar en if sats som kollar om bokstaven i strängen är en 
                versal och säger till variabeln att räkna upp med +1.*/ 
                if (Char.IsUpper(c))
                {
                    upperLetters++;
                }
            }
            /*Retunerar variabeln upperLetters med den nya datan som den fått efter att
            hela strängen gått igenom loopen.*/
            return upperLetters;
        
        }

    }
}