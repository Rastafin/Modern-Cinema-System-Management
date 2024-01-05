using Backend.Data;
using Backend.Model.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class ChartDataCalculator
    {
        public static (double malePercentage, double femalePercentage, double otherPercentage) GetUsersSexDataCounts()
        {
            using (var context = new DataContext())
            {
                try
                {
                    var people = context.Users.ToList();

                    int maleCount = context.Clients.Count(u => u.Sex == Sex.Man);
                    int femaleCount = context.Clients.Count(u => u.Sex == Sex.Woman);
                    int otherCount = context.Clients.Count(u => u.Sex == Sex.Other);

                    int totalSexCount = maleCount + femaleCount + otherCount;

                    double malePercentage = (maleCount / (double)totalSexCount) * 100;
                    double femalePercentage = (femaleCount / (double)totalSexCount) * 100;
                    double otherPercentage = (otherCount / (double)totalSexCount) * 100;

                    return (malePercentage, femalePercentage, otherPercentage);
                }
                catch (Exception)
                {
                    throw new Exception("Error in GetUsersSexDataCounts method.");
                }
            }
        }
    }
}
