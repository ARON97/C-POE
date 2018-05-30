using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using System.IO;

namespace Smart_Windows_Phone.Views
{
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void Appointments_Loaded(object sender, RoutedEventArgs e)
        {
            using (IsolatedStorageFile Appointments = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (Appointments.FileExists("Appointments.txt"))
                {
                    StreamReader reader = null;
                    using (var IsolatedStorageFileStream = Appointments.OpenFile("Appointments.txt", FileMode.Open))
                    {
                        reader = new StreamReader(new IsolatedStorageFileStream("View\\Appointments.txt", FileMode.Open, Appointments));
                        string filetext = reader.ReadLine();
                        listAppointments.items.Add(filetext);
                    }
                }
            }
        }
    }
   
}