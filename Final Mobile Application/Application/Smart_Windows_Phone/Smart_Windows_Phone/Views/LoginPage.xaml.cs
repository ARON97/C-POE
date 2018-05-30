using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Smart_Windows_Phone.Resources;
using System.IO.IsolatedStorage;
using System.Runtime.Serialization;
using Smart_Windows_Phone.Model;
using System.IO;

namespace Smart_Windows_Phone
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
            }
        }
        //Creating an isolated file to store Userdetails inside
        public void AddressingLFolder{
        myDataContext db = new myDataContext("model:/mydb.sdf");
        //Get a file from the local folder
        FontVariants file = await Windows.StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appdata:///local/AppConfigSettings.xml"))
        }
       
        public void saveUserDetails(string message, string Username, string Password)
        {
            IsolatedStorageSettings.ApplicationSettings[Username] = message;
            IsolatedStorageSettings.ApplicationSettings[Password] = message;
            IsolatedStorageSettings.ApplicationSettings.Save();
            
        }
        //Verifyig that the user exists
        public string checkstring(string Username, string Password)
        {
            if(IsolatedStorageSettings.ApplicationSettings.Contains(Username) && IsolatedStorageSettings.ApplicationSettings.Contains(Password)){
                return (string)IsolatedStorageSettings.ApplicationSettings[Username];
                                return (string)IsolatedStorageSettings.ApplicationSettings[Password];

            }
            else{
                return null;
            }
        }
        //Saving to file
        public void saveToFile(string message){
            using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication())
            {
                StreamWriter writer = new StreamWriter(rawStream);
                writer.WriteLine(message);
                writer.Close();
            }
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/SignUpPage.xaml", UriKind.Relative));
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication())
            {
                string line;
                if(isf.FileExists("MyFile"){
                    var updatedLines = new List<string>();
                    using (IsolatedStorageFileStream rawStream  = isf.OpenFile("model:/mydb.sdf", FileMode.Open)){
                        StreamReader reader = new StreamReader(rawStream);
                        while ((line = reader.ReadLine()) != null)
                {
                    int counter = 1;
                    updatedLines.Add(line);
                    //Spliting the username and password using a Split metthod
                    string[] data = line.Split(':');
                    if (data[0] == Username.Text.Trim() && data[1] == Password.Password.Trim())
                    {
                        MessageBox.Show("LOGIN SUCCESSFULLY");
                        reader.ReadToEnd();
                        counter++;
                        break;
                    }
                    //Else statement for invalid username or password
                    else 
                    {

                            MessageBox.Show("INVALID USERNAME OR PASSWORD");
                            Username.Text = "";
                            Password.Password = "";
                            break;
                    } 
                       
                        
                    }
                reader.Close();
                    }
                }
            }
            }
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}