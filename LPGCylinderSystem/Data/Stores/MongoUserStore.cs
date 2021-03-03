﻿using LPGCylinderSystem.Models;
using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LPGCylinderSystem.Data.Stores 
{
    public class MongoUserStore<TUser,TKey> :  IUserStore<TUser>,IUserPasswordStore<TUser>,IUserPhoneNumberStore<TUser>,IUserRoleStore<TUser>,IUserEmailStore<TUser>

        where TUser : ApplicationUser, IIdentityUserRole
        where TKey:IEquatable<TKey>

    {
        private readonly IMongoCollection<TUser> _users;
        

        public MongoUserStore(MongoTablesFactory mongoProxy)
        {
            _users = mongoProxy.GetCollection<TUser>(MongoTablesFactory.TABLE_USERS);
            
        }

        //public Task AddToRoleAsync(TUser user, string roleName, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IdentityResult> CreateAsync(TUser user, CancellationToken cancellationToken)
        //{
        //     await _users.InsertOneAsync(user, cancellationToken: cancellationToken);
        //    return IdentityResult.Success;
        //}

        //public async Task<IdentityResult> DeleteAsync(TUser user, CancellationToken cancellationToken)
        //{

        //    await _users.DeleteOneAsync(x=>x.Id.Equals(user.Id), cancellationToken: cancellationToken);
        //    return IdentityResult.Success;
        //}

        //public void dispose()
        //{

        //}

        //public Task<TUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<TUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<string> GetNormalizedUserNameAsync(TUser user, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<string> GetPasswordHashAsync(TUser user, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IList<string>> GetRolesAsync(TUser user, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<string> GetUserIdAsync(TUser user, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<string> GetUserNameAsync(TUser user, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IList<TUser>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> HasPasswordAsync(TUser user, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> IsInRoleAsync(TUser user, string roleName, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task RemoveFromRoleAsync(TUser user, string roleName, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task SetNormalizedUserNameAsync(TUser user, string normalizedName, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task SetPasswordHashAsync(TUser user, string passwordHash, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task SetUserNameAsync(TUser user, string userName, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IdentityResult> UpdateAsync(TUser user, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}
        public virtual async Task<IdentityResult> CreateAsync(TUser user, CancellationToken token)
        {
            await _users.InsertOneAsync(user, cancellationToken: token);
            return IdentityResult.Success;
        }

        public virtual async Task<IdentityResult> UpdateAsync(TUser user, CancellationToken token)
        {
            await _users.ReplaceOneAsync(u => u.Id.Equals(user.Id), user, cancellationToken: token);
            return IdentityResult.Success;
        }

        public virtual async Task<IdentityResult> DeleteAsync(TUser user, CancellationToken token)
        {
            await _users.DeleteOneAsync(u => u.Id.Equals(user.Id), token);
            return IdentityResult.Success;
        }

        public Task<string> GetUserIdAsync(TUser user, CancellationToken cancellationToken)
            => Task.FromResult(user.Id.ToString());

        public Task<string> GetUserNameAsync(TUser user, CancellationToken cancellationToken)
            => Task.FromResult(user.UserName);
       
        public Task SetUserNameAsync(TUser user, string userName, CancellationToken cancellationToken)
        {
            user.UserName = userName;
            return Task.CompletedTask;
        }

        public Task<string> GetNormalizedUserNameAsync(TUser user, CancellationToken cancellationToken)
            => Task.FromResult(user.NormalizedUserName);

        public Task SetNormalizedUserNameAsync(TUser user, string normalizedUserName, CancellationToken cancellationToken)
        {
            user.NormalizedUserName = normalizedUserName;
            return Task.CompletedTask;
        }


        public virtual Task<TUser> FindByIdAsync(string userId, CancellationToken token)
            => IsObjectId(userId)
                ? _users.Find(u => u.Id.Equals(userId)).FirstOrDefaultAsync(token)
                : Task.FromResult<TUser>(null);

        private bool IsObjectId(string id)
        {
            ObjectId temp;
            return ObjectId.TryParse(id, out temp);
        }

       
        public virtual Task<TUser> FindByNameAsync(string normalizedUserName, CancellationToken token)
            => _users.Find(u => u.NormalizedUserName == normalizedUserName).FirstOrDefaultAsync(token);

        public Task SetPasswordHashAsync(TUser user, string passwordHash, CancellationToken token)
        {
            user.PasswordHash = passwordHash;
            return Task.CompletedTask;
        }

        public Task<string> GetPasswordHashAsync(TUser user, CancellationToken token)
            => Task.FromResult(user.PasswordHash);

        public Task<bool> HasPasswordAsync(TUser user, CancellationToken cancellationToken)
        { 
              if(user.PasswordHash!=null)      
                    return Task.FromResult(true);
              else
                    return Task.FromResult(false);
        }
          

        public Task AddToRoleAsync(TUser user, string roleName, CancellationToken cancellationToken)
        {
            user.AddRole(roleName);
            return Task.CompletedTask;
        }

        public Task RemoveFromRoleAsync(TUser user, string roleName, CancellationToken cancellationToken)
        {
            user.RemoveRole(roleName);
            return Task.CompletedTask;
        }

        public async Task<IList<string>> GetRolesAsync(TUser user, CancellationToken cancellationToken)
        {
            var roles = user.Roles?.ToArray() ?? Array.Empty<string>();
            return await Task.FromResult(roles);
        }

        public async Task<bool> IsInRoleAsync(TUser user, string roleName, CancellationToken cancellationToken)
        {
            var roles = await GetRolesAsync(user, cancellationToken);
            return roles.Contains(roleName);
        }

        public Task<IList<TUser>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
           
        }

        public Task SetEmailAsync(TUser user, string email, CancellationToken cancellationToken)
        {
            user.Email = email;
            return Task.CompletedTask;
        }

        public Task<string> GetEmailAsync(TUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Email);
        }

        public Task<bool> GetEmailConfirmedAsync(TUser user, CancellationToken cancellationToken)
        {
            
            return Task.FromResult(user.EmailConfirmed);
        }

        public Task SetEmailConfirmedAsync(TUser user, bool confirmed, CancellationToken CancellationToken)
        {
            user.EmailConfirmed = confirmed;
            return Task.CompletedTask;
        }

        public Task<TUser> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
        {
            return _users.Find(u => u.Email.ToUpper() ==normalizedEmail).FirstOrDefaultAsync();
        }

        public Task<string> GetNormalizedEmailAsync(TUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.NormalizedEmail);
        }

        public Task SetNormalizedEmailAsync(TUser user, string normalizedEmail, CancellationToken cancellationToken)
        {
            user.NormalizedEmail = normalizedEmail;
            return Task.CompletedTask;
        }

        public Task SetPhoneNumberAsync(TUser user, string phoneNumber, CancellationToken cancellationToken)
        {
            user.PhoneNumber = phoneNumber;
            
            
            return Task.CompletedTask;
        }

        public Task<string> GetPhoneNumberAsync(TUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.PhoneNumber);
        }

        public Task<bool> GetPhoneNumberConfirmedAsync(TUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetPhoneNumberConfirmedAsync(TUser user, bool confirmed, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
       

    }
}
