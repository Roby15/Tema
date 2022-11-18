using System.Runtime.CompilerServices;

namespace Tema;

public abstract class Application

{   
    private string name_app;
    private int maxusernumber=10;
    private string users;
    private int usernumber = 5;
    
   public string GetName()
   {
       return name_app;
   }

   public abstract string user
   {
       get; 
       
   }

  
   




   public int GetNumberOfUsers()
   {
       usernumber = user.Count();
       return usernumber;
   }

   public  string ToString()
   {
       return GetName() + GetNumberOfUsers();
   }
   
   
}