using ConsoleApp2;

namespace session1
{
    class Program
    {


        Human human;
        static Human[] humans = new Human[4];

        [Flags]
        enum permission
        {
            select = 1,
            insert = 2,
            update = 4,
            delete = 8
        }
         
        static void Main(string[] args)
        {
         
            for (int i = 0; i < humans.Length; i++)
            {
                humans[i] = new Human();
            }

            humans[0].username = "manager";
            humans[0].password = "manager2025";
            humans[0].role = "manager";
            humans[0].AddPermission((ConsoleApp2.permission)(permission.insert | permission.update | permission.delete));

            humans[1].username = "admin";
            humans[1].password = "admin2025";
            humans[1].role = "admin";
            humans[1].AddPermission((ConsoleApp2.permission)(permission.insert | permission.update));

            humans[2].username = "supervisor";
            humans[2].password = "supervisor2025";
            humans[2].role = "supervisor";
            humans[2].AddPermission((ConsoleApp2.permission)(permission.insert));

            humans[3].username = "user";
            humans[3].password = "user2025";
            humans[3].role = "user";

            // Fix: Create an instance of Program to call the non-static method
            Console.WriteLine("Welcome to the system");
            Program program = new Program();
            program.SystemStart();
        }


        public void SystemStart() { 
            Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            ChooseObject(username, password);

        }
        public void ChooseObject(String user, String pass) {
            String username = user;
            String password = pass;
            if (username == "manager" && password == "manager2025")
            {
                human = humans[0];
                list();


            }
            else if (username == "admin" && password == "admin2025")
            {
                human = humans[1];
                list();
            }
            else if (username == "supervisor" && password == "supervisor2025")
            {
                human = humans[2];
                list();
            }
            else
            {
                human = humans[3];
                list();
            }



        }
        public void list()
        {
            Console.WriteLine("1:select");
            Console.WriteLine("2:delete");
            Console.WriteLine("3:update");
            Console.WriteLine("4:insert");
            Console.WriteLine("5:choose another role");
            Console.WriteLine("6: exit");
            int task = int.Parse(Console.ReadLine());
            Console.Clear();
            Task(task);
        }

        public void Task(int tas)
        {
            int task = tas;
            switch (task)
            {
                case 1:
                    human.Select();
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------");
                    list();
                    break;
                case 2:
                    human.Delete();
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------");
                    list();
                    break;
                case 3:
                    human.Update();
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------");
                    list();
                    break;
                case 4:
                    human.Insert();
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------");
                    list();
                    break;
                case 5:
                     SystemStart();
                    break;
                case 6:
                      Console.WriteLine("bye bye!");
                    break;
                default:
                    Console.WriteLine("Invalid task selected.");
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------");
                    list();
                    break;
            }


        }
    }

}