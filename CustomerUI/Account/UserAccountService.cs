using CustomerUI.Data;

namespace CustomerUI.Account
{
    public class UserAccountService
    {
        private List<LoginDTO> _users;

        public UserAccountService()
        {
            _users = new List<LoginDTO>
            {
                new LoginDTO{Email= "admin@test.com", Password="Admin@123", Role = "Admin"},
                new LoginDTO{Email = "user@test.com", Password="user", Role = "User"}
            };
        }
        public LoginDTO? GetByUserName(string eamil)
        {
            return _users.FirstOrDefault(x => x.Email == eamil);
        }
    }
}
