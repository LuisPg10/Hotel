namespace Entidades
{
    public class Persona
    {
        public uint Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Persona()
        {
            
        }
        public Persona(string username, string password)
        {
            Id = 0;
            Username = username;
            Password = password;
        }

        public Persona(uint id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }
    }
}