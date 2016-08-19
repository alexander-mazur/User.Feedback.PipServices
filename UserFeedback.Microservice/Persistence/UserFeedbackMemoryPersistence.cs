using PipServices.Runtime.Config;
using PipServices.Runtime.Persistence;

namespace User.Feedback.Microservice.Persistence
{
    public class UserFeedbackMemoryPersistence : AbstractPersistence, IUserFeedbackPersistence
    {
        public static readonly ComponentDescriptor ClassDescriptor = 
            new ComponentDescriptor(Category.Persistence, "UserFeedback", "memory", "*");

        public UserFeedbackMemoryPersistence()
            : base(ClassDescriptor)
        {
        }
    }
}
