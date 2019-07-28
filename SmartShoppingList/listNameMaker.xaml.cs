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

namespace sdkLocalDatabaseCS
{
    public partial class listNameMaker : PhoneApplicationPage
    {
        public bool ret = false;
        public string finallist = null;
        public string msg = "";
        
        public listNameMaker()
        {
            InitializeComponent();
        }

        private void Okdone_Click(object sender, RoutedEventArgs e)
        {
            //EmailComposeTask emailComposeTask = new EmailComposeTask();

            //emailComposeTask.Subject = "message subject";
            //emailComposeTask.Body = "message body";
            //emailComposeTask.To = "recipient@example.com";
            //emailComposeTask.Cc = "cc@example.com";
            //emailComposeTask.Bcc = "bcc@example.com";

            //emailComposeTask.Show();
            if (ListName.Text.Length < 1)
            {

                MessageBox.Show("List name field is empty");
                //this.Focus();
            }
            if (ListName.Text.Length > 0)
            {
                ret = true;

                App.ViewModel.Lname = ListName.Text;
                if (NavigationService.CanGoBack)
                {
         //           MessageBox.Show("huhu");
                    DateTime currentDate = DateTime.Now;
                    string s = currentDate.ToString();

                    ShoppingList sl = new ShoppingList
                    {
                        ListName = ListName.Text,
                        list = msg,
                        SetDateTime = currentDate.ToString()
                    };
                    App.ViewModel.AddShoppingList(sl);
                    App.ViewModel.LoadshoppinglistonNavigation();
                    //MessageBox.Show("Inserted");
                    NavigationService.GoBack();
                }
            }

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);



            if (NavigationContext.QueryString.TryGetValue("msg", out msg))
            {//info.Text = msg;
                // info.IsReadOnly = true;
                //info.
                info.HorizontalScrollBarVisibility = ScrollBarVisibility.Visible;
                info.Content = msg;
            }




        }
    }
}