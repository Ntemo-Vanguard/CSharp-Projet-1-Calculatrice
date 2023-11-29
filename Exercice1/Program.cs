using System;
using System.Xml;
using Exercice1;


            int a, b;
            string getRep, op;
            bool rep = false;

            Operation ope = new Operation();

            Console.Write("Tu peux faire des operations avec ce programme :\n");
            
            do
            {
                do
                {
                    Console.Write("Entrer le 1er nombre :  \r\n");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Entrer le 2eme nombre :  \r\n");
                    b = Convert.ToInt32(Console.ReadLine());

                }while(a <= 0 && b <= 0);
                Console.WriteLine("Votre operation, mon frere : ");
                Console.WriteLine("1- 'A' pour l'addition \n 2- 'B' pour la soustraction \n 3- 'C' pour la multiplication \n 4- 'D' pour la division");
                op = Console.ReadLine();


            switch (op){
                        case "a":
                            Console.WriteLine("{0} + {1} = {2}", a, b, ope.addition(a,b));
                            break;
                        case "b":
                            Console.WriteLine("{0} - {1} = {2}", a, b, ope.soustraction(a, b));
                            break;
                        case "c":
                            Console.WriteLine("{0} x {1} = {2}", a, b, ope.multiplication(a, b));
                            break;
                        case "d":
                            Console.WriteLine("{0} / {1} = {2}", a, b, ope.division(a, b));
                            break;
             }
    
    
                 Console.WriteLine("Saisissez z pour faire un autre calcul ou x pour quitter");
                 getRep = Console.ReadLine();
                 rep = getRep.ToUpper()=="Z"?true:false;
            } while (rep);
