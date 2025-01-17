namespace Linq_Day1
{
    class EmployeeDTO
    {
        public long EmpId { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region sequence List
            //var employees = new List <Employee> ();
            ////employees.Add(new Employee(220, "Essam", 3000));
            ////employees.Add(new Employee(220, "ali", 3000));
            ////employees.Add(new Employee(3, "Shreen", 4000));
            ////employees.Add(new Employee(7, "Mohamed", 5000));
            ////employees.Add(new Employee(9, "Ahmed", 7000));
            ////employees.Add(new Employee(12, name: "Alaa", 6000));
            ////employees.Add(new Employee(20, "Fatma", 7000));
            ////employees.Add(new Employee(11100, "Hala", 3000));
            ////employees.Add(new Employee(120, "Mahmoud", 10000));
            ////employees.Add(new Employee(200, "Anwer", 50000));
            #endregion
        

            #region Implicit Type Local
            //var name = "Essam";
            //name = new Object();
            //name =9;
            //var age = null;
            //var salary;
            //Method return Type val  XX
            //field property ==> var  XX
            #endregion


            #region Linq Version Systax
            //40   ==> 20

            //v1  Extention Method   //Fluent Synatax    90%
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] % 2==0)
            //        Console.WriteLine(numbers[i]) ;
            //}

            //var postiveNumbers = numbers.Where(a => a>0).Last();
            //foreach (var item in postiveNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(postiveNumbers);

            //Query Expertion

            //select * from table Where id > 2

            //var result =  from i in numbers where i > 0select i;
            //10 % Method  12 Method
            //foreach ( var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            #region Deffered Execution  && Immediate Execution
            //List<int> numbers = [1, 2, -3, 4, 5, 6, -7, 8, -9];
            //var result = numbers.Where(a => a >0);//1  2 4 5 6 8
            //numbers.Add(20);
            //numbers.Remove(4);
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);   //1 2 5 6 8 20 
            //}
            //Console.WriteLine("===========================");
            //numbers.Add(22);
            //foreach (int j in result)
            //{
            //    Console.WriteLine(j);

            //}
            // Casting Operation    -- Single Operation

            //int x;
            //x =9;
            //x=8;
            //Console.WriteLine(x);
            #endregion

           
            #region Filteration   (Where , IndexedWhere)
            //var result = employees.Where(a => a.Id >5 && a.Name.Contains('a'));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Id      + " -  "   + item.Name);
            //}

            //result = from emp in employees
            //         where emp.Id >5 && emp.Name.Contains('a')
            //         select emp;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Id      + " -  "   + item.Name);
            //}


            //for (var i = 5;i< employees.Count;i++)
            //{
            //    if (employees[i].Id>5 && employees[i].Name.Contains('a'))
            //    Console.WriteLine(i + ""+  employees[i].Id      + " -  "   + employees[i].Name);
            //}
            //result = employees.Where((emp, Index) => emp.Id >5 && emp.Name.Contains('a') && Index>4  && Index <10);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Id      + " -  "   + item.Name);
            //}

            #endregion

            #region Transformation Operator   Select, Indexed Select
            ///     T Source          ==> T dimindion    8 Coulmns   ==>2 Coulmns
            //var result = employees
            //                                                .Where(emp => emp.Id >5)
            //                                                .Select(emp => new  { EmpId = emp.Id ,Name = emp.Name});


            //var anothersyntax = from emp in employees
            //                    where emp.Id >5
            //                    select new { ID = emp.Id , FullName = emp.Name , Salary = emp.Salary};


            //;
            //foreach (var emp in anothersyntax)
            //{
            //    Console.WriteLine( emp);
            //}



            //var result = employees
            //                                                .Where(emp => emp.Id >5)
            //                                                .Select((emp,Index)=> new {i =Index+1,Id = emp.Id,FullName = emp.Name});
            //foreach (var emp in result)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion


            #region Ordering Operator  (Order By   Order By Descinding)


            //var result = employees.OrderBy(emp => emp.Id);
            //result = from emp in employees
            //         orderby emp.Id
            //         select emp;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Id      + " -  "   + item.Name);
            //}


            //var result = employees.OrderByDescending(emp => emp.Id);
            //result = from emp in employees
            //         orderby emp.Id descending
            //         select emp;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Id      + " -  "   + item.Name);
            //}

            //var result = employees.Where(a=>a.Id >100).Select(emp=> new {ID = emp.Id , FullName = emp.Name}).OrderBy(emp => emp.ID);
            //result = from emp in employees
            //         orderby emp.Id
            //         select emp;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Slicing  / Partioning Operator (Skip  - Take - Take Last  - SkipLast - SkipWhile - TakeWhile - Chunk)
            // Take ==> get First Elements

            //var result = employees.OrderByDescending(a=>a.Salary).Take(3);
            //// 3 Salary

            //foreach (var e in result)
            //{
            //    Console.WriteLine(e.Id + "  -  " + e.Name + " -" + e.Salary);
            //}

            // Skip ===> get the rest into output sequense
            //var result = employees.Skip(3);// get the rest into output sequense
            //// 3 Salary

            //foreach (var e in result)
            //{
            //    Console.WriteLine(e.Id + "  -  " + e.Name + " -" + e.Salary);
            //}

            //Paginage  //1000  10  > 10 < 10
            // Chunk Operation // C sharp 10

            //var result = employees.Chunk(3);

            //foreach (var item in result)
            //{
            //    Console.Clear();
            //    foreach (var emp in item)
            //    {
            //        Console.WriteLine(emp.Id + "  -  " + emp.Name + " -" + emp.Salary);

            //    }
            //    Console.ReadLine();
            //}


            //var result = employees.TakeLast(5);
            //foreach (var emp in result)
            //{
            //    Console.WriteLine(emp.Id + "  -  " + emp.Name + " -" + emp.Salary);

            //}

            //var result = employees.SkipLast(5);
            //foreach (var emp in result)
            //{
            //    Console.WriteLine(emp.Id + "  -  " + emp.Name + " -" + emp.Salary);

            //}


            //TakeWhile
            // Take All Elements as long as Prdicate return true
            //Skip all after first Element returning false from Predicate
            //var result = employees.TakeWhile(emp=> emp.Name.Contains('a'));
            //foreach (var emp in result)
            //{
            //    Console.WriteLine(emp.Id + "  -  " + emp.Name + " -" + emp.Salary);

            //}



            //Skip While


            //Skip as long as Predicate return true
            //Take all the remaning element at the first element ==> return false
            //var result = employees.SkipWhile(emp => emp.Name.Contains('a'));
            //foreach (var emp in result)
            //{
            //    Console.WriteLine(emp.Id + "  -  " + emp.Name + " -" + emp.Salary);

            //}


            #endregion

            #region Single Elements   (Last - First - LastOrdefault - FirstOrdefault - Single - SingleOrdefault - Element At - Element Or Default)
            //Immdeiat execution
            //deffered Execution   Single Elements  ==> Immeditate 

            //var result = employees.Where(a => a.Id >5);
            //employees.Add(new Employee(1000000, "Eissa",100000));
            //Console.WriteLine(result.First().Name);//Eissa


            //var result = employees.First();
            //Console.WriteLine(result?.Name);

            //Single
            //var result = employees.Single(emp=> emp.Id ==220);
            ////Element duplicated  ==> return Execpetion
            ////Sequence NUll ==> Error
            ////Not Found ==> Error
            //Console.WriteLine(result.Name);


            //var result = employees.SingleOrDefault(a=>a.Id ==220);
            ////Element duplicated  ==> return Execpetion
            //Console.WriteLine(result?.Name);



            //var result = employees.ElementAt(1);
            ////Sequence NUll ==> return Execpetion
            //Console.WriteLine(result?.Name);

            //var result = employees.ElementAtOrDefault(1);
            //Console.WriteLine(result?.Name);



            #endregion
        }
    }
}
