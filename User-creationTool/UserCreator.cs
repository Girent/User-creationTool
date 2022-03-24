using System;
using System.DirectoryServices;

namespace UserCrationTool
{
    internal class UserCreator
    {
        public static void Create(string login, string password, string description = "")
        {
            DirectoryEntry AD = new DirectoryEntry("WinNT://" +
            Environment.MachineName + ",computer");
            DirectoryEntry NewUser = AD.Children.Add(login, "user");
            NewUser.Invoke("SetPassword", new object[] { password });
            NewUser.Invoke("Put", new object[] { "Description", description });
            NewUser.CommitChanges();

            DirectoryEntry grp;
            grp = AD.Children.Find("Пользователи", "group");
            if (grp != null)  
                grp.Invoke("Add", new object[] { NewUser.Path.ToString() });
            grp = AD.Children.Find("Пользователи удаленного рабочего стола", "group");
            if (grp != null)  
                grp.Invoke("Add", new object[] { NewUser.Path.ToString() }); 
        }
    }
}
