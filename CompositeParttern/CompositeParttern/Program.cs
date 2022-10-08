using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeParttern
{
    interface IEmployee
    {
        string Name { get; set; } //name
        string Dept { get; set; } //phong ban
        string Designation { get; set; } //chi dinh
        void DisplayDetails(); //Hien thi chi tiet
    }

    //leaf node -> nut la
    class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Designation { get; set; } //chi dinh
        public void DisplayDetails()
        {
            Console.WriteLine("\t {0} lam viec tai phong {1}. Chi dinh: {2},", Name, Dept, Designation);
        } //Hien thi chi tiet
    }
    //non - leaf node -> Không phải nút lá
    class CompositeEmployee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Designation { get; set; } //chi dinh
        private List<IEmployee> sublist = new List<IEmployee>();
       
        //add an employee
        public void AddEmployee (IEmployee e)
        {
            sublist.Add(e);
        }
        //remove an employee
        public void RemoveEmployee (IEmployee e)
        {
            sublist.Remove(e);
        }

        public void DisplayDetails()
        {

            Console.WriteLine("{0} lam viec tai phong {1}. Chi dinh: {2},", Name, Dept, Designation);

            foreach (IEmployee e in sublist)
            {
                e.DisplayDetails();
            }
        } //Hien thi chi tiet
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day la demo composite pattern");
            Employee Toan1 = new Employee { Name = "Nguyen tinh", Dept = "Khoa toan", Designation = "Giang vien"};
            Employee Toan2 = new Employee { Name = "Nguyen tien", Dept = "Khoa toan", Designation = "Giang vien"};
            CompositeEmployee HODToan = new CompositeEmployee { Name = "Nguyentinhs", Dept = "Khoa toan", Designation="Truong khoa" };


            // 2 GV khoa toan se bao cao truc tiep cho HOD Toan
            HODToan.AddEmployee(Toan1);
            HODToan.AddEmployee (Toan2);


            Employee CSEE1 = new Employee { Name = "Nguyen linh", Dept = "CSE", Designation = "Giang vien" };
            Employee CSEE2 = new Employee { Name = "Nguyen ka", Dept = "CSE", Designation = "Giang vien" };
            Employee CSEE3 = new Employee { Name = "Nguyen ka", Dept = "CSE", Designation = "Giang vien" };

            CompositeEmployee HODCSE = new CompositeEmployee { Name = "hungle", Dept = "CSE", Designation = "Truong khoa" };


            // 3 GV khoa cse se bao cao truc tiep cho HOD CSE 
            HODCSE.AddEmployee(CSEE1);
            HODCSE.AddEmployee(CSEE2);
            HODCSE.AddEmployee(CSEE3);


            CompositeEmployee HTTruong = new CompositeEmployee { Name = "Dr ka", Dept = "Ke hoach Hl", Designation = "Hieu Truong" };


            //2 HOD phai bao cao truc tiep cho HT
            HTTruong.AddEmployee(HODToan);
            HTTruong.AddEmployee(HODCSE);

            Console.WriteLine("Thong tin tu hieu truong");
            HTTruong.DisplayDetails();
            Console.WriteLine("----------------------");


            Console.WriteLine("Thong tin tu khoa CSE");
            HODCSE.DisplayDetails();
            Console.WriteLine("----------------------");
            Console.WriteLine("Thong tin cua GV toan 1");
            Toan1.DisplayDetails();

            Console.WriteLine("----------------------");

            // GV CSE 2 nop don nghi
            Console.WriteLine("GV {0} nop don nghi khoa {1}", CSEE2.Name, CSEE2.Dept);
            HODCSE.RemoveEmployee(CSEE2);
            HODCSE.DisplayDetails();

            Console.ReadKey();
        }
    }
}
