namespace СlothingStore.Models
{
    public class User
    {
        public long ID { get; set; }
        public string Nickmame { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public decimal Cash { get; set; }
        public Accessibility Status { get; set; }

        public User(long Id , string nickmame, string login, string password, decimal cash, Accessibility status)
        {
            ID = Id;
            Nickmame = nickmame;
            Login = login;
            Password = password;
            Cash = cash;
            Status = status;
        }

        public override string ToString()
        {
            return $"ID: {ID}" +
                   $"\nNickname: {Nickmame}" +
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
