using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Crowe_robert_SoftwareII_CSharp
{
    public partial class Login : Form

    {
        private static bool usernameExists = false, nameValid = false, passwordValid = false;
        private static int langChooser = 2;
        public static string GetUsername() { return dbHelper.loginName; }
        public static void SetUsername(string userName){ dbHelper.loginName = userName; }

        public Login() { InitializeComponent(); }

        private void btLoginClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private static bool UsernameExists(TextBox name)
        {
            using (var context = new U05oDKEntities())
            {
                bool userNameExists = context.users.Any(n => n.userName == name.Text);
                if (userNameExists == true)
                {
                    user holder = context.users.First(n => n.userName == name.Text);
                    dbHelper.user1 = holder;
                    SetUsername(dbHelper.user1.userName);
                }
                return userNameExists;
            }
        }

        private void btLoginLogin_Click(object sender, EventArgs e)
        {
            nameValid = dbHelper.isValid(tbLoginUsername, lbLoginUsername);
            passwordValid = dbHelper.isValid(tbLoginPassword, lbLoginPassword);
            if(AllValid() != false)
            {
                try
                {

                    if (UsernameExists(tbLoginUsername) == true)
                    {
                        try
                        {

                            if (dbHelper.user1.password == tbLoginPassword.Text)
                            {
                                Main main = new Main(this);
                                SetUsername(tbLoginUsername.Text);
                                dbHelper.LogData(tbLoginUsername.Text, true);
                                this.Hide();
                                main.Show();
                            }
                            else
                            {
                                throw (new CustomEx());
                            }
                        }
                        catch (CustomEx ex)
                        {
                            dbHelper.LogData(tbLoginUsername.Text, false);
                            ex.BadPasswordException(Lang.GetInvalidPassword(langChooser), Lang.GetinvalidPasswordTitle(langChooser));
                        }
                    }
                    else
                    {
                        throw (new CustomEx());}
                }
                    
                catch (CustomEx ex)
                {
                    dbHelper.LogData(tbLoginUsername.Text, false);
                    ex.NoUserException(Lang.GetInvalidUsername(langChooser), Lang.GetInvalidUsernameTitle(langChooser));
                }
            }
        }

        public void clearInputs()
        {
            tbLoginUsername.Text = "";
            tbLoginPassword.Text = "";
            SetUsername("");
        }

        private static bool AllValid()
        {
            if(nameValid != false && passwordValid != false) { return true; }
            else { return false; }
        }

        private void SetCulture()
        {
            CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.Name);
            dbHelper.cultureHolder = ci.Name;
            string cName = ci.Name.ToLower().Substring(0, 2);
            if (cName == "en") {langChooser = 1; }
            else if (cName == "de"){langChooser = 2; }
            else { MessageBox.Show("Unknown region selected."); langChooser = 3; }
        }

        private void SetLang()
        {
            this.Text = Lang.GetTitle(langChooser);
            lbLoginWelcome.Text = Lang.GetWelcome(langChooser);
            lbLoginUsername.Text = Lang.GetUsername(langChooser);
            lbLoginPassword.Text = Lang.GetPassword(langChooser);
            btLoginLogin.Text = Lang.GetLogin(langChooser);
            btLoginClose.Text = Lang.GetClose(langChooser);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SetCulture();
            SetLang();
        }
    }
}
