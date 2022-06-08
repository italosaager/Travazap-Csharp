using WindowsInput;

namespace Travazap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a mensagem que você deseja enviar");
            string resposta = Console.ReadLine();
            InputSimulator inputSimulator = new InputSimulator();   

            for (int i = 0; i <= 4; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Contagem regressiva até o envio:" + (5 - i));
            }
            for (int i = 1; i <=1000 ; i++)
            {
                inputSimulator.Keyboard.TextEntry(resposta + " - " + i);
                Thread.Sleep(500);
                inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
            }
            
            Console.ReadLine();
        }
    }
}




