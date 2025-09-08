using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando um Nokia
        Smartphone nokia = new Nokia("99999-1111", "Nokia Tijolão", "123456789012345", 64);
        Console.WriteLine("=== Teste com Nokia ===");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Criando um iPhone
        Smartphone iphone = new Iphone("88888-2222", "iPhone 15", "987654321098765", 128);
        Console.WriteLine("=== Teste com iPhone ===");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}