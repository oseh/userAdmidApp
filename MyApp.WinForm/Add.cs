using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyApp.Services.Factories.Interfaces;
using MyApp.Models;
using System.Globalization;
using System.Threading;



namespace MyApp.WinForm
{
    public partial class Add : Form
    {
        protected readonly Main Main;
        protected readonly IServiceFactory ServiceFactory;

        public Add(Main main, IServiceFactory serviceFactory)
        {
            Main = main;
            ServiceFactory = serviceFactory;
            InitializeComponent();
        }

        private void Addkbutton1_Click(object sender, EventArgs e)
        {
            string FN = ForenametextBox1.Text;
            string SN = SurnametextBox2.Text;
            bool IA = IsAtiveradioButton1.Checked;
            string DoB = DateOfBirthtextBox4.Text;
            Validator val = new Validator(FN, SN, IA, DoB);
            bool nameValid = val.IsValidDateOfBirth(); bool dateValid = val.isValidName();
            if (nameValid && dateValid)
            {
                // create new user
                User NewUser = new User { Forename = FN, Surname = SN, IsActive = IA, DateOfBirth = DateTime.Parse(DoB)};
                ServiceFactory.UserService.Create(NewUser);
                MessageBox.Show("User details successfully Added!.");
            }
        }

        private void Backbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Override the closing event to show the Main form again
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Main.Show();
        }


    }
}
