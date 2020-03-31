
namespace Crowe_robert_SoftwareII_CSharp
{
    class Lang
    {
        private static string title, welcome, username, password, login, close, invalidUsername, invalidUsernameTitle, invalidPassword, invalidPasswordTitle;

        public static string GetTitle(int index)
        {
            if (index == 1) { title = "Login"; return title; }
            else { title = "Anmeldung"; return title; }
        }
        public static string GetWelcome(int index)
        {
            if (index == 1) { welcome = "Please sign-in below"; return welcome; }
            else { welcome = "Bitte melden Sie sich unten an"; return welcome; }
        }
        public static string GetUsername(int index)
        {
            if (index == 1) { username = "Username"; return username; }
            else { username = "Nutzername"; return username; }
        }
        public static string GetPassword(int index)
        {
            if (index == 1) { password = "Password"; return password; }
            else { password = "Passwort"; return password; }
        }
        public static string GetLogin(int index)
        {
            if (index == 1) { login = "Sign-in"; return login; }
            else { login = "Einloggen"; return login; }
        }
        public static string GetClose(int index)
        {
            if (index == 1) { close = "Close"; return close; }
            else { close = "schließen"; return close; }
        }
        public static string GetInvalidUsername(int index)
        {
            if (index == 1) { invalidUsername = "A user with that username was not found."; return invalidUsername; }
            else { invalidUsername = "Ein Benutzer mit diesem Benutzernamen wurde nicht gefunden."; return invalidUsername; }
        }
        public static string GetInvalidUsernameTitle(int index)
        {
            if (index == 1) { invalidUsernameTitle = "Warning: Invalid Username"; return invalidUsernameTitle; }
            else { invalidUsernameTitle = "Warnung: Ungültiger Benutzername"; return invalidUsernameTitle; }
        }
        public static string GetInvalidPassword(int index)
        {
            if (index == 1) { invalidPassword = "Your password is incorrect."; return invalidPassword; }
            else { invalidPassword = "Dein Passwort ist falsch."; return invalidPassword; }
        }
        public static string GetinvalidPasswordTitle(int index)
        {
            if (index == 1) { invalidPasswordTitle = "Warning: Invalid Password"; return invalidPasswordTitle; }
            else { invalidPasswordTitle = "Warning: Invalid Password"; return invalidPasswordTitle; }
        }
    }
}
