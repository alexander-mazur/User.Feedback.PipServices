using User.Feedback.Microservice.Build;

namespace User.Feedback.Microservice.Run
{
    public class UserFeedbackMicroservice : PipServices.Runtime.Run.Microservice
    {
        public UserFeedbackMicroservice() : 
            base("UserFeedback", UserFeedbackFactory.Instance)
        {
        }
    }
}