using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD_cyrs;
using System.Windows.Forms;
using System.Data;

namespace BD_cyrs
{

    public class Statistica
    {

        public int Year(int[] mass)
        {
            int ret = 0;
            for (int i = 0; mass.Length > i; i++)
            {
                ret += mass[i];
            }
            ret = ret / mass.Length;
            return ret;
        }
        int Years(DateTime start, DateTime end)
        {
            return (end.Year - start.Year - 1) +
                (((end.Month > start.Month) ||
                ((end.Month == start.Month) && (end.Day >= start.Day))) ? 1 : 0);
        }

        public int Yearlable()

        {
            DataTable year = BD_class.Connec($"SELECT Date_of_birth FROM EmployeesSet");
            DateTime[] year_time = new DateTime[year.Rows.Count];
            for (int i = 0; year.Rows.Count > i; i++)
            {
                year_time[i] = DateTime.Parse(year.Rows[i][0].ToString());
            }
            int[] mass = new int[year.Rows.Count];
            mass = roop(year_time);
            return Year(mass);
        }

        public int[] roop(DateTime[] year)
        {
            int[] mass = new int[year.Length];
            for (int i = 0; year.Length > i; i++)
            {
                DateTime thisDay = DateTime.Today;
                mass[i] = Years(year[i], thisDay);
            }
            return mass;
        }

    }
}