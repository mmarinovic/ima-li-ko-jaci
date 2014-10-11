namespace KisaMetaka.ImaLiKoJaci.Infrastructure.User
{
    public interface IUserRepository
    {
        void Create(string displayName, string facebookId);
        UserDto TryGet(string facebookId);
    }
}
