using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
namespace sdkLocalDatabaseCS
{
    public partial class ListDetails : PhoneApplicationPage
    {
        
        public ListDetails()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
          
            
            //var data= NavigationContext.QueryString;
            // if (data.ContainsKey("list"))
            // {
               
            //     //Iterate through values (comma seperated)
            //  //Populate a new list with the owners.
            // }
            base.OnNavigatedTo(e);
            listname.Text= NavigationContext.QueryString["listsname"];
            list.Content=NavigationContext.QueryString["lists"];
            //if (DataContext == null)
            //{
            //    string selectedIndex = "";
            //    if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
            //    {
            //        int index = int.Parse(selectedIndex);
            //        DataContext = App.ViewModel.AllShoppingList;
                    
            //        //if (MessageBox.Show("Will you really remove the item?", "Warning", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            //        //{
            //        //    MessageBox.Show("OK");
            //        //    //Call some methods to delete the item you want to remove.
            //        //}
            //        //Call some methods to delete the item you want to remove.

           
        }

      
        private void ButtonSMS_Click(object sender, RoutedEventArgs e)
        {

            SmsComposeTask smsComposeTask = new SmsComposeTask();
            smsComposeTask.To = ""; // Mention here the phone number to whom the sms is to be sent
            smsComposeTask.Body = list.Content.ToString(); // the string containing the sms body
            smsComposeTask.Show();
        }
        private void ButtonMAil_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask emailComposeTask = new EmailComposeTask();

            emailComposeTask.Subject = "Shopping List";
            emailComposeTask.Body = list.Content.ToString();
            emailComposeTask.To = "";
            emailComposeTask.Cc = "";
            emailComposeTask.Bcc = "";

            emailComposeTask.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

     
    }
}