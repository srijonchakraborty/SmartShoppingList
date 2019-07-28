using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LocalDatabaseSample.Model;
using LocalDatabaseSample.ViewModel;

namespace sdkLocalDatabaseCS
{ 
    
    public partial class newcatagory : PhoneApplicationPage
    {
        string DBConnectionString = "Data Source=isostore:/ToDo.sdf";
        public newcatagory()
        {
            InitializeComponent();
        }
        private static ToDoViewModel viewModel;
        public static ToDoViewModel ViewModel
        {
            get { return viewModel; }
        }
        private void btnaddcat_Click(object sender, RoutedEventArgs e)
        {
            using (ToDoDataContext db = new ToDoDataContext(DBConnectionString))
            {
                if (db.DatabaseExists() == true)
                {
                    // Create the local database.
                    //  db.CreateDatabase();
                    //MessageBox.Show("EXISTs");
                    // Prepopulate the categories.
                    if (newcatname.Text.Length > 0)
                    {
                        db.Categories.InsertOnSubmit(new ToDoCategory { Name = newcatname.Text });


                        // Save categories to the database.
                        db.SubmitChanges();
                        App.ViewModel.LoadCatonNavigation();
                    }
                    else
                        MessageBox.Show("Name field is empty.");

                    // Create the ViewModel object.
                   // viewModel = new ToDoViewModel(DBConnectionString);

                    // Query the local database and load observable collections.
                    //viewModel.LoadCollectionsFromDatabase();
                }
            }
            // Return to the main page.
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}