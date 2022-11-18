using Tema;
User user1 = new User(username:"Robi",email:"trifasrobert@gmail.com",password:"abcdefg");
User user2 = new User(username: "Patrick", email: "patrick@yahoo.com", password: "dawdf");


List<User> userlist=new List<User>();
userlist.Add(user1);
userlist.Add(user2);

foreach (var user in userlist)

{
    Console.WriteLine(user.ToString());
}