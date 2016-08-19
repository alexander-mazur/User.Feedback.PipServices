using PipServices.Runtime;
using PipServices.Runtime.Config;
using PipServices.Runtime.Logic;
using User.Feedback.Microservice.Persistence;

namespace User.Feedback.Microservice.Logic
{
    public class UserFeedbackController : AbstractController, IUserFeedbackBusinessLogic
    {
        public static readonly ComponentDescriptor ClassDescriptor = 
            new ComponentDescriptor(Category.Controllers, "UserFeedback", "*", "*");

        private IUserFeedbackPersistence _db;

        public UserFeedbackController()
            : base(ClassDescriptor)
        {
        }

        public override void Link(ComponentSet components)
        {
            base.Link(components);

            _db = (IUserFeedbackPersistence)components.GetOneRequired(new ComponentDescriptor(Category.Persistence, "UserFeedback", null, null));
        }
    }
}
