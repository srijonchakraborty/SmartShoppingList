/* 
    Copyright (c) 2011 Microsoft Corporation.  All rights reserved.
    Use of this sample source code is subject to the terms of the Microsoft license 
    agreement under which you licensed this sample source code and is provided AS-IS.
    If you did not accept the terms of the license agreement, you are not authorized 
    to use this sample source code.  For the terms of the license, please see the 
    license agreement between you and Microsoft.
  
    To see all Code Samples for Windows Phone, visit http://go.microsoft.com/fwlink/?LinkID=219604 
  
*/
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

// Directive for the data model.
using LocalDatabaseSample.Model;
using System;


namespace LocalDatabaseSample.ViewModel
{
    public class ToDoViewModel : INotifyPropertyChanged
    {
        // LINQ to SQL data context for the local database.
        private ToDoDataContext toDoDB;

        // Class constructor, create the data context object.
        public ToDoViewModel(string toDoDBConnectionString)
        {
            toDoDB = new ToDoDataContext(toDoDBConnectionString);
        }

        // All Shopping List
        private ObservableCollection<ShoppingList> _allshoppinglist;
        public ObservableCollection<ShoppingList> AllShoppingList
        {
            get { return _allshoppinglist; }
            set
            {
                _allshoppinglist = value;
                NotifyPropertyChanged("AllShoppingList");
            }
        }
        
        //// All to-do items full info.
        //private ObservableCollection<string> _listitem;
        //public ObservableCollection<string> Listitemname
        //{
        //    get { return _listitem; }
        //    set
        //    {
        //        _listitem = value;
        //        NotifyPropertyChanged("Listitemname");
        //    }
        //}
        // All to-do items full info.
        private ObservableCollection<ToDoItem> _allToDoItems;
        public ObservableCollection<ToDoItem> AllToDoItems
        {
            get { return _allToDoItems; }
            set
            {
                _allToDoItems = value;
                NotifyPropertyChanged("AllToDoItems");
            }
        }

        // To-do items associated with the home category.
        private ObservableCollection<ToDoItem> _homeToDoItems;
        public ObservableCollection<ToDoItem> HomeToDoItems
        {
            get { return _homeToDoItems; }
            set
            {
                _homeToDoItems = value;
                NotifyPropertyChanged("HomeToDoItems");
            }
        }

        // To-do items associated with the work category.
        private ObservableCollection<ToDoItem> _workToDoItems;
        public ObservableCollection<ToDoItem> WorkToDoItems
        {
            get { return _workToDoItems; }
            set
            {
                _workToDoItems = value;
                NotifyPropertyChanged("WorkToDoItems");
            }
        }





        // To-do items associated with the hobbies category.
        private ObservableCollection<ToDoItem> _hobbiesToDoItems;
        public ObservableCollection<ToDoItem> HobbiesToDoItems
        {
            get { return _hobbiesToDoItems; }
            set
            {
                _hobbiesToDoItems = value;
                NotifyPropertyChanged("HobbiesToDoItems");
            }
        }
        private string _lname;
        public string Lname
        {
            get { return _lname; }
            set
            {
                _lname = value;
                NotifyPropertyChanged("Lname");
            }
        }
        // A list of all categories, used by the add task page.
        private List<ToDoCategory> _categoriesList;
        public List<ToDoCategory> CategoriesList
        {
            get { return _categoriesList; }
            set
            {
                _categoriesList = value;
                NotifyPropertyChanged("CategoriesList");
            }
        }

        // To-do items associated with the work category.
        private ObservableCollection<ToDoCategory> _itemCatagory;
        public ObservableCollection<ToDoCategory> ItemCatagory
        {
            get { return _itemCatagory; }
            set
            {
                _itemCatagory = value;
                NotifyPropertyChanged("ItemCatagory");
            }
        }

        // Write changes in the data context to the database.
        public void SaveChangesToDB()
        {
            toDoDB.SubmitChanges();
        }

