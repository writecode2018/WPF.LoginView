using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.LoginView
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        Storyboard UserNameGetFocusStory = null;
        Storyboard UserNameLostFocusStory = null;
        Storyboard PasswordGetFocusStory = null;
        Storyboard PasswordLostFocusStory = null;

        Storyboard ServerIpGetFocusStory = null;
        Storyboard ServerIpLostFocusStory = null;
        Storyboard ServerPortGetFocusStory = null;
        Storyboard ServerPortLostFocusStory = null;

        AxisAngleRotation3D Axis3D = null;

        public LoginWindow()
        {
            InitializeComponent();

            UserNameGetFocusStory = this.TryFindResource("UserNameGetFocusStory") as Storyboard;
            UserNameLostFocusStory = this.TryFindResource("UserNameLostFocusStory") as Storyboard;
            PasswordGetFocusStory = this.TryFindResource("PasswordGetFocusStory") as Storyboard;
            PasswordLostFocusStory = this.TryFindResource("PasswordLostFocusStory") as Storyboard;
            ServerIpGetFocusStory = this.TryFindResource("ServerIpGetFocusStory") as Storyboard;
            ServerIpLostFocusStory = this.TryFindResource("ServerIpLostFocusStory") as Storyboard;
            ServerPortGetFocusStory = this.TryFindResource("ServerPortGetFocusStory") as Storyboard;
            ServerPortLostFocusStory = this.TryFindResource("ServerPortLostFocusStory") as Storyboard;

            Axis3D = this.FindName("aar") as AxisAngleRotation3D;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void UserNameGotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                UserNameGetFocusStory.Begin();
            }
        }

        private void UserNameLostFocus(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                UserNameLostFocusStory.Begin();
            }
        }

        private void PasswordGotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password.Length == 0)
            {
                PasswordGetFocusStory.Begin();
            }
        }

        private void PasswordLostFocus(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password.Length == 0)
            {
                PasswordLostFocusStory.Begin();
            }
        }

        private void ServerIpGotFocus(object sender, RoutedEventArgs e)
        {
            if (txtServerIp.Text.Length == 0)
            {
                ServerIpGetFocusStory.Begin();
            }
        }

        private void ServerIpLostFocus(object sender, RoutedEventArgs e)
        {
            if (txtServerIp.Text.Length == 0)
            {
                ServerIpLostFocusStory.Begin();
            }
        }

        private void ServerPortGotFocus(object sender, RoutedEventArgs e)
        {
            if (txtServerPort.Text.Length == 0)
            {
                ServerPortGetFocusStory.Begin();
            }
        }

        private void ServerPortLostFocus(object sender, RoutedEventArgs e)
        {
            if (txtServerPort.Text.Length == 0)
            {
                ServerPortLostFocusStory.Begin();
            }
        }

        private void BtnGoFront_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation()
            {
                Duration = new Duration(TimeSpan.FromMilliseconds(300)),
                To = 0
            };
            Axis3D.BeginAnimation(AxisAngleRotation3D.AngleProperty, animation);
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation()
            {
                Duration = new Duration(TimeSpan.FromMilliseconds(300)),
                To = 180
            };
            Axis3D.BeginAnimation(AxisAngleRotation3D.AngleProperty, animation);
        }
    }
}
