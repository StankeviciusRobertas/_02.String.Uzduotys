namespace _02.String.Uzduotys
{
    internal class String
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("=========================================");            

            string word = "Kava ir puikaus skonio";
            Console.WriteLine(word[2]);
            Console.WriteLine(word.Length);
            
            Console.WriteLine("=========================================");

            string myName = "Mano vardas Robertas";
            Console.WriteLine(myName.Substring(12));
            Console.WriteLine(myName.Substring(0, 4));

            Console.WriteLine("=========================================");

            string sentence = "   Robertas";
            Console.WriteLine(sentence.Replace("R", "B"));
            Console.WriteLine(sentence.IndexOf("b"));
            Console.WriteLine(sentence.Trim());
            Console.WriteLine(sentence.ToLowerInvariant());
            Console.WriteLine(sentence.ToUpperInvariant());

            Console.WriteLine("=========================================");
        }
    }
}