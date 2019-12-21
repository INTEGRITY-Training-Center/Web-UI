using System;
using System.Collections.Generic;//list
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day11.DAL;

namespace day11
{
    class Program
    {
        List<EMPLOYERlist> lstemp = new List<EMPLOYERlist>();//for list all
        EMPLOYERlist emp = new EMPLOYERlist();//for one object

        static void Main(string[] args)
        {
            //EMP emp = new EMP();
            //Console.WriteLine(emp.SALARY);

            //EMP emp2 = new EMP(3500);//constructor mhar parameter use
            //Console.WriteLine(emp2.SALARY);

            List<EMPLOYERlist> lstemp = new List<EMPLOYERlist>();
            using (day8DataContext db = new day8DataContext())
            {
                var data = (from a in db.employerlists select a).ToList();
                
                foreach (var obj in data)
                {
                   EMPLOYERlist emp = new EMPLOYERlist();//for one object
                   emp.EmployerlistID= obj.Employerlist1;
                   emp.No = obj.No;
                   emp.Name = obj.Name;
                   emp.Remark = obj.Remark;
                   lstemp.Add(emp);
                }
            }
            foreach (var a in lstemp)
            {
                Console.Write(a.EmployerlistID + "\t");
                Console.Write(a.No + "\t");
                Console.Write(a.Name + "\t");
                Console.Write(a.Remark + "\n");

            }
           
        }
    }
    class EMP
    {
        private int salary = 200;
        public EMP()                  //polymophisym type
        {
            salary=2000; 
        }
        public EMP(int sal)          //polymophisym type
        {
            this.salary = sal;
        }
        public int SALARY           //default constructor type
        {
            set { salary = value; }
            get { return salary; }
        }
    }
    class EMPLOYERlist
    {
        public string EmployerlistID { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
    }
}
