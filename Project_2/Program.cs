string? readResult;
string rolename = "";
bool validEntry = false;

do
{
    Console.WriteLine("Enter your role name(Administator, Manager or User)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        rolename = readResult.Trim();
    }
    if (rolename.ToLower() == "administator" || rolename.ToLower() == "manager" || rolename.ToLower() == "user")
    {
        validEntry = true;
    }

    else
    {
        Console.WriteLine($"The role name you entered \"{rolename}\" is not valid");
    }
} while (validEntry == false);
Console.WriteLine($"Your input value ({rolename}) has been accepted.");
Console.ReadLine();