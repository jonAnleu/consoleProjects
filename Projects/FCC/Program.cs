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

List<string> words = new List<string>() {"ONE", "TWO", "ONE", "three", "four"};

 List<string> GetOnlyUpperCaseWords(List<string> words)
{
  List<string> upperCaseWords = new List<string>();

  foreach (string word in words)
  {
    // Check if all characters in the word are uppercase letters
    if (word.All(char.IsUpper))
    {
      upperCaseWords.Add(word);
    }
  }
  Console.WriteLine(upperCaseWords);
  return upperCaseWords;

  
}
  GetOnlyUpperCaseWords(words);
