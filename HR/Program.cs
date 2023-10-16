using HR;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Compony ");
        Employee employee = new Employee();
        Manager manager = new Manager();
        FI f = new FI();
        FI2 f2 = new FI2();
        string r;
        string r1;
        string set;
        Console.WriteLine("set your possission (employee / manager ) : ");
        set = Console.ReadLine();
        if (set == "employee")
        {
            Console.WriteLine("write down the data : name / id / account num / date of hiring :");
            employee.name = Console.ReadLine();
            employee.id = Console.ReadLine();
            employee.account_num = Convert.ToInt32(Console.ReadLine());
            employee.dt = Console.ReadLine();
            Manager m = new Manager();
            m.hiring(employee);
            m.showing();
            Console.WriteLine("/////////////////////////////////////////////////////////////");
            Console.WriteLine("paying system:");
            Console.WriteLine("enter your employee id :");
            r = Console.ReadLine();
            if (r == employee.id)
            {
                Console.WriteLine("employees payment each month : " + f.salary);
                f.paying();
                Console.WriteLine("- tax 90360 :");
                f.geting();
            }
            else
            {
                Console.WriteLine("you are not signed!!!!");
            }
        }
        else
        {
        Console.WriteLine("write down the data : name / id / account num / date of hiring :");
            manager.name = Console.ReadLine();
            manager.id = Console.ReadLine();
            manager.account_num = Convert.ToInt32(Console.ReadLine());
            manager.dt = Console.ReadLine();
            manager.hiringm(manager);
            manager.showingm();
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            Console.WriteLine("paying system:");
            Console.WriteLine("enter your manager id :");
            r1 = Console.ReadLine();
            if(r1==manager.id)
            {
                Console.WriteLine("manager payment each month : " + f2.m_salary);
                f2.paymanager();
                Console.WriteLine("+ extra 800000  :");
                f2.getmanager();
            }
            else
            {
                Console.WriteLine("you are not signed!!!!");
            }

        }


    
           
        }

    }
  
