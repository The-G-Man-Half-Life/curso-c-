namespace UndecimaClaseTarea.Models;

public class VisualInterface
{
    public static void RunProgram()
    {
        List<Coder> Coders = new List<Coder>{
            new Coder("John", "Doe", "john.doe@example.com", "123-456-7890"),
            new Coder("Jane", "Smith", "jane.smith@example.com", "098-765-4321")
        };
        var riwi = new Riwi(Coders);
        bool flag = true;
        while (flag == true)
        {
            Console.Write("Press any key to continue:");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(
                "╔══════════════════════════════════════════════════════════╗\n" +
                "║                   MENÚ PRINCIPAL                         ║\n" +
                "╠══════════════════════════════════════════════════════════╣\n" +
                "║ 1. Agregar un coder                                      ║\n" +
                "║ 2. Borrar un coder                                       ║\n" +
                "║ 3. Mostrar los coders                                    ║\n" +
                "║ 4. Actualizar datos de un coder                          ║\n" +
                "║ 5. Salir                                                 ║\n" +
                "╚══════════════════════════════════════════════════════════╝"
            );
            Console.WriteLine(@"
Enter the number of the ption to continue: ");

            int option = Convert.ToInt16(Console.ReadLine());

            switch (option)
            {
                case (1):
                Console.Clear();
                riwi.AddANewCoder();
                    break;
                case (2):
                Console.Clear();
                riwi.DeleteACoder();
                    break;
                case (3):
                Console.Clear();
                riwi.ShowCoders();
                    break;
                case (4):
                Console.Clear();
                riwi.UpdateACoder();
                    break;
                case (5):
                Console.Clear();
                    Console.WriteLine("Adios");
                    flag = false;
                    Console.Clear();
                    break;
                default:
                Console.Clear();
                Console.WriteLine("You must choose an option in range");
                    break;
            }
        }

    }
}