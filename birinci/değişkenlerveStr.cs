using Microsoft.VisualBasic;

namespace emregurbuz;

class Program
{
    static int a; 
    static float b;
    static bool c;
    static string d = "";
    static char e;
    public static string f = "bu değişkeni tüm claslar erişir";

    private static string g = "bu değişken sadece bulunduğu classtan erişilir";
    static void Main(string[] args)
    {
        var ab = 123; // yerelde oluşturursun içene attığın değerin türünü kendi anlar.
        a = 12;
        b = 1.1f; // ondalıkta "f" yada tam sayı decimalde "m"
        c = true;
        d = "\"hi\n brom\" "; // \n satır sonu, \t tab kadar boşluk, \"selam\" (\'= karakterse) = "selam", \\ = \, @"string" şekilde kullanılırsa  \\ bunu kullanmana gerek yok.
        e = 'a'; // tek karakter
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine(g);
        Console.WriteLine(ab);

        var birinci = "1.birinci";
        var ikinci = "2.ikinci";

        Console.WriteLine(birinci + ikinci + "3.üçüncü");  //$"{değişken} {değişken} string"  //$@"c:dosya\{değişken}\...\...\"  

    }
}
