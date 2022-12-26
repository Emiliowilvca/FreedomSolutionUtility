namespace Freedom.Utility.Models.BaseEntity
{
    public interface ILogin
    {
        string EndPoint { get; set; }

        string Password { get; set; }

        string Email { get; set; }

        bool Rememberme { get; set; }

    }
}