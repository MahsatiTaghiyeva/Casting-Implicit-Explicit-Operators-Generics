using ConsoleApp51;

static void Main(string[] args)
{
    bool CheckAccess(UserRole roleEnum)
    {
        if (roleEnum is UserRole role)
        {
            if (role == UserRole.Admin || role == UserRole.Moderator)
            {
                return true;
            }
        }

        return false;
    }

    Console.WriteLine(CheckAccess(UserRole.Admin));      
    Console.WriteLine(CheckAccess(UserRole.Moderator)); 
    Console.WriteLine(CheckAccess(UserRole.Member));     
    Console.WriteLine(CheckAccess(UserRole.Guest));      
}

