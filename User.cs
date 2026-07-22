namespace MyFirstProgram
{
    public class User
    {
        // Tutaj definiujemy imię uzytkownika
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public bool IsActive { get; set; }
    }
}