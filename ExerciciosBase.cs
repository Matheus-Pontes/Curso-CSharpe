namespace HelloWorld
{
    public class Program
    {
        static void Main() {

            Presentation();
            Console.WriteLine(" \n ========================== \n");
            GetYourFullName();
            Console.WriteLine(" \n ========================== \n");
            OperationsWithTwoNumbers();
            Console.WriteLine(" \n ========================== \n");
            CountLenghthWord();
            Console.WriteLine(" \n ========================== \n");
            ValidateCarPlate();
            Console.WriteLine(" \n ========================== \n");
            ShowManyFormatDateNow();
        }

        public static void Presentation()
        {
            Console.WriteLine("Hi, What's your name? \n");

            var nome = Console.ReadLine();

            Console.WriteLine($"Hello, World !!! Welcome, {nome}.");
        }

        public static void GetYourFullName()
        {
            Console.WriteLine("Hi, What's your first name?");

            var firstName = Console.ReadLine();

            Console.WriteLine("And now, last name: ");

            var lastName = Console.ReadLine();

            Console.WriteLine(string.Concat("Full name: ", firstName, " ", lastName));
        }

        public static void OperationsWithTwoNumbers()
        {
            var number1 = double.Parse(Console.ReadLine());
            var number2 = double.Parse(Console.ReadLine());

            var mult = number1 * number2;
            Console.WriteLine($"Valor multiplicação: {mult}");
            var soma = number1 + number2;
            Console.WriteLine($"Valor Soma: {soma}");
            var sub = number1 - number2;
            Console.WriteLine($"Valor Subtração: {sub}");
            if (number2 != 0)
            {
                var div = number1 / number2;
                Console.WriteLine($"Valor divisão: {div}");
            }
            else
            {
                Console.WriteLine($"Impossível dividir por 0 !!!");
            }
        }

        public static void CountLenghthWord()
        {
            var word = Console.ReadLine();

            if (!string.IsNullOrEmpty(word))
            {   
                //Substituir por REGEX
                var words = word.Split(" ").Where(w => w != " ").ToList();

                foreach(string w in words)
                {
                    Console.WriteLine($"Tamanho da palavra ({w}): {w.Length}");
                }


            }else
            {
                Console.WriteLine("Você não digitou nada.");
            }
        }

        public static void ValidateCarPlate()
        {
            var plate = Console.ReadLine();

            if (plate.Length == 7)
            {
                var firstPartPlate = plate.Substring(0, 3);
                var lastPartPlate = plate.Substring(4);

                bool todosSaoLetras = firstPartPlate.All(char.IsLetter);
                bool todosSaoNumeros = lastPartPlate.All(char.IsDigit);

                if (todosSaoLetras && todosSaoNumeros)
                    Console.WriteLine("VERDADEIRO");
                else
                    Console.WriteLine("FALSO");
            }
        }

        public static void ShowManyFormatDateNow()
        {
            

            Console.WriteLine("Selecione o tipo de formato para a data atual\n" +
                "1 - Completo\n" +
                "2 - Apenas (dd/mm/yyyy)\n" +
                "3 - Apenas hora no formato 24h\n" +
                "4 - Data com mÊs por extenso\n");

            var selection = Console.ReadLine();

            switch(selection)
            {
                case "1":
                    Console.WriteLine(DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
                    break;
                case "2":
                    Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
                    break;
                case "3":
                    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
                    break;
                case "4":
                    Console.WriteLine(DateTime.Now.ToString("dd, MMMM de yyyy"));
                    break;
            }
        }
    }
    
}
