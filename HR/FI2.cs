using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    internal class FI2 : Bank
    {
        public long m_salary = 1500000;
        public long m_extra= 800000;
        public Manager manager = new Manager();

        public void paymanager()
        {
            Console.WriteLine("rewrite your account num : ");
            manager.account_num = Convert.ToInt64(Console.ReadLine());
            long n;
            n = manager.account_num + m_salary;
            Console.WriteLine(n + "accounts existion");
            money = money - m_salary;
            Console.WriteLine("banks exsition : " + money);
        }
        public void getmanager()
        {
            long h;
            h = manager.account_num + m_extra + m_salary;

            Console.WriteLine(h + "account existion ");
            money = money - m_extra;
            Console.WriteLine("bank exision :" + money);
        }
    }
}







