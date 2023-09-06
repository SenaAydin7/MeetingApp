namespace MeetingApp.Models
{
    public static class Repository
    {
            private static List<UserInfo> _users = new();
            static Repository()
            {
                _users.Add(new UserInfo(){Id=1,Name="Ali",Email="ali@gmail.com",Phone="1111",WillAttend=true});
                _users.Add(new UserInfo(){Id=2,Name="Hasan",Email="hasan@gmail.com",Phone="2222",WillAttend=false});
                _users.Add(new UserInfo(){Id=3,Name="Ayse",Email="ayse@gmail.com",Phone="3333",WillAttend=true});
            }
            public static List<UserInfo> Users{
                get{
                    return _users;
                }
            }

            public static void CreateUser(UserInfo user)
            {
                user.Id = Users.Count + 1;
                _users.Add(user);
            }

            public static UserInfo? GetById(int id)
            {
                return _users.FirstOrDefault(user => user.Id == id);
            }

    }
}