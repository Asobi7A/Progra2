using System.Dynamic;
using System.Runtime.CompilerServices;

class accesoUser
{
    private string user;
    private bool admin;

    public accesoUser()
    {
        user = "";
        admin = false;
    }

    public accesoUser(string user){
        this.user = user; 
        if (this.user == "admin")
        {
            admin = true;
        } else
        {
            admin = false;
        }
    }

    public void setAdmin()
    {
        Console.WriteLine("Ingrese Usuario;");
        user = Console.ReadLine();
        if (user == "admin")
        {
            admin = true;
        } else
        {
            admin = false;
        }
    }

    public bool getNivelAcceso()
    {
        return admin;
    }

}