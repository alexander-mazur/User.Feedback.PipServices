using PipServices.Runtime;
using PipServices.Runtime.Config;
using PipServices.Runtime.Services;

using User.Feedback.Microservice.Logic;

namespace User.Feedback.Microservice.Services
{
    public class UserFeedbackRestService : RestService, IUserFeedbackRestService
    {
        public static readonly ComponentDescriptor ClassDescriptor = new ComponentDescriptor(Category.Services, "UserFeedback", "rest", "1.0");

        private IUserFeedbackBusinessLogic _logic;

        public UserFeedbackRestService()
            : base(ClassDescriptor, typeof(IUserFeedbackRestService))
        {
        }

        public override void Link(ComponentSet components)
        {
            base.Link(components);

            _logic = (IUserFeedbackBusinessLogic) components.GetOnePrior(this, new ComponentDescriptor(Category.BusinessLogic, "UserFeedback", "*", "*"));
        }
    }
}
