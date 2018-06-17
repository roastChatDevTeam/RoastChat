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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace RoastChat
{

    public partial class MainWindow : Window
    {
        private RoastChatClientInterface client = new RoastChatClient();
        private const String usernameToken = "Username: ";

        public MainWindow()
        {
            InitializeComponent();
            client.setWindow(this);

        }


        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Button buttonClicked = (Button)sender;
            String Uid = buttonClicked.Uid;
            switch (Uid)
            {
                case "btnLogin":
                    login(txtBoxLoginUser.Text, txtBoxLoginPassword.Text);
                    break;
                case "btnCreateUser":
                    createUser(txtBoxCreateUserName.Text, txtBoxCreateUserPassword.Text);
                    break;
                case "btnLogOut":
                    logOut();
                    break;
                case "btnChangeToPassword":
                    changeToPassword(txtBoxCurrentPassword.Text, txtBoxChangeToPassword.Text);
                    break;
                case "btnSend":
                    send(messageInput.Text);
                    break;
            }




        }

        public void reciveUsername(String s)
        {
            labelCurrentUsername.Content = usernameToken + s;
        }

        private void login(String username, String password)
        {
            if (client.login(username, password)) reciveUsername(username);

        }

        private void createUser(String username, String password)
        {
            if (client.createUser(username, password))
                login(username, password);
        }

        private void logOut()
        {
            if (client.logout()) this.reciveUsername("");
        }

        private void changeToPassword(String curerentPass, String changeToPass)
        {
            client.changePassword(curerentPass, changeToPass);
        }

        private void send(String message)
        {
            client.send(message);
            messageInput.Text = "";
        }

        public void ReciveMessage(Message message)
        {
            chatBox.Text = chatBox.Text
                + "\n"
                + message.getSender()
                + " (" + message.getTime()
                + "): " + message.getMessage();
        }


        private void textBoxKeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            String Uid = textBox.Uid;

            switch (Uid)
            {
                case "messageInput":
                    if (e.Key == Key.Enter)
                    {
                        send(messageInput.Text);
                    }
                    break;
                default:
                    break;
            }



        }
    }


}