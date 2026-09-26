public class Program// Questa è una classe

{
    //metodo di entrata per esecuzione del codice
    public static void Main()
    {
       

        //stampa a video il messaggio per chiedere il nome del cliente
        Console.WriteLine("insrisci il nome del cliente");

        //console.readline() mi permette di leggere l'imput dell'utentte da console
        string nomeCliente = Console.ReadLine();//dichiarazione+assegnazione
        Console.WriteLine($"Benvenuto {nomeCliente} nella libreria Easy class 3E!");

        Console.WriteLine("Inserisci il tipo di spedizione");
        string tipoConsegna=Console.ReadLine();

        Console.WriteLine("Inserisci il numero di pacchi aqcuistati");
        int numeroPacchiAqcuistati =int.Parse(Console.ReadLine());



        int costoSpedizioneSingoloPacco;//dichiarzione+assegnazione
        costoSpedizioneSingoloPacco = 10;//assegnazione

        int numeroPacchiComprati = 2;


        string tipoconsegna= "Standard";//dichiarazione

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;

        //stampa a video con concatenazione di stringhe e variabili
        //$ è il carattere speciale per l'interpolazione di stinghe
        //che permette di inserire variabili all'interno di una stringa di messaggio
        Console.WriteLine($"il tipo di consegna selezionato è: {tipoconsegna} e il costo totale è: {costoTotale}");
        
    }
}
    

