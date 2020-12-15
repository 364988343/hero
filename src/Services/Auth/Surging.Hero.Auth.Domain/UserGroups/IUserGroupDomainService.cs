﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.Domain.PagedAndSorted;
using Surging.Hero.Auth.Domain.Permissions;
using Surging.Hero.Auth.IApplication.Role.Dtos;
using Surging.Hero.Auth.IApplication.User.Dtos;
using Surging.Hero.Auth.IApplication.UserGroup.Dtos;
using Surging.Hero.Common;

namespace Surging.Hero.Auth.Domain.UserGroups
{
    public interface IUserGroupDomainService : ITransientDependency
    {
        Task Create(CreateUserGroupInput input);
        Task Update(UpdateUserGroupInput input);
        Task Delete(long id);
        Task<IEnumerable<GetDisplayRoleOutput>> GetUserGroupRoles(long userGroupId, Common.Status? status = null);
        Task<IEnumerable<GetUserBasicOutput>> GetUserGroupUsers(long userGroupId);
        Task<bool> CheckPermission(long userId, string serviceId);
        Task<string> AllocationUsers(AllocationUserIdsInput input);
        Task DeleteUserGroupUser(DeleteUserGroupUserInput input);
        Task<IPagedResult<GetUserNormOutput>> SearchUserGroupUser(QueryUserGroupUserInput query);
        Task UpdateStatus(UpdateUserGroupStatusInput input);
        Task<IEnumerable<GetDisplayPermissionOutput>> GetUserGroupPermissions(long userGroupId, Status status = Status.Valid);
    }
}
