using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    internal class Indexers
    {
    }

    //public partial class WebForm : System.Web
    //{
    //    protected void Page(object sender, EventArgs e)
    //    {
    //        Session["Session1"] = "Session 1 Data";
    //        Session["Sessio2"] = "Session 2 Data";

    //        Responsive.WriteLine("Session 1 Data = " + Session[0].ToString());
    //        Responsive.WriteLine("Session 2 Data = " + Session["Session2"].ToString());


    //    }
    //}

    public class InfosysEmployee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public class Infosys
    {
        private List<InfosysEmployee> listEmployees;

        public Infosys()
        {
            listEmployees = new List<InfosysEmployee>();
            listEmployees.Add(new InfosysEmployee { EmployeeId = 1, Name = "Peter", Gender = "Male" });
            listEmployees.Add(new InfosysEmployee { EmployeeId = 2, Name = "Jessi", Gender = "Female" });
            listEmployees.Add(new InfosysEmployee { EmployeeId = 3, Name = "Radhe", Gender = "Male" });
            listEmployees.Add(new InfosysEmployee { EmployeeId = 4, Name = "Ishika", Gender = "Female" });
            listEmployees.Add(new InfosysEmployee { EmployeeId = 5, Name = "Rohit", Gender = "Male" });
            listEmployees.Add(new InfosysEmployee { EmployeeId = 6, Name = "Abhishek", Gender = "Male" });
        }

        public string this[int employeeId] //Indexers are used keyword as "this[]"
        {
            get
            {
                return listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
            }
        }
        public string this[string gender]
        {
            get
            {
                return listEmployees.Count(emp => emp.Gender == gender).ToString();
            }
            set
            {
                foreach (InfosysEmployee employee in listEmployees)
                {
                    if(employee.Gender == gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }

    }

}

/*
    Indexers allow instance of the class to be indexed just like arrays.

    To store or retrieve data from session state or application state variables, we use "Indexers".
 
 
 */
