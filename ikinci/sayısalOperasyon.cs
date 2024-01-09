using Microsoft.VisualBasic;

namespace emregurbuz1;

class sayısalOperasyon
{
    static void Main(string[] args)
    {
        // Toplama 
        var say1 = 32;
        var say2 = 64;

        Console.WriteLine(say1 + say2);

        Console.WriteLine(say1 + say2 + "sa");

        Console.WriteLine(say1 + "sa" +say2);

        Console.WriteLine(say1 + "sa" + 12 + say2);

        Console.WriteLine(say1 + "sa" + (12 + say2));


        //4 işlem
        // toplama:  +
        // çıkarma:  -
        // çarpma:   *
        // bölme:    /
        // bölme işleminde tanımlarken float tanımlayıp (float a = xf / y) ilk sayıya f ekle


        // Casting

        var tam = 12;

        Console.WriteLine((float)tam / 7);

        // Mod almak         ilksayı% ikinci sayı;

        // işlem sırası

        // ()-> kuvvetler -> çarpma bölme soldan sağa -> toplama çıkarma

        // operatörler

        // x+=a    x =  x+a
        // x-=a    x =  x-a
        // x*=a    x =  x*a
        // x/=a    x =  x/a
        // ++      x =  x+1
        // --      x =  x-1



    }

}