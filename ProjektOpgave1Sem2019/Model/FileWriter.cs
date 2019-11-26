using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ProjektOpgave1Sem2019.Model
{
    //Martin
    class FileWriter
    {
        
        private static string filePath = @"C:\Users\marti\BoligListe.txt";
        public static bool BoligerTilSalgToFile()
        {
            bool wasSuccessful;

            List<Bolig> list = BoligTabelDB.GetAll(); //Hent boliger fra database Per opgave 3.2 beskrivelse

            list.Sort(); //Sorter liste. Bolig implementerer ICompareable, som sammenligner på pris og sorterer billigs først
            FileStream fs;

            try
            {
                fs = File.OpenRead(filePath); 
            }
            catch(FileNotFoundException) //Hvis filen ikke eksisterer, opret istedet
            {
                fs = File.Create(filePath);
            } //evt implementer en filedialog eller en popup form der beder om sti hvis bruger ikke har permission
            //Evt også ikke tillade den at lave filen selv, men bede om en sti.

            try
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.WriteLine("Adresse".PadRight(10) + "PostNr".PadRight(8) + "Pris".PadRight(10) + "Areal (m^2)".PadRight(10) + "OprettelsesDato".PadRight(10)); //Formatering
                    foreach (Bolig b in list)
                    {
                        writer.WriteLine(b.Adresse.PadRight(10) + b.PostNr.ToString().PadRight(8) +
                                            b.Pris.ToString().PadRight(10) + b.Kvm.ToString().PadRight(10) + b.OprettelsesDato.ToString()); //Skriver bolig i fil
                    }
                }
                wasSuccessful = true;
            }
            catch(Exception) //Formentlig unødvendig try catch, men bare for at kunne returnere successkriteriet.
            {
                wasSuccessful = false;
            }
            return wasSuccessful;

        }


    }
}
