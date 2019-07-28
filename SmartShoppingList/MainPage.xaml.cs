/* 
    Copyright (c) 2011 Microsoft Corporation.  All rights reserved.
    Use of this sample source code is subject to the terms of the Microsoft license 
    agreement under which you licensed this sample source code and is provided AS-IS.
    If you did not accept the terms of the license agreement, you are not authorized 
    to use this sample source code.  For the terms of the license, please see the 
    license agreement between you and Microsoft.
  
    To see all Code Samples for Windows Phone, visit http://go.microsoft.com/fwlink/?LinkID=219604 
  
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using Microsoft.Phone.Controls;
using System.Windows.Controls.Primitives;

using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
//using Microsoft.Phone.Controls;
// Directive for the ViewModel.
using LocalDatabaseSample.Model;
using LocalDatabaseSample.ViewModel;
namespace sdkLocalDatabaseCS
{
    
    public partial class MainPage : PhoneApplicationPage
    {
        private ToDoViewModel toview;
        private ToDoDataContext toDoDB;
        public string listname;
        public string tempquantity;
        public List<string> listupdater = new List<string>();
        public List<string> listquantity = new List<string>();
        int count = 0;
        public CheckBox ckbox_cancel=null;
       // ToDoDataContext
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            App.ViewModel.Lname = "";
            // Set the page DataContext property to the ViewModel.
            this.DataContext = App.ViewModel;
        }

        private void newTaskAppBarButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/NewTaskPage.xaml", UriKind.Relative));
        }
        private void newcat_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/newcatagory.xaml", UriKind.Relative));
            //MessageBox.Show(App.ViewModel.Lname);
        }

        private void deleteTaskButton_Click(object sender, RoutedEventArgs e)
        {
            // Cast the parameter as a button.
            
            Button c = (Button)sender;
            ToDoItem myto = c.DataContext as ToDoItem;
            bool bo = false;
            int myindex = 0;
            bo = listupdater.Exists(element => element == myto.ItemName);
            try
            {
                myindex = listupdater.FindIndex(item => item == myto.ItemName);
            }
            catch (Exception ex)
            {
                myindex = 0;
            }
            if (bo)
            {
                listupdater.RemoveAt(myindex);
                listquantity.RemoveAt(myindex);
            }
            else
            {
                //list.Add(c.Tag.ToString());
            }
           // MessageBox.Show(c.Tag.ToString());
            //ToDoItem test = c.DataContext as ToDoItem;
            //string s = test.ItemName;
            //MessageBox.Show(s);
            Button BT = (Button)sender;
            
           // MessageBox.Show(BT.Tag.ToString());
            var button = sender as Button;
           
            if (button != null)
            {
                // Get a handle for the to-do item bound to the button.
                ToDoItem toDoForDelete = button.DataContext as ToDoItem;

                App.ViewModel.DeleteToDoItem(toDoForDelete);
                //App.ViewModel.LoadCollectionsFromDatabase();
            }
           // LoadCollectionsFromDatabase();
            // Put the focus back to the main page.
            this.Focus();
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            // Save changes to the database.
            App.ViewModel.SaveChangesToDB();
            App.ViewModel.LoadAllItemFromButton();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
             //var toDoItemsInDB = from ToDoItem todo in toDoDB.Items
             //                   select todo;
            // var v = from ShoppingList sl in toDoDB.MyShoppingList
              //       select sl;
            App.ViewModel.LoadCollectionsFromDatabase();
            //updated database element accesing 
            List<ShoppingList> l = App.ViewModel.AllShoppingList.ToList();
            string s="";
            foreach (ShoppingList slt in l)
            {
                s += "\n" + slt.ListName;
            }
           // MessageBox.Show(s);
            //method for confirmation messagebox
            //if (MessageBox.Show("Will you really remove the item?", "Warning", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            //{
            //    MessageBox.Show("OK");
            //    //Call some methods to delete the item you want to remove.
            //}
            //ObservableCollection<ToDoItem>
            // ListBox lb = new ListBox();
            //lb=allToDoItemsListBox;
            //lb.SelectedValue.ToString();
           // string s="";
           // MessageBox.Show("Go" + allToDoItemsListBox.SelectedItems.Count.ToString());
            
           // //allToDoItemsListBox.FontSize = 40.00;
           // //ListBoxItem pressedItem = allToDoItemsListBox.SelectedItems as ListBoxItem;
           // ToDoItem selectedItem = (ToDoItem)allToDoItemsListBox.Items[1];
           // foreach (ToDoItem item in allToDoItemsListBox.SelectedItems)
           // {
                
           //     s =s+"\n"+item.ItemName;
           // }
           // MessageBox.Show(s);
           //// string selectedItem = (ToDoItem)allToDoItemsListBox.SelectedItems.ToString();
           //     MessageBox.Show(selectedItem.ItemName);
            // MessageBox.Show("NULLL :p");
            //MessageBox.Show(allToDoItemsListBox.Items.Count.ToString());
            //MessageBox.Show(allToDoItemsListBox.Items[4].ToString());
            //MessageBox.Show(allToDoItemsListBox.SelectedItem.ToString());
            //allToDoItemsListBox.SelectedItems.ToString();
            //all checked items.
            //for (int i = 0; i < allToDoItemsListBox.Items.Count; i++)
            //{

             //   MessageBox.Show(allToDoItemsListBox.Items[i].ToString());
            //}
            //MessageBox.Show(s);
        }

        private void CheckBox_BindingValidationError(object sender, ValidationErrorEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

            
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
           
           
        }

        
        private void test_Click_1(object sender, RoutedEventArgs e)
        {
           
            //int temp = -1;
            // making list of id of selected item
            string s = "";
            CheckBox c = (CheckBox)sender;
            ToDoItem myto = c.DataContext as ToDoItem;
            

            //MessageBox.Show(myto.ItemName);
            //int i= int.Parse(c.Tag.ToString());
            //MessageBox.Show("index"+i);
           // MessageBox.Show(c.Tag.ToString());
            //if (c.IsChecked != true)
            //{

            //    list.RemoveAt(int.Parse(c.Tag.ToString()));
            //    MessageBox.Show("Item deleted and count:" + list.Count());

            //}
            //else
            //{
            //    list.Insert(int.Parse(c.Tag.ToString()), c.Tag.ToString());
            //    MessageBox.Show("Item:" + list[int.Parse(c.Tag.ToString())]);
            //    MessageBox.Show(c.Tag.ToString());
            //}
            bool bo = false;
            int myindex = 0;
            bo = listupdater.Exists(element => element ==myto.ItemName );
            try
            {
                myindex = listupdater.FindIndex(item => item == myto.ItemName);
            }
            catch (Exception ex)
            {
                myindex = 0;
            }
            if (bo)
            {
                listupdater.RemoveAt(myindex);
                listquantity.RemoveAt(myindex);
            }
            else
            {
                quantity.Text = "";
               srijonpopup.IsOpen=true;
               poptextblock.Text = "enter quantity of\n" + myto.ItemName.ToString();
               ckbox_cancel = c;
               ContentPanel.Visibility = Visibility.Collapsed;
             //  MessageBox.Show("");
                listupdater.Add(myto.ItemName);
               // listquantity.Add(quantity.Text);
            }
            //ContentPanel.Visibility = Visibility.Visible;
            //srijonpopup.IsOpen = false;
            //MessageBox.Show(c.Tag.ToString());

        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        { 
         mainitempage.DefaultItem=mainitempage.Items[0];
       // App.ViewModel.LoadCollectionsFromDatabase();
        }
            


        //}
       
        private void GridtestButton_Click(object sender, EventArgs e)
        {

            //CustomMessageBox cbx = new CustomMessageBox();
            
            string s = "";
            //foreach (object o in listupdater)
            //{

            //    s += o.ToString() + "\n";
            //}
            for (int i=0; i < listupdater.Count;i++ )
            {
                s+=""+(i+1)+"."+listupdater[i]+"("+listquantity[i]+")\n";
            }
                // MessageBox.Show(currenttime);
                //MessageBox.Show("Ans" + listupdater.Count());

                //MessageBox.Show(s);
            if (listupdater.Count > 0)
                NavigationService.Navigate(new Uri("/listNameMaker.xaml?msg=" + s, UriKind.Relative));
            else
                MessageBox.Show("No item selected.\nPlease select items from item names.");
            // setListName SLN = new setListName(s);
           // NavigationService.Navigate(new Uri("/setListName.xaml", UriKind.Relative));
            /*
           
           
                        ShoppingList sl = new ShoppingList
                        {
                            ListName = "",
                            list=s,
                            SetDateTime=currenttime
                        };
                        App.ViewModel.AddShoppingList(sl);
                        MessageBox.Show("Inserted");
                        */
            //App.ViewModel.LoadCollectionsFromDatabase();
            ////List<ShoppingList> l = App.ViewModel.AllShoppingList.ToList();
            
           
            //s=null;
            //foreach (ShoppingList slt in l)
            //{
            //    s += "\n" + slt.list;
            //}          
            //MessageBox.Show(s);
            ////List<ToDoCategory> l= App.ViewModel.CategoriesList.ToList();
            //foreach(ToDoCategory T in l)
            //{
            //    s += "\n" + T.Name;
            //}
            //MessageBox.Show(s);
            //s = null;
            //foreach (ToDoCategory T in l)
            //{
            //    s += "\n" + T.ToDos;
            //}
            //MessageBox.Show(s);
            //MessageBox.Show();
            //CheckBox myListBoxItem = (CheckBox)(allToDoItemsListBox.ItemContainerGenerator.ContainerFromItem(allToDoItemsListBox.Items[0]));
            //ContentPresenter myContentPresenter = FindVisualChild<ContentPresenter>(allToDoItemsListBox);
            //DataTemplate myDataTemplate = myContentPresenter.ContentTemplate;
            //CheckBox myTextBlock = (CheckBox)myDataTemplate.LoadContent();
            //MessageBox.Show(myTextBlock.Tag.ToString());

                //(myListBox.ItemContainerGenerator.ContainerFromItem(myListBox.Items.CurrentItem));
            listupdater.Clear();
            listquantity.Clear();
        }
       
        private void allToDoItemsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e){

            //ListBox l = (sender)ListBox;


            if (allToDoItemsListBox.SelectedIndex != -1)
            {
                ToDoItem t = allToDoItemsListBox.SelectedItem as ToDoItem;
               // MessageBox.Show("" + t.Category.Id);
                allToDoItemsListBox.SelectedIndex = -1;
            }
           
        }

        private void myalllistUI_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (myalllistUI.SelectedItem == null)
                return;
            //ShoppingList my = myalllistUI.DataContext as ShoppingList;
           // MessageBox.Show(myalllistUI.SelectedItem.ToString());
           
          
           ShoppingList myto =myalllistUI.SelectedItem as ShoppingList;

           //MessageBox.Show(myto.ListName);
           string s ="/ListDetails.xaml?listsname="+myto.ListName+"&lists="+myto.list;
           // // Navigate to the new page
            NavigationService.Navigate(new Uri(s, UriKind.Relative));

            // Reset selected item to null (no selection)
            myalllistUI.SelectedItem = null;
        }
        private void catlistselectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cat.SelectedIndex!=-1)
            {
                //mainitempage.Focus();
                
                ToDoCategory t = cat.SelectedItem as ToDoCategory;
                string s = t.Id.ToString();
                App.ViewModel.loaditemOnCatagoryDemand(s);
                cat.SelectedIndex = -1;
                mainitempage.DefaultItem = mainitempage.Items[0];//panoroma focus changer
            }
            //mainitempage.Focus();
            
           // mm.DefaultItem=mm.Items[0];
        }
        private void deleteListButton_Click(object sender, RoutedEventArgs e)
        {
            Button BT = (Button)sender;

            // MessageBox.Show(BT.Tag.ToString());
            var button = sender as Button;

            if (button != null)
            {
                // Get a handle for the to-do item bound to the button.
                ShoppingList shlistForDelete = button.DataContext as ShoppingList;

                App.ViewModel.DeleteSHList(shlistForDelete);
                //App.ViewModel.LoadCollectionsFromDatabase();
            }
            // LoadCollectionsFromDatabase();
            // Put the focus back to the main page.
            this.Focus();
        }


        private void deleteCatButton_Click_1(object sender, RoutedEventArgs e)
        {
          if (MessageBox.Show("Will you like to remove this category?", "Warning", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
          {
              //MessageBox.Show("OK");
              Button BT = (Button)sender;

              // MessageBox.Show(BT.Tag.ToString());
              var button = sender as Button;
              // ToDoCategory catdel = BT.DataContext as ToDoCategory;

              if (button != null)
              {
                  // Get a handle for the to-do item bound to the button.
                  ToDoCategory catForDelete = button.DataContext as ToDoCategory;


                  //  MessageBox.Show(catForDelete.Id.ToString());
                  App.ViewModel.DeleteCatList(catForDelete);
                  //App.ViewModel.LoadCollectionsFromDatabase();
              }
              //Call some methods to delete the item you want to remove.
          }
           
            // LoadCollectionsFromDatabase();
            // Put the focus back to the main page.
            this.Focus();
        }
        private void btn_continue_Click(object sender, RoutedEventArgs e)
        {
            if (quantity.Text.Length > 0)
            {
                listquantity.Add(quantity.Text);
                srijonpopup.IsOpen = false;
                ContentPanel.Visibility = Visibility.Visible;
            }
            else
                MessageBox.Show("Please insert quantity");
        }

        private void deleteListButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void can_not_delete(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You are not allowed to remove this Category.");
        }

        private void s_Click(object sender, RoutedEventArgs e)
        {
        //    App.ViewModel.LoadAllItemFromButton();
        //    mainitempage.DefaultItem=mainitempage.Items[0];
        }

        private void AllCatImageTAP(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.ViewModel.LoadAllItemFromButton();
            mainitempage.DefaultItem = mainitempage.Items[0];
        }

        //private void btn_cancel_Click(object sender, RoutedEventArgs e)
        //{
        //    //MessageBox.Show(""+listupdater.Count());
        //    listupdater.RemoveAt((listupdater.Count() - 1));
        //    srijonpopup.IsOpen = false;
        //    ContentPanel.Visibility = Visibility.Visible;
        //    App.ViewModel.LoadCollectionsFromDatabase();
        //    //listupdater.RemoveAt();
        //}

    
      

       
        
    }
}
