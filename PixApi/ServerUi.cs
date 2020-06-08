using PixBlocks.Server.DataModels.DataModels;
using PixBlocks.Server.DataModels.DataModels.DBModels;
using PixBlocks.Server.DataModels.DataModels.UserProfileInfo;
using PixBlocks.ServerFasade.ServerAPI;
using PixBlocks.ServerFasade.UserManagment;
using System.Collections.Generic;

namespace PixApi
{
    class ServerUi
    {
        public ServerUi()
        {
            BaseApi = new ServerApi();
            
        }

        public ServerApi BaseApi { get; }
        public User GetCurrentUser { get => CurrentUserInfo.CurrentUser; }

        public EditedQuestionCode AddOrUpdateEditedQuestionCode(EditedQuestionCode editedQuestionCode)
        {
            return BaseApi.AddOrUpdateEditedQuestionCode(editedQuestionCode, GetCurrentUser, CurrentUserInfo.AuthorizeData);
        }

        public QuestionResult AddOrUpdateQuestionResult(QuestionResult questionResult)
        {
            return BaseApi.AddOrUpdateQuestionResult(questionResult, CurrentUserInfo.AuthorizeData);
        }

        public ToyShopData UpdateToyShopInfo(ToyShopData toyShopData)
        {
            return BaseApi.AddOrUpdateToyShopInfo(toyShopData, CurrentUserInfo.AuthorizeData);
        }

        public List<Notification> GetAllNotificationsForUser()
        {
            return BaseApi.GetAllNotificationsForUser(CurrentUserInfo.AuthorizeData);
        }

        public List<EditedQuestionCode> GetAllQuestionsCodes()
        {
            return BaseApi.GetAllQuestionsCodes(GetCurrentUser, CurrentUserInfo.AuthorizeData);
        }

        public List<QuestionResult> GetAllQuestionsResults()
        {
            return BaseApi.GetAllQuestionsResults(GetCurrentUser, CurrentUserInfo.AuthorizeData);
        }

        public List<Notification> GetNotifications()
        {
            return BaseApi.GetNotificationForUser("1", CurrentUserInfo.AuthorizeData);
        }

        public GetToyShopDataResult GetToyShop()
        {
            return BaseApi.GetUserToysShopInfo(GetCurrentUser, CurrentUserInfo.AuthorizeData);
        }

        public User UpdateUser(User NewUser)
        {
            return BaseApi.UpdateOrDeleteUser(NewUser, CurrentUserInfo.AuthorizeData);
        }
    }
}
