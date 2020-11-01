using MyApp.Models;
using MyApp.Services.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyApp.WinForm
{
    public partial class Edit : Form
    {
        protected readonly Main Main;
        int UserId;
        protected readonly IServiceFactory ServiceFactory;

        public Edit(Main main, IServiceFactory serviceFactory, int userId)
        {
            Main = main;
            UserId = userId;
            ServiceFactory = serviceFactory;
            InitializeComponent();
        }


        private void Editbutton2_Click(object sender, EventArgs e)
        {
            string FN = ForenametextBox1.Text;
            string SN = SurnametextBox2.Text;
            bool IA = IsAtiveCheckBox1.Checked;
            string DoB = DateOfBirthtextBox4.Text;
            Validator val = new Validator(FN, SN, IA, DoB);
            bool nameValid = val.IsValidDateOfBirth(); bool dateValid = val.isValidName();
            if (nameValid && dateValid)
            {
                var user = ServiceFactory.UserService.GetById(UserId);
                // eddit user
                user.Forename = FN; user.Surname = SN; user.IsActive = IA; user.DateOfBirth = DateTime.Parse(DoB);
                ServiceFactory.UserService.Update(user);
                MessageBox.Show("User details successfully edited!.");
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

        // when from loads make the input fields that of the user with the selected id
        private void Edit_Load(object sender, EventArgs e)
        {
            var user = ServiceFactory.UserService.GetById(UserId);

            
            ForenametextBox1.Text = user.Forename;
            SurnametextBox2.Text = user.Surname;
            IsAtiveCheckBox1.Checked = user.IsActive;
            DateOfBirthtextBox4.Text = user.DateOfBirth.Date.ToString("dd/MM/yyyy");
        }

 
    }
}
