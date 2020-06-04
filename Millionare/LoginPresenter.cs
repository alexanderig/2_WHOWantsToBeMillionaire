using System;

namespace Millionare
{
    public class LoginPresenter
    {
        private readonly MainModel _model;
        private readonly ILoginView _view;

        public LoginPresenter(ILoginView view, MainModel model)
        {
            _model = model;
            _view = view;
            _view.Login += new EventHandler<EventArgs>(OnLogin);
        }

        private void OnLogin(object sender, EventArgs e)
        {
            _model.UserName = _view.UserName;
            _model.Password = _view.Password;
            if (_model.IsLoginCorrect())
                _view.LetUserLogin();
            else
                _view.DontLetUserLogin();
        }
    }
}
