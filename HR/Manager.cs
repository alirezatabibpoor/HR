using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    
    internal class Manager
    {
        public List<Employee> employees = new List<Employee>(); 
        public List<Manager>managers = new List<Manager>();
        
      public  Employee m = new Employee();
       
        public string name;
        public string id;
        public string account;
        public long account_num;
        public string dt;

        public void  hiring( Employee m)
        {
            
           employees.Add( m );
           
            
            
        }
        public void hiringm( Manager manager )
        {
            managers.Add( manager );
        }
        public void firing(Employee m )
        {
            
            
            employees.Clear();
        }
        public void firingm()
        {
            managers.Clear();
        }
        public void showing()
        {
            
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee.name +","+ employee.id + ",  " + employee.account_num + "," + employee.dt);
            }
            
        }
        public void showingm()
        {
            foreach(Manager manager in managers)
            {;
                Console.WriteLine( manager.name + "," + manager.id + ",  " + manager.account_num + "," + manager.dt);
            }
        }
    }
}
