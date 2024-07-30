using Application.Models;

namespace Application.Users;

public interface IUserService
{
    Task<ServiceResult<UserCreateResponseDto>> Create(UserCreateRequestDto request);

    ServiceResult Delete(
        UserCreateRequestDto request);
}