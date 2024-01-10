namespace Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Random rnd = new Random();
            
            Console.WriteLine("Enter the first number : ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the last number : ");
            int last = int.Parse(Console.ReadLine());
            Console.WriteLine("How Many numbers you want : ");
            int howmany = int.Parse(Console.ReadLine());

            int[] numbers = new int[howmany];
            int number;
            for (int i = 0; i < numbers.Length; i++)
            {
                number = rnd.Next(first, last);
                if (i == 0)
                {
                    numbers[i] = number;
                }

                for (int j = 0; j < i; j++)  //BU KOD BLOĞU BİR ÖNCEKİ İ DEĞERLERİNİN TEKRAR GELİP GELMEDİĞİNİ KONTROL EDİYOR
                {
                    if (numbers[j] == number)
                    {
                        i--;  // BURADA EĞER AYNI DEĞER VAR İSE İ Yİ AZALTIYOR SEBEBİ ÖRNEĞİN 12 13 VE 3. DEĞERE TEKRAR 12 ATADI 3. DEĞERİ ALMADIĞI İÇİN YENİ BİR DEĞİŞKEN OLUŞTURMASI GEREKİYOR. O DEĞİŞKENİ DE OLUŞTURMASI İÇİN ÜSTTEKİ FOR DDÖNGÜSÜNE TEKRAR GİRMESİ GEREKİYOR ANCAK SINIRLAMASI OLDUĞU İÇİN DÖNEMİYOR.
                        break;
                    }
                    else
                    {
                        numbers[i] = number;
                    }
                }
            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}