        public void loaditemOnCatagoryDemand(string obj)
        {
            var v = from ToDoItem todo in toDoDB.Items
                                  where todo._categoryId == int.Parse(obj)
                                  select todo;
            v=v.OrderBy(c => c.ItemName);
            AllToDoItems = new ObservableCollection<ToDoItem>(v);
        }
        public void LoadAllItemFromButton()
        {
            var toDoItemsInDB = from ToDoItem todo in toDoDB.Items
                                orderby todo._categoryId
                                select todo;
            //toDoItemsInDB = toDoItemsInDB.ThenBy(c => c.LastName);
            // Query the database and load all to-do items.
            AllToDoItems = new ObservableCollection<ToDoItem>(toDoItemsInDB);
        }
        // Query database and load the collections and list used by the pivot pages.
        public void LoadCatonNavigation()
        {
            var toDoCategoriesInDB = from ToDoCategory category in toDoDB.Categories
                                     select category;

            ItemCatagory = new ObservableCollection<ToDoCategory>(toDoCategoriesInDB);
            
            CategoriesList = toDoDB.Categories.ToList();
            

        }
        public void LoadshoppinglistonNavigation()
        {
            var shpl = from ShoppingList li in toDoDB.MyShoppingList
                       select li;
            shpl = shpl.OrderBy(c => c.SetDateTime);
            AllShoppingList = new ObservableCollection<ShoppingList>(shpl);
           
        }
        public void LoadCollectionsFromDatabase()
        {
           // string s = "";
            var shpl = from ShoppingList li in toDoDB.MyShoppingList 
                       select li;
            shpl = shpl.OrderBy(c => c.SetDateTime);
            AllShoppingList = new ObservableCollection<ShoppingList>(shpl);
           // //foreach (ShoppingList shl in shpl)
           // //{
           // //    s += shl.list;
           // //}
           // shpl = from ShoppingList li in toDoDB.MyShoppingList where li.Id == 1 select li;
           //// ShoppingList mytestshoplist = (ShoppingList)shpl;
          
           //// Listitemname = new ObservableCollection<string>();
            
            
          
            // Specify the query for all to-do items in the database.
            var toDoItemsInDB = from ToDoItem todo in toDoDB.Items
                                orderby todo._categoryId 
                                select todo;
            //toDoItemsInDB = toDoItemsInDB.ThenBy(c => c.LastName);
            // Query the database and load all to-do items.
            AllToDoItems = new ObservableCollection<ToDoItem>(toDoItemsInDB);
           
            // Specify the query for all categories in the database.
            var toDoCategoriesInDB = from ToDoCategory category in toDoDB.Categories
                                     select category;

            ItemCatagory = new ObservableCollection<ToDoCategory>(toDoCategoriesInDB);
            // Query the database and load all associated items to their respective collections.
            //foreach (ToDoCategory category in toDoCategoriesInDB)
            //{
            //    switch (category.Name)
            //    {
            //        case "Home":
            //            HomeToDoItems = new ObservableCollection<ToDoItem>(category.ToDos);
            //            break;
            //        case "Work":
            //            WorkToDoItems = new ObservableCollection<ToDoItem>(category.ToDos);
            //            break;
            //        case "Hobbies":
            //            HobbiesToDoItems = new ObservableCollection<ToDoItem>(category.ToDos);
            //            break;
            //        default:
            //            break;
            //    }
            //}

            // Load a list of all categories.
            CategoriesList = toDoDB.Categories.ToList();
            
        }

