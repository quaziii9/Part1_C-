namespace Part1_C_.Section4
{
    internal class S4_10
    {
        static void Main(string[] args)
        {
            string name = "Harry Potter";

            // 1. 찾기
            bool found = name.Contains("Harry");
            Console.WriteLine(found);
            int index = name.IndexOf('P');
            Console.WriteLine(index);

            // 2. 변형
            name = name + " Junior";
            Console.WriteLine(name);

            string lowerCastName = name.ToLower();
            Console.WriteLine(lowerCastName);
            string UpperCastName = name.ToUpper();
            Console.WriteLine(UpperCastName);
            string newName = name.Replace('r', 'l');
            Console.WriteLine(newName);

            // 3. 분할 
            string[] names = name.Split(new char[] { ' ' });

            for (int i = 0; i < names.Length; i++) { Console.Write($"{i} : {names[i]}  "); }
            Console.WriteLine();
            string substringName = name.Substring(5);
            Console.WriteLine(substringName);
        }
    }
}
