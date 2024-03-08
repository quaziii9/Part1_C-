namespace S7
{
    internal class S7_5
    {
        static void OnInputTest()
        {
            Console.WriteLine("Input Received!");
        }

        static void Main(string[] args)
        { 
            InputManager inputManager = new InputManager();

            inputManager.InputKey += OnInputTest;

            while(true)
            {
                inputManager.Update();
            }

        }
    }
}
