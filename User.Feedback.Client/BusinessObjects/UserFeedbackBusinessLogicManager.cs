using System;
using System.Collections.Generic;
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

        Task<IList<UserFeedback>> IUserFeedbackBusinessLogicManager.AskUserFeedbackCollection()
        {
            throw new NotImplementedException();
        }
    }
}