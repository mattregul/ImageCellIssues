using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NetStand
{
    class Employee
    {
        public UriImageSource Source { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }

        public Employee(string _source, string _name, string _job)
        {
            Source = new UriImageSource
            {
                Uri = new Uri(_source),
                //CachingEnabled = true,
                //CacheValidity = new TimeSpan(0, 0, 1, 0)
            };
            Name = _name;
            Job = _job;
        }
    }
    public partial class MainPage : ContentPage
	{
        List<Employee> employeeList;
        public MainPage()
        {
            InitializeComponent();

            employeeList = new List<Employee>();

            // Create a few sample employees
            for (int i = 0; i < 50; i++)
            {
                employeeList.Add(
                    new Employee(
                        "https://www.xamstatic.com/dist/images/pages/platform/visual-studio-icon-uHIZMvQl.png",
                        "Employee " + i,
                        "Developer"
                    )
                );
            }

            // Set the source
            EmployeeListview.ItemsSource = employeeList;
        }
    }

}