       //add shopping list
        public void AddShoppingList(ShoppingList newShoppingList)
        {
            toDoDB.MyShoppingList.InsertOnSubmit(newShoppingList);
            toDoDB.SubmitChanges();
            AllShoppingList.Add(newShoppingList);
            //we need to update observable collection

        }
        // Add a to-do item to the database and collections.
        public void AddToDoItem(ToDoItem newToDoItem)
        {
            // Add a to-do item to the data context.
            toDoDB.Items.InsertOnSubmit(newToDoItem);

            // Save changes to the database.
            toDoDB.SubmitChanges();

            // Add a to-do item to the "all" observable collection.
            AllToDoItems.Add(newToDoItem);

            // Add a to-do item to the appropriate filtered collection.
            //switch (newToDoItem.Category.Name)
            //{
            //    case "Home":
            //        HomeToDoItems.Add(newToDoItem);
            //        break;
            //    case "Work":
            //        WorkToDoItems.Add(newToDoItem);
            //        break;
            //    case "Hobbies":
            //        HobbiesToDoItems.Add(newToDoItem);
            //        break;
            //    default:
            //        break;
            //}
        }

        // Remove a to-do task item from the database and collections.
        public void DeleteToDoItem(ToDoItem toDoForDelete)
        {

            // Remove the to-do item from the "all" observable collection.
            AllToDoItems.Remove(toDoForDelete);

            // Remove the to-do item from the data context.
            toDoDB.Items.DeleteOnSubmit(toDoForDelete);

            // Remove the to-do item from the appropriate category.   
            //switch (toDoForDelete.Category.Name)
            //{
            //    case "Home":
            //        HomeToDoItems.Remove(toDoForDelete);
            //        break;
            //    case "Work":
            //        WorkToDoItems.Remove(toDoForDelete);
            //        break;
            //    case "Hobbies":
            //        HobbiesToDoItems.Remove(toDoForDelete);
            //        break;
            //    default:
            //        break;
            //}

            // Save changes to the database.
            toDoDB.SubmitChanges();
        }
        public void DeleteSHList(ShoppingList shlistForDelete)
        {

            // Remove the to-do item from the "all" observable collection.
            //AllToDoItems.Remove(toDoForDelete);
            AllShoppingList.Remove(shlistForDelete);
            // Remove the to-do item from the data context.
            toDoDB.MyShoppingList.DeleteOnSubmit(shlistForDelete);

            // Remove the to-do item from the appropriate category.   
            //switch (toDoForDelete.Category.Name)
            //{
            //    case "Home":
            //        HomeToDoItems.Remove(toDoForDelete);
            //        break;
            //    case "Work":
            //        WorkToDoItems.Remove(toDoForDelete);
            //        break;
            //    case "Hobbies":
            //        HobbiesToDoItems.Remove(toDoForDelete);
            //        break;
            //    default:
            //        break;
            //}

            // Save changes to the database.
            toDoDB.SubmitChanges();
        }
        public void DeleteCatList(ToDoCategory catForDelete)
        {

            //mutipule row delete using linq
            var v = from ToDoItem todo in toDoDB.Items
                    where todo.Category.Id == catForDelete.Id
                    select todo;
            

            foreach (var detail in v)
            {
                //db.OrderDetails.DeleteOnSubmit(detail);
                toDoDB.Items.DeleteOnSubmit(detail);
            }

           var nv = from ToDoCategory todo in toDoDB.Categories
                    where todo.Id == catForDelete.Id
                    select todo;
            foreach (var detail in nv)
            {
                //db.OrderDetails.DeleteOnSubmit(detail);
                //toDoDB.Items.DeleteOnSubmit(detail);
                toDoDB.Categories.DeleteOnSubmit(detail);
            }   
                
           
           
           // AllToDoItems = new ObservableCollection<ToDoItem>(v);
            
            ItemCatagory.Remove(catForDelete);
            CategoriesList.Remove(catForDelete);
            ////AllShoppingList.Remove(shlistForDelete);
            //// Remove the to-do item from the data context.
            //toDoDB.Categories.DeleteOnSubmit(catForDelete);
            try {/* db.SubmitChanges();*/toDoDB.SubmitChanges(); }
            catch (Exception e) { }
            LoadCollectionsFromDatabase();
          //  toDoDB.SubmitChanges();
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        // Used to notify Silverlight that a property has changed.
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
