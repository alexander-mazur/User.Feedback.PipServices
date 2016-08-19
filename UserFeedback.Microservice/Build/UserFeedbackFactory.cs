using PipServices.Runtime.Build;
using User.Feedback.Microservice.Logic;
using User.Feedback.Microservice.Persistence;
using User.Feedback.Microservice.Services;

namespace User.Feedback.Microservice.Build
{

    public class UserFeedbackFactory : ComponentFactory
    {
        public static readonly UserFeedbackFactory Instance = new UserFeedbackFactory();

        public UserFeedbackFactory()
            : base(DefaultFactory.Instance)
        {
            Register(UserFeedbackMemoryPersistence.ClassDescriptor, typeof(UserFeedbackMemoryPersistence));
            Register(UserFeedbackController.ClassDescriptor, typeof(UserFeedbackController));
            Register(UserFeedbackRestService.ClassDescriptor, typeof(UserFeedbackRestService));
        }
    }
}
