using System;
using ModuleApp.ConsoleUI;
using ModuleApp.Repository;


namespace ModuleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           int PanleNumber = Ui.ShowMainMenu();
           UserRepository userRepository = new UserRepository();


            while (true)
            {
                switch (PanleNumber)
                {
                    case 1:
                        int adminCommandNumber = Ui.ShowAdminPanel();
                        switch (adminCommandNumber)
                        {
                            case 1:
                                userRepository.ShowAllUsers();
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                PanleNumber = Ui.ShowMainMenu();
                                break;
                        }
                        break;

                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }

        }
    }
}

