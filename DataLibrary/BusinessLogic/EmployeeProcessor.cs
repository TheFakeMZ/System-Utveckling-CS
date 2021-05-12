using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLibrary.BusinessLogic
{
    public static class EmployeeProcessor
    {

        public static int generateId()
        {
            Random rd = new Random();
            return rd.Next(0, 1000);
        }

        public static int CreateEmployee(int employeeId, string firstName, 
            string lastName, string emailAddress)
        {
            int id = generateId();
            EmployeeModel data = new EmployeeModel
            {
                Id = id,
                EmployeeId = employeeId,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress
            };

            string sql = @"insert into dbo.Employee (Id, EmployeeId, FirstName, LastName, EmailAddress)
                           values (@Id, @EmployeeId, @FirstName, @LastName, @EmailAddress);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select Id, EmployeeId, FirstName, LastName, EmailAddress
                           from dbo.Employee;";

            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
