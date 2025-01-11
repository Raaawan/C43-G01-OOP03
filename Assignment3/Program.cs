namespace Assignment3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region Question 1
            //Employee employee = new Employee(1, "Mohamed", SecurityLevel.guest, 75000, new HiringDate(25, 4, 2001), 'M');

            //Console.WriteLine(employee);


            #endregion

            #region Question 2
            //HiringDate hiringDate = new HiringDate(25, 4, 2001);
            //Console.WriteLine(hiringDate);
            #endregion

            #region Question 3,4
            //Employee[] EmpArr = new Employee[3];

            //EmpArr[0] = new Employee(1, "Mohamed", SecurityLevel.FullPermissions, 75000, new HiringDate(26, 9, 1985), 'M');
            //EmpArr[1] = new Employee(1, "aLi", SecurityLevel.guest, 90000, new HiringDate(9, 7, 1658), 'M');
            //EmpArr[2] = new Employee(1, "Rawan", SecurityLevel.DBA, 2500, new HiringDate(25, 4, 2001), 'M');

            //foreach (Employee emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //    Console.WriteLine();
            //}
            //Array.Sort(EmpArr);
            //foreach (Employee emp in EmpArr) { 
            //    Console.WriteLine(emp);
            //}
            //DateTime[] datetim = new DateTime[3] ;
            //datetim[0] = new DateTime(2001,2,3);
            //datetim[1] = new DateTime(2006, 9, 3);
            //datetim[2] = new DateTime(2004, 12, 3);
            //Array.Sort(datetim);
            //foreach (DateTime dt in datetim) { 
            //    Console.WriteLine(dt.ToString());
            //}

            #endregion


            #region Question 5
            Book book1 = new EBook("EBook titlee", "Author Mohamed", "25896", 6);
            Book book2 = new PrintedBook("Printed Book Title", "Author Rawan", "987463", 19);

            
            Console.WriteLine(book1);
            Console.WriteLine(book2);
            #endregion


        }
    }
}
