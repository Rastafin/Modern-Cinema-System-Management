/*using Backend.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model
{
    [Table("Employees")]
    public class Employee : Person
    {
        public static Employee GetEmployee(int userId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    var employee = context.Employees.FirstOrDefault(c => c.User.Id == userId);
                    return employee;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}*/
