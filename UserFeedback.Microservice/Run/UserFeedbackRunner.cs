using PipServices.Runtime.Run;

namespace User.Feedback.Microservice.Run
{
    public class UserFeedbackRunner : ProcessRunner
    {
        public UserFeedbackRunner() : 
            base(new UserFeedbackMicroservice())
        {
        }
    }
}
