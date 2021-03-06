using System;

namespace client
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Vulnerable v = new Vulnerable();

			string[] users = v.ListUsers();

			foreach (string user in users)
				Console.WriteLine(user);

			Console.WriteLine("Adding user blah:blah");
			v.AddUser("blah", "blah");

			users = v.ListUsers();

			foreach (string user in users)
				Console.WriteLine(user);

			Console.WriteLine("Selecting only blah");
			string u = v.GetUser("blah");

			Console.WriteLine(u);

			Console.WriteLine("Deleteing user blah");
			bool worked = v.DeleteUser("blah");

			Console.WriteLine("Worked? " + worked);

			Console.WriteLine("Attempting to select blah again");
			u = v.GetUser("blah");

			Console.WriteLine(u);
		}
	}
}