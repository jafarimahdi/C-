using System;
using ModuleApp.ConsoleUI;
using ModuleApp.Repository;
using ModuleApp.Models;


namespace ModuleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int panelNumber = Ui.ShowMainMenu();

            UserRepository userRepository = new UserRepository();
            ReportRepository reportRepository = new ReportRepository();


            while (true)
            {
                switch (panelNumber)
                {
                    case 1:
                        #region admin panel
                        Console.Write("Enter User Name. ");
                        string userName = Console.ReadLine();
                        Console.Write("Enter Password ");
                        string password = Console.ReadLine();
                        bool userLogined = userRepository.Login(userName, password);

                        if (!userLogined)
                        {
                            Console.WriteLine(" UserName or Password is not Correct ! ");
                            Console.ReadKey();
                            panelNumber = Ui.ShowMainMenu();

                        }
                        else
                        {
                            while (userLogined)
                            {

                                int adminCommandNumber = Ui.ShowAdminPanel();
                                switch (adminCommandNumber)
                                {
                                    case 1:
                                        userRepository.ShowAllUsers();
                                        break;
                                    case 2:
                                        User user = new User();

                                        user.UserId = userRepository.GetNewId();

                                        Console.Write("Enter UserName: ");
                                        user.UserName = Console.ReadLine();

                                        Console.Write("Enter Password: ");
                                        user.Password = Console.ReadLine();

                                        Console.Write("Enter Mobile ");
                                        user.MobileNumber = Console.ReadLine();

                                        Console.Write("Enter Email ");
                                        user.Email = Console.ReadLine();

                                        user.IsActive = true;
                                        user.UserRole = Role.Employee;

                                        userRepository.AddEmployee(user);
                                        Console.ReadKey();
                                        break;

                                    case 3:
                                        Console.WriteLine("please Enter the user ID ");
                                        int userId = Convert.ToInt32(Console.ReadLine());

                                        userRepository.DeleteUser(userId);
                                        break;

                                    case 4:
                                        panelNumber = Ui.ShowMainMenu();
                                        break;
                                }
                            }
                        }
                        #endregion End of Admin panel
                        break;

                    case 2:
                        //employee panel
                        Console.Write("Enter UserName... ");
                        string userName1 = Console.ReadLine();
                        Console.Write("Enter Password ...");
                        string password1 = Console.ReadLine();
                        User user1 = userRepository.GetUser(userName1, password1);

                        bool userLogined1 = userRepository.Login(userName1, password1);

                        if (!userLogined1 || user1.UserRole != Role.Employee)
                        {
                            Console.WriteLine(" UserName or Password is not Correct ! ");
                            Console.ReadKey();
                            panelNumber = Ui.ShowMainMenu();

                        }
                        else
                        {
                            while (userLogined1)
                            {
                                int employeeCommandNumber = Ui.ShowEmployeePanel();

                                User user = userRepository.GetUser(userName1, password1);
                                switch (employeeCommandNumber)
                                {
                                    case 1:
                                        Report report = new Report();
                                        report.ReportId = reportRepository.GetNewReportId();
                                        report.UserId = user1.UserId;
                                        report.ReportDate = DateTime.Now;
                                        Console.Write("Enter Report Text: ");
                                        report.ReportText = Console.ReadLine();

                                        bool flag = reportRepository.RegisterReport(report);
                                        if (flag)
                                        {
                                            Console.WriteLine(" success ....");
                                        }
                                        Console.ReadKey();
                                        break;

                                    case 2:
                                        reportRepository.showAllReportByUserId(user1.UserId);

                                        break;
                                    case 3:

                                        break;
                                    case 4:
                                        userLogined1 = false;
                                        panelNumber = Ui.ShowMainMenu();
                                        break;

                                }
                            }
                        }

                        break;
                }
            }

        }
    }
}

