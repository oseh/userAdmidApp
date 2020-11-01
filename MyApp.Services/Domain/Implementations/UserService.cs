using System;
using System.Collections.Generic;
using MyApp.Data;
using MyApp.Models;
using MyApp.Services.Domain.Implementations.Base;
using MyApp.Services.Domain.Interfaces;

namespace MyApp.Services.Domain.Implementations
{
    public class UserService : ServiceBase<User>, IUserService
    {
        IDataAccess _dataAccess;
        public UserService(IDataAccess dataAccess) : base(dataAccess) {
            _dataAccess = dataAccess;
        }
        /// <summary>
        /// Return users by active state
        /// </summary>
        /// <param name="isActive"></param>
        /// <returns></returns>
        public IEnumerable<User> FilterByActive(bool isActive)
        {
            return _dataAccess.FilterByActive<User>(isActive);
        }
    }
}
