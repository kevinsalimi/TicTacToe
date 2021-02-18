using System;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Services
{
    public sealed class UserService : IUserService
    {
        public Task<bool> IsOnline(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterUser(UserModel userModel)
        {
            return Task.FromResult(true);
        }
    }
}
