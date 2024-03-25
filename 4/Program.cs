using ClassLibrary.Data;

public class Program
{
    public static void Main(string[] args)
    {
        var _context = new AdatContext();
        
        if (!_context.Nyilvantartasok.Any())
        {
            var sorok = File.ReadAllLines(@"C:\Users\cinti\OneDrive\Asztali gép\jagerattila\Datas\4.csv").Skip(1);

            foreach (var item in sorok)
                _context.Nyilvantartasok.Add(new ClassLibrary.Models.Nyilvantartas(item));
            _context.SaveChanges();
            Console.WriteLine("Emberek feltöltése sikeres!");
        }

        foreach (var item in _context.Nyilvantartasok)
        {
            Console.WriteLine(item);
        }
    }
}