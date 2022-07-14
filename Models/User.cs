namespace СlothingStore.API.Models
{
    public class User
    {
        public ulong ID { get; set; }
        public string Nickname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public decimal Cash { get; set; }
        public float Status { get; set; }

        public User(ulong Id , string nickname, string login, string password, decimal cash, int status)
        {
            ID = Id;
            Nickname = nickname;
            Login = login;
            Password = password;
            Cash = cash;
            Status = status;
        }

        public override string ToString()
        {
            return $"ID: {ID}" +
                   $"\nNickname: {Nickname}" +
                   $"\nLogin: {Login}" +
                   $"\nPassword: {Password}:" +
                   $"\nCash: {Cash}" +
                   $"\nStatus: {Status}";
        }

    }

    public enum Accessibility
    {
        Client = 0,
        Admin = 1,
    }
}
