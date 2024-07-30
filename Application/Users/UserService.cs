using Application.Models;
using System.Net;

namespace Application.Users
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        // success => empty
        // success => model
        // fail => empty
        // fail => error message
        public async Task<ServiceResult<UserCreateResponseDto>> Create(UserCreateRequestDto request)
        {
            if (await userRepository.AnyEmail(request.Email))
            {
                return ServiceResult<UserCreateResponseDto>.CreateFail(
                    ["kullanıcı email adresi veri tabanında bulunmaktadır"], HttpStatusCode.BadRequest);
            }

            return ServiceResult<UserCreateResponseDto>.CreateSuccess(
                new UserCreateResponseDto(Guid.NewGuid().ToString()), HttpStatusCode.Created);
        }


        public async Task<ServiceResult> UpdateUserName(string userName)

        {
            ServiceResult result;

            //if (userName.Length <= 6)
            //{
            //    result= ServiceResult.CreateFail("",HttpStatusCode.BadRequest);
            //}
            //else if (await userRepository.AnyUserName(userName))
            //{
            //    result = ServiceResult.CreateFail("", HttpStatusCode.BadRequest);
            //}
            //else
            //{

            //}

            // Fast Fail + Guard clauses


            if (await ValidateUserName(userName))
            {
            }

            if (userName.Length <= 6)
            {
                return ServiceResult.CreateFail("", HttpStatusCode.BadRequest);
            }


            if (await userRepository.AnyUserName(userName))
            {
                return ServiceResult.CreateFail("", HttpStatusCode.BadRequest);
            }

            // update

            return ServiceResult.CreateSuccess();
        }

        private async Task<bool> ValidateUserName(string userName)
        {
            return userName.Length <= 6 || await userRepository.AnyUserName(userName) || userName.Contains("mehmet");
        }


        public void Check(decimal price)

        {
            if (price < 5000)
            {
                return;
            }
        }

        public ServiceResult Delete(
            UserCreateRequestDto request)
        {
            return ServiceResult.CreateSuccess();
        }
    }
}