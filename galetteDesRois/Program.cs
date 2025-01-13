using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Définir une liste de prénoms (ajustez en fonction des participants)
        List<string> participants = new List<string>
        {
            "Alice", "Bob", "Charlie", "David", "Eve", "Nathan", "Julien"
        };

        
        Random random = new Random();

        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("*********************************************************");
        Console.WriteLine("   Bienvenue à la distribution de la Galette des Rois   ");
        Console.WriteLine("*********************************************************");
        Console.WriteLine("\r\n                   ____                  \r\n                _.' :  `._               \r\n            .-.'`.  ;   .'`.-.           \r\n   __      / : ___\\ ;  /___ ; \\      __  \r\n ,'_ \"\"--.:__;\".-.\";: :\".-.\":__;.--\"\" _`,\r\n :' `.t\"\"--.. '<@.`;_  ',@>` ..--\"\"j.' `;\r\n      `:-.._J '-.-'L__ `-- ' L_..-;'     \r\n        \"-.__ ;  .-\"  \"-.  : __.-\"       \r\n            L ' /.------.\\ ' J           \r\n             \"-.   \"--\"   .-\"            \r\n            __.l\"-:_JL_;-\";.__           \r\n         .-j/'.;  ;\"\"\"\"  / .'\\\"-.        \r\n       .' /:`. \"-.:     .-\" .';  `.      \r\n    .-\"  / ;  \"-. \"-..-\" .-\"  :    \"-.   \r\n .+\"-.  : :      \"-.__.-\"      ;-._   \\  \r\n ; \\  `.; ;                    : : \"+. ; \r\n :  ;   ; ;                    : ;  : \\: \r\n");
        Console.ResetColor();
        Console.WriteLine("\nAppuyez sur une touche pour commencer...");
        Console.ReadKey();
        Console.Clear();

        
        int indexCoupeur = random.Next(participants.Count);
        string coupeur = participants[indexCoupeur];
        participants.RemoveAt(indexCoupeur);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{coupeur} va couper la galette !");
        Console.ResetColor();
        Console.WriteLine("\nAppuyez sur une touche pour commencer la distribution...");
        Console.ReadKey();
        Console.Clear();


        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("La distribution des parts commence !");
        Console.ResetColor();

        int indexRoi = random.Next(participants.Count);
        string roi = participants[indexRoi];

        while (participants.Count > 0)
        {
            int indexPart = random.Next(participants.Count);
            string destinataire = participants[indexPart];
            participants.RemoveAt(indexPart);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{destinataire} reçoit une part de la galette !");
            Console.ResetColor();
            System.Threading.Thread.Sleep(500);
        }


        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nToutes les parts ont été distribuées !");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("*********************************************************");
        Console.WriteLine("   Qui a trouvé la fève ?   ");
        Console.WriteLine("*********************************************************");
        Console.ResetColor();
        Console.WriteLine("\nAppuyez sur une touche pour le découvrir...");
        Console.ReadKey();
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{roi} a trouvé la fève !");
        Console.WriteLine("*********************************************************");
        Console.WriteLine($"Longue vie à {roi} !");
        Console.WriteLine("*********************************************************");
        Console.WriteLine($"{roi} va maintenant vous couper la tête. Merci d'avoir participé !");
        Console.ReadKey();
    }
}
