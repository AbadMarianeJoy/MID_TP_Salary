using Employee_Salary_Abad;
using EmployeeInterface;
using Employeespace;
using System;
using System.Windows.Forms;

namespace Employee_Salary_Abad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            label_First.Text = "First name: <first name here>";
            label_Last.Text = "Last name: <last name here>";
            label_Salary.Text = "Basic Salary: 0.00";
        }

      
        private void button_Compute_Click_1(object sender, EventArgs e)
        {
        
            string firstName = textBox_Name.Text;
            string lastName = textBox_Last.Text;
            string department = textBox4.Text;  
            string jobTitle = textBox3.Text;      
            int hoursWorked = Convert.ToInt32(textBox_hour.Text);
            double ratePerHour = Convert.ToDouble(textBox_Rate.Text);

           
            PartTimeEmployee employee = new PartTimeEmployee(firstName, lastName, department, jobTitle);

          
            employee.Hours = hoursWorked;
            employee.Rate = ratePerHour;

        
            double salary = employee.computeSalary();

           
            label_First.Text = "First name: " + firstName;
            label_Last.Text = "Last name: " + lastName;
            label_Salary.Text = "Basic Salary: " + salary.ToString("C");

        }

        
        private void ClearFields()
        {
            textBox_Name.Clear();
            textBox_Last.Clear();
            textBox_Rate.Clear();
            textBox_hour.Clear();
            textBox4.Clear();  
            textBox3.Clear();    

           
            label_First.Text = "First name: <first name here>";
            label_Last.Text = "Last name: <last name here>";
            label_Salary.Text = "Basic Salary: 0.00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}


namespace EmployeeInterface
{
    public interface IEmployee
    {
        string First { get; set; }
        string Last { get; set; }
        double Rate { get; set; }
        int Hours { get; set; }
    }
}


namespace Employeespace
{
    public class PartTimeEmployee : IEmployee
    {
        public string First { get; set; }
        public string Last { get; set; }
        public double Rate { get; set; }
        public int Hours { get; set; }

        private string department { get; set; }
        private string job_title { get; set; }

        
        public PartTimeEmployee(string firstName, string lastName, string department, string jobTitle)
        {
            this.First = firstName;
            this.Last = lastName;
            this.department = department;
            this.job_title = jobTitle;
        }

  
        public double computeSalary()
        {
            return Hours * Rate;
        }
    }
}
