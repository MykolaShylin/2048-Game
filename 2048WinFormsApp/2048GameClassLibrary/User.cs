namespace _2048GameClassLibrary
{
    public class User
    {
        public string Name { get; }
        public int Score { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}