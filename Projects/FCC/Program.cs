/* SIMPLE PASSWORD CHECKER
Console.Write("Enter a password: ");
string password = Console.ReadLine();
Console.Write("Enter password again to confirm: ");
string confirm = Console.ReadLine();

if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirm))
{
  string result = (password == confirm)? "Passwords Match": "Passwords don't match";
  Console.Write(result);
} */
