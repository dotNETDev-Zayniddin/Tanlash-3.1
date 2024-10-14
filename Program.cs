/*
Palindrome Tekshiruvi: Palindrom, so'zning boshidan oxiriga qadar o'qilgandagi tartibida ham,
 oxiridan boshiga qadar o'qilgandagi tartibida ham bir xil bo'lgan so'z yoki satrdir. 
 Misol uchun, "kayak", "radar" va "level" so'zlari palindromlarga misol bo'lishi mumkin. 
 Sizdan kiritilgan satrning palindrom bo'lishini tekshiruvchi dastur yozishni so'raymiz. 
 Agar kiritilgan satr palindrom bo'lsa, dastur "Palindrom" degan xabarni chiqaradi, 
 aks holda "Palindrom emas" degan xabarni chiqaradi.
Input: "kayak"
Output: "Palindrom"

*/
using System;
namespace Tanlash
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("So'zni kiriting: ");
            string userInput = Console.ReadLine();
            string checkingInput = "";
            for(int i = userInput.Length - 1; i >= 0; i--)
            {
                checkingInput += $"{userInput[i]}";
            }
            System.Console.WriteLine(checkingInput);
            if(checkingInput == userInput)                          // <= Boshqa g'oya kelmadi. Tanlash operatorlari bilan ishlay olmadim.
            {
                System.Console.WriteLine($"{checkingInput} so'zi Palindrom");
            }
            else
            {
                System.Console.WriteLine($"{userInput} so'zi Palindrome emas");
            }
        }
    }
}
