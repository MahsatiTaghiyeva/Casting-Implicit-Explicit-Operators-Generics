bool CheckAccess(UserRole role)
{
    if(role==UserRole.Admin || role ==UserRole.Moderator)
        return true;
    return false;
}
System.Console.WriteLine(CheckAccess(UserRole.Admin));
System.Console.WriteLine(CheckAccess(UserRole.Moderator));
System.Console.WriteLine(CheckAccess(UserRole.Member));
System.Console.WriteLine(CheckAccess(UserRole.Guest));