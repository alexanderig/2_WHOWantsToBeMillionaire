using System;

namespace Millionare
{
    public class AdminEditPresenter
    {
        private readonly MainModel _model;
        private readonly AdminForm _view;
        public AdminEditPresenter(AdminForm view, MainModel model)
        {
            _model = model;            
            _view = view;
            _view.UpdateData += new EventHandler<EventArgs>(OnChange);
            _view.AddData += new EventHandler<EventArgs>(OnAdd);
            _view.DeleteData += new EventHandler<EventArgs>(OnDelete);
            OnStart();
        }

        private void OnChange(object sender, EventArgs e)
        {

            _model.ModelUpdate(_view.TextFieldsData, MainModel.Action.Update, _view.Index);
           
            UpdateView(MainModel.Action.Update);
        }

        private void OnAdd(object sender, EventArgs e)
        {
            _model.ModelUpdate(_view.TextFieldsData, MainModel.Action.Add, _view.Index);
            UpdateView(MainModel.Action.Update);
        }

        private void OnDelete(object sender, EventArgs e)
        {
            _model.ModelUpdate(_view.TextFieldsData, MainModel.Action.Delete, _view.Index);
            UpdateView(MainModel.Action.Delete);
        }

        private void OnStart()
        {
            foreach(MainModel.Gamedata item in _model.GetListgamedata())
            {
                _view.Group = int.Parse(item.GroupList);
                _view.TextFieldsData = new string[] { item.Question, item.VarA, item.VarB, item.VarC, item.VarD, item.Uniqindex.ToString()};
                UpdateView(MainModel.Action.Add);
            }
        }
        private void UpdateView(MainModel.Action action)
        {
            switch(action)
            {
                case MainModel.Action.Add:
                    _view.OnAddUpdate();
                    break;
                case MainModel.Action.Delete:
                    _view.OnDeleteUpdate();
                    OnStart();
                    break;
                case MainModel.Action.Update:
                    _view.OnEditUpdate();
                    OnStart();
                    break;
            }
        }
    }
}
