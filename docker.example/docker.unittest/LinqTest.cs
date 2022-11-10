using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace docker.unittest
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
    [TestClass]
    public class LinqTest
    {

        [TestMethod]
        public void Sample()
        {

            List<Employee> employeeList = new List<Employee>()
            {
               new Employee() { Id = 1, Name = "Sunny", Department = "Technical" },
               new Employee() { Id=2, Name="Pinki", Department ="HR"},
               new Employee() { Id=3, Name="Tensy", Department ="Finance"},
               new Employee() { Id=4, Name="Bobby", Department ="Technical"},
               new Employee() { Id=5, Name="Sweety", Department ="HR"}
            };

            var result = employeeList.First();
            var resultHr = employeeList.First(e => e.Department == "HR");

            var resultHrDefault = employeeList.FirstOrDefault(e => e.Id == 8);

            try
            {
                List<Employee> employeeListNew = new List<Employee>();
                var resultOne = employeeListNew.First();


            }
            catch (Exception ex)
            {

            }

            try
            {
                List<Employee> employeeListNew = new List<Employee>();
                var resultOne = employeeListNew.FirstOrDefault();
            }
            catch (Exception ex)
            {

            }

            try
            {
                var resultSingle = employeeList.Single(e => e.Department == "HR");
            }
            catch (Exception ex)
            {

            }

            try
            {
                var resultSingle = employeeList.SingleOrDefault(e => e.Department == "HR");
            }
            catch (Exception ex)
            {

            }


            List<int> intLst = new List<int>();
            intLst.Add(1);
            intLst.Add(2);

            var rDefault = intLst.FirstOrDefault(x => x.Equals(0));

            try
            {
                var rFirst = intLst.First(x => x.Equals(0));
            }
            catch (Exception)
            {


            }


        }
    }
}
