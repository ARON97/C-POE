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
using System.Text.RegularExpressions;
using Smart_Windows_Phone.Model;
using System.Runtime.Serialization;

namespace Smart_Windows_Phone.Views
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
        IsolatedStorageFile ISOFile = IsolatedStorageFile.GetUserStoreForApplication();

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //Username Validation
            if(!Regex.IsMatch(TxtUserName.Text.Trim(), @ "^[A-Za-z_][a-zA-ZO-9_\s]*$" ));
            {
                MessageBox.Show("Invalid UserName");
            }

            //Password Length Validation
            else if(TxtPwd.Password.Length < 6)
            {
                MessageBox.Show("Password length should be minimun of 6 characters!")
            }
            else if(TxtUserName.Text != "" && TxtPwd.Password != "")
            {
                UserData ObjUserData = new UserData();
                ObjUserData.UserName = TxtUserName.Text;
                ObjUserData.Password = TxtPwd.Password;

                int Temp = 0;

                foreach ( var UserLogin in ObjUserDataList)
                {
                    if(ObjUserData.Username == UserLogin.UserName)
                    {
                        Temp = 1;
                    }
                }
                if(Temp== 0)
                {
                    ObjUserDataList.Add(ObjUserData);

                    if(ISOFile.FileExists("RegistrationDetails"))
                    {
                        ISOFile.DeleteFile("RegistrationDetails");
                        using(IsolatedStorageFileStream fileStream = ISOFile.OpenFile("RegistrationDetails", System.IO.FileMode.Create))
                        {
                            DataContractSerializer serializer = new DataContractSerializer(typeof(List<UserData>));

                            serializer.WriteObject(fileStream, ObjUserDataList);
                            {
                                MessageBox.Show("Congrats!");
                                NavigationService.Navigate(new Uri("/Views/LoginPage.xaml", UriKind.Relative));
                            }
                            else
                            {
                                MessageBox.Show("Sorry");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter all Details");
                        }
                    }
                }
            }
        }
    }
}