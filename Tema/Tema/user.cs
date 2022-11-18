namespace Tema;


    public class User:Application
    {
        public string username;
        public string email;
        public string password;


        public User(string username, string email, string password)
        {
            this.username = username;
            this.email = email;
            this.password = password;
        }
        
        public string GetMail()
        {
            return email;
        }

        public string ChangePassword(string newPassword)
        {

            password = newPassword;
            return password;
        }

        public string ToString()
        {
            return "\n" + "Nume:" + username + "\n" + "Email:" + GetMail();

        }

        public override string user
        {
            get
            ;

        }

         List<User> userlist = new List<User>();
    }

