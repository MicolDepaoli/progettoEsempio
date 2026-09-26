public class Program// Questa è una classe

{
    //metodo di entrata per esecuzione del codice
    public static void Main()
    {
       Console.WriteLine("Benvenuto nella libreria Easy class 3E!");

        int costoSpedizioneSingoloPacco;//dichiarzione+assegnazione
        costoSpedizioneSingoloPacco = 10;//assegnazione

        int numeroPacchiComprati = 2;


        string tipoconsegna= "Standard";//dichiarazione

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;

        //stampa a video
        Console.WriteLine($"il tipo di consegna selezionato è: {tipoconsegna} e il costo totale è: {costoTotale}");
        
    }
}
    

