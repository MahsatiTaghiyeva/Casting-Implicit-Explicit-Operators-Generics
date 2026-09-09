bool CheckAccess(Enum roleEnum)
{
    if(roleEnum is not UserRole)
        return false;
    if(roleEnum is UserRole.Admin || roleEnum is UserRole.Moderator)
        return true;
    return false;
}
System.Console.WriteLine(CheckAccess(UserRole.Admin));
System.Console.WriteLine(CheckAccess(UserRole.Moderator));
System.Console.WriteLine(CheckAccess(UserRole.Member));
System.Console.WriteLine(CheckAccess(UserRole.Guest));