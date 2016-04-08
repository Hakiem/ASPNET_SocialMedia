using ASPNET_SocialMedia.Data.Infrastructure;
using ASPNET_SocialMedia.Model.Models;
using ASPNET_SocialMedia.Data.Repository;

namespace ASPNET_SocialMedia.Service
{

    public interface IGroupUpdateUserService
    {

        
        void CreateGroupUpdateUser(string userId, int groupUpdateId);
        void DeleteGroupUpdateUser(string userId, int groupUpdateId);

        ApplicationUser GetGroupUpdateUser(int groupUpdateId);

        void DeleteGroupUpdateUser(int id);
        void SaveGroupUpdateUser();
       
    }

    public class GroupUpdateUserService : IGroupUpdateUserService
    {
        private readonly IGroupUpdateUserRepository groupUpdateUserRepository;
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;

        public GroupUpdateUserService(IGroupUpdateUserRepository groupUpdateUserRepository, IUnitOfWork unitOfWork, IUserRepository userRepository)
        {
            this.groupUpdateUserRepository = groupUpdateUserRepository;
            this.userRepository = userRepository;
            this.unitOfWork = unitOfWork;

        }

        #region IGroupUpdateUserService Members

        public void DeleteGroupUpdateUser(string userId, int groupUpdateId)
        {
            var groupUpdateUser = groupUpdateUserRepository.Get(cu => cu.UserId == userId && cu.GroupUpdateId == groupUpdateId);
            groupUpdateUserRepository.Delete(groupUpdateUser);
            SaveGroupUpdateUser();
        }

        public void DeleteGroupUpdateUser(int id)
        {
            var groupUpdateUser = groupUpdateUserRepository.GetById(id);
            groupUpdateUserRepository.Delete(groupUpdateUser);
            SaveGroupUpdateUser();
        }


        public void SaveGroupUpdateUser()
        {
            unitOfWork.Commit();
        }

       
        public ApplicationUser GetGroupUpdateUser(int groupUpdateId)
        {
            var groupUpdateUserId = groupUpdateUserRepository.Get(g => g.GroupUpdateId == groupUpdateId).UserId;
            var user = userRepository.Get(u => u.Id == groupUpdateUserId);
            return user;

        }


        public void CreateGroupUpdateUser(string userId, int groupUpdateId)
        {
            var groupUpdateUser = new GroupUpdateUser { UserId = userId, GroupUpdateId = groupUpdateId };
            groupUpdateUserRepository.Add(groupUpdateUser);
            SaveGroupUpdateUser();
        }
        #endregion
    }
}
