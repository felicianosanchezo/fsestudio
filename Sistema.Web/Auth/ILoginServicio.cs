namespace Sistema.Web.Auth
{
    public interface ILoginServicio
    {
        Task LoginAsync(string token);
        Task LogoutAsync();

    }
}
