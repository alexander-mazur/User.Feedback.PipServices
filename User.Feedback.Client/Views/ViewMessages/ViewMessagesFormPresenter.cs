using System;

namespace User.Feedback.Client.Views.ViewMessages
{
    public class ViewMessagesFormPresenter
    {
        public IViewMessagesForm View { get; }

        public ViewMessagesFormPresenter(IViewMessagesForm view)
        {
            View = view;

            View.MessagesRequested += OnMessagesRequested;
        }

        private void OnMessagesRequested(object sender, EventArgs e)
        {
            //UserFeedbackManager.AskUserFeedbackCollection().ContinueWith(task =>
            //{
            //    View.UserFeedbacks = task.Result.UserFeedbackCollection;
            //});
        }
    }
}