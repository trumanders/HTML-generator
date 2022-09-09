// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] apiInput = {"C#", "DataBaser", "WEbb", "CleAn cODE"};

string str1 = "<!DOCTYPE html>\n<html>\n<body>\n<main>";
string str2 = "<h1> Välkomna! </h1>";
string str3 = "";
foreach (string str in apiInput)
{
    string tmp = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (i == 0) tmp += str[i].ToString().ToUpper();
        else tmp += str[i].ToString().ToLower();
    }
    tmp = tmp.Trim();
    str3 += $"<h1> Kurs om {tmp}</p>\n";
}
string str4 = "</main>\n</body>\n</html>";

Console.WriteLine($"{str1}\n{str2}\n{str3}{str4}\n");