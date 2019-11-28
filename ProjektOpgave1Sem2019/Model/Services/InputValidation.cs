using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019.Model
{
    //Martin
    class InputValidation //Bruges til at validere input i BoligDetails.cs
    {
        public static bool ValiderDouble(string text)
        {
            bool returnBool = false;

            if (double.TryParse(text, out double d))
            {
                returnBool = true;
            }

            return returnBool;
        }

        public static bool ValiderInt(string text)
        {
            bool returnBool = false;

            if (int.TryParse(text, out int i))
            {
                returnBool = true;
            }

            return returnBool;
        }
    }
}
