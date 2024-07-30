namespace Application.Users
{
    public record UserCreateRequestDto(string Name, string Email, string Password)
    {
        public bool ValidatePassword()
        {
            return Password.Length > 7;
        }
    }
}