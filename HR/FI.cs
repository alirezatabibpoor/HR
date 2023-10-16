using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR;

namespace HR
{
    internal class FI:Bank
    {
        public long salary = 108004;
        public long tax = 90360;
      public  Employee employee = new Employee();
        
      
        public void paying()
        {
            Console.WriteLine("rewrite your account num : ");
            employee.account_num = Convert.ToInt32(Console.ReadLine());
            long z;
            z = employee.account_num + salary;
            Console.WriteLine(z + "accounts existion");
            money = money - salary;
            Console.WriteLine("banks exsition : " + money);



        }
        public void geting()
        {
            long h;
            long h1;
            h =  employee.account_num+salary - tax;
            
            Console.WriteLine(h + "account existion ");
            money = money + tax;
            
            Console.WriteLine("bank exision :" + money);
        }
    }
}
public class Bank
{
    public long money = 100000000000000000;
   public long  amount = 90000000000000000;
    
}
