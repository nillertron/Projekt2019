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
        
       //private static string filePath = @"C:\Users\marti\BoligListe.txt";
        public static bool BoligerTilSalgToFile(string filePath, List<Bolig> list)
        {
            bool wasSuccessful;

            //har lige udkommenteret denne linje
            //List<Bolig> list = BoligTabelDB.GetAllNotSold(); //Hent boliger fra database Per opgave 3.2 beskrivelse
            //var list = new List<Bolig>();
            list.Sort(); //Sorter liste. Bolig implementerer ICompareable, som sammenligner på pris og sorterer billigs først
            FileStream fs;

            try
            {
                fs = File.OpenWrite(filePath); 
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

        //Nichlas laver lige en ekstra kopieret metode for at udskrive sælger info
        public static void UdskrivBoligerIbestemtPostNr(string filePath, List<Bolig> list)
        {
            list = list.OrderBy(o => o.Adresse).ToList(); 
            FileStream fs;

            try
            {
                fs = File.OpenWrite(filePath);
            }
            catch (FileNotFoundException) //Hvis filen ikke eksisterer, opret istedet
            {
                fs = File.Create(filePath);
            } 

            try
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.WriteLine("Adresse".PadRight(10) + "PostNr".PadRight(8) + "Pris".PadRight(10) + "Areal (m^2)".PadRight(10) + "OprettelsesDato".PadRight(20) + "Sælger navn".PadRight(20) + "Sælger Tlf".PadRight(10)); //Formatering
                    foreach (Bolig b in list)
                    {
                        writer.WriteLine(b.Adresse.PadRight(10) + b.PostNr.ToString().PadRight(8) +
                                            b.Pris.ToString().PadRight(10) + b.Kvm.ToString().PadRight(10) + b.OprettelsesDato.ToString().PadRight(25) + b.sælger.Navn.PadRight(15) + b.sælger.TelefonNr.PadRight(10) ); //Skriver bolig i fil
                    }
                }
            }
            catch (IOException ee) //Formentlig unødvendig try catch, men bare for at kunne returnere successkriteriet.
            {
                System.Windows.Forms.MessageBox.Show(ee.Message);
            }

        }
    }
}
