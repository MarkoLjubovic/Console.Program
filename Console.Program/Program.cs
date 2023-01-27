using Console.Program.Class;
using Console.Program.Validations;

public class Program
{
    public static void Main(string[] args)
    {
        Storage storage = new Storage();
        Validation validation = new Validation();

        Service s = new Service();
        s.Pozdrav();
        s.UnosPodatak(storage.Knjige, storage.dVDs, storage.audioBooks, validation);
    }
}