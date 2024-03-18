
string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
string envUserName = Environment.UserName;
string output = String.Format("Identified {0} {1} {2}", DateTime.Now, userName, envUserName);

Console.WriteLine(output);

string fileName = String.Format(".\\{0}.txt",envUserName);

using (StreamWriter writer = new StreamWriter(fileName))
{
    writer.WriteLine(output);
}