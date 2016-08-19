using System;
using System.Threading.Tasks;
using User.Feedback.Common;

namespace User.Feedback.Client.BusinessObjects
{
    public class UserFeedbackBusinessLogicManager : IUserFeedbackBusinessLogicManager
    {
        public UserFeedbackBusinessLogicManager()
        {
        }

        public void TellUserFeedback(UserFeedback userFeedback)
        {
            throw new NotImplementedException();
        }

        public Task<Messages.UserFeedbackCollectionResponse> AskUserFeedbackCollection()
        {
            throw new NotImplementedException();
        }
    }
}