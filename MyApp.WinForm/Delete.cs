﻿using MyApp.Services.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp.WinForm
{
    public partial class Delete : Form
    {
        protected readonly int UserId;
        protected readonly Main Main;
        protected readonly IServiceFactory ServiceFactory;


        // This form relies upon the 'Main', the DataAccess, and the UserId in order to work
        public Delete(Main main, IServiceFactory serviceFactory, int userId)
        {
            UserId = userId;
            Main = main;
            ServiceFactory = serviceFactory;

            InitializeComponent();
        }

        // Load the user for the display
        private void Delete_Load(object sender, System.EventArgs e)
        {
            // Get the user by the ID 
            var user = ServiceFactory.UserService.GetById(UserId);

            if (user != null) // If we have a user then show their details
            {
                lblForename.Text = user.Forename;
                lblSurname.Text = user.Surname;
                lblIsActive.Text = (user.IsActive ? "Yes" : "No");
                lblDateOfBirth.Text = user.DateOfBirth.Date.ToString("dd/MM/yyyy");
            }
        }

        // A back button to go back to the main list view
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Override the closing event to show the Main form again
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Main.Show();
        }

        private void DeleteYesbutton1_Click(object sender, EventArgs e)
        {
            // get the user id and then delete the user with that id 
            var user = ServiceFactory.UserService.GetById(UserId);
            ServiceFactory.UserService.Delete(user);
            this.Close();
        }
    }
}
