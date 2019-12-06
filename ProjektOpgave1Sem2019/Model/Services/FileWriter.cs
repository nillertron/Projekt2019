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
        public static bool BoligerTilSalgToFile(string filePath)
        {
            bool wasSuccessful;
            var list = new List<Bolig>();
            list = BoligTabelDB.GetAllNotSold();

            //har lige udkommenteret denne linje
            //List<Bolig> list = BoligTabelDB.GetAllNotSold(); //Hent boliger fra database Per opgave 3.2 beskrivelse
            //var list = new List<Bolig>();
            list.Sort(); //Sorter liste. Bolig implementerer ICompareable, som sammenligner på pris og sorterer billigs først
            FileStream fs;
            //En lille "metode til at sikre sig at det bliver en txt fil
            var index = filePath.LastIndexOf('.');
            if (index > 0)
                filePath = filePath.Substring(0, index);
            filePath += ".txt";

            try
            {
                if (filePath == "")
                    throw new IOException("Tom sti");
                else
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
            var index = filePath.LastIndexOf('.');
            if (index > 0)
                filePath = filePath.Substring(0, index);
            filePath += ".txt";

            try
            {
                if (filePath == "")
                    throw new IOException("Tom sti");
                else
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
        public static void UdskrivKøberKontrakt  ( string filePath, SolgtBolig b)
        {
            FileStream fs;

            try
            {
                if (filePath == "")
                    throw new IOException("Tom sti");
                else
                    fs = File.OpenWrite(filePath+"/KøberKontrakt" + b.Adresse+".txt");
            }
            catch (FileNotFoundException) //Hvis filen ikke eksisterer, opret istedet
            {
                fs = File.Create(filePath + "/KøberKontrakt" + b.Adresse + ".txt");
            }

            try
            {

                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        writer.WriteLine($"Kontrakt til køber vedr. hus på Adresse {b.Adresse} i postnummer {b.PostNr}");
                        writer.WriteLine($"Aftalt pris lyder på {b.KøbsPris} og købs dato er på {b.KøbsDato.ToString("dd-MM-yyyy")}");
                    writer.WriteLine($"Du er som køber: {b.køber.Navn} {b.køber.Efternavn} og den registrerede sælger er {b.sælger.Navn} {b.sælger.Efternavn} ");

                    writer.WriteLine($"Køber underskrift________________________________ Dato: {DateTime.Now.ToString("dd-MM-yyyy")}");
                    writer.WriteLine($"Sælger underskrift________________________________ Dato: {DateTime.Now.ToString("dd-MM-yyyy")}");


                }

            }
            catch (IOException ee) //Formentlig unødvendig try catch, men bare for at kunne returnere successkriteriet.
            {
                System.Windows.Forms.MessageBox.Show(ee.Message);
            }

        }
                  
public static void UdskrivSælgerKontrakt(string filePath, SolgtBolig b)
{
    FileStream fs;

    try
    {
                if (filePath == "")
                    throw new IOException("Tom sti");
                else
                    fs = File.OpenWrite(filePath + "/SælgerKontrakt" + b.Adresse + ".txt");
    }
    catch (FileNotFoundException) //Hvis filen ikke eksisterer, opret istedet
    {
        fs = File.Create(filePath + "/SælgerKontrakt" + b.Adresse + ".txt");
    }

    try
    {

        using (StreamWriter writer = new StreamWriter(fs))
        {
            writer.WriteLine($"Kontrakt til sælger vedr. hus på Adresse {b.Adresse} i postnummer {b.PostNr}");
            writer.WriteLine($"Aftalt pris lyder på {b.KøbsPris} og købs dato er på {b.KøbsDato.ToString("dd-MM-yyyy")}");
           writer.WriteLine($"Du er som sælger: {b.sælger.Navn} {b.sælger.Efternavn} og den registrerede køber er {b.køber.Navn} {b.køber.Efternavn}");
            writer.WriteLine($"Køber underskrift________________________________ Dato: {DateTime.Now.ToString("dd-MM-yyyy")}");
            writer.WriteLine($"Sælger underskrift________________________________ Dato: {DateTime.Now.ToString("dd-MM-yyyy")}");


        }

    }
    catch (IOException ee)
    {
        System.Windows.Forms.MessageBox.Show(ee.Message);
    }

}
    }
}
