using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryAppAssociation_relationship
{
    public partial class EmployeeSalaryUI : Form
    {
        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }

        private Employee anEmployee;
        private void saveButton_Click(object sender, EventArgs e)
        {
            anEmployee = new Employee(idTextBox.Text,nameTextBox.Text,emailTextBox.Text);
            Salary aSalary = new Salary(Convert.ToDouble(basicTextBox.Text), Convert.ToDouble(medicalPercentageTextBox.Text), Convert.ToDouble(conveyancePercentageTextBox.Text));
            anEmployee.aSalary = aSalary;
            MessageBox.Show(anEmployee.Name + "'s salary information has been saved.");
        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
            //if (anEmployee.aSalary.Increase(Convert.ToDouble(incrementPercentageTextBox.Text)))
            //{
            //    MessageBox.Show(anEmployee.Name + @"'s salary has been increased.");
            //}
            //else
            //{
            //    MessageBox.Show(@"Operation failed.");
            //}
            double amount = Convert.ToDouble(incrementPercentageTextBox.Text);
            anEmployee.aSalary.Increase(amount);
            MessageBox.Show("Salary has been increated");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            noOfIncrementsTextBox.Text = anEmployee.aSalary.NoOfIncrements.ToString();
            basicShowTextBox.Text = anEmployee.aSalary.Basic.ToString();
            medicalAmountTextBox.Text = anEmployee.aSalary.GetMedicalAmount().ToString();
            conveyanceAmountTextBox.Text = anEmployee.aSalary.GetConveyanceAmount().ToString();
            totalTextBox.Text = anEmployee.aSalary.GetTotal().ToString();
        }
    }
}
