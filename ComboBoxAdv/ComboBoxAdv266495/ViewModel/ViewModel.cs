using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ComboBoxAdv266495
{
    public class ViewModel : INotifyPropertyChanged
    {
        #region ICommand
        private ICommand _clickCommand;
        public ICommand ClickCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new CommandHandler(() => MyAction(), () => CanExecute));
            }
        }
        public bool CanExecute
        {
            get
            {
                return true;
            }
        }
        #endregion
        public void MyAction()
        {
            SelectedModel = ModelItems[2];
        }

        private ObservableCollection<Model> modelItems;

        public ObservableCollection<Model> ModelItems
        {
            get { return modelItems; }
            set
            {
                modelItems = value;
            }
        }

        private Model selectedModel;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null) { }
        }

        public Model SelectedModel
        {
            get { return selectedModel; }
            set { selectedModel = value; OnPropertyRaised("SelectedModel"); }
        }

        public ViewModel()
        {
            ModelItems = new ObservableCollection<Model>();
            SelectedModel = new Model();
            Model model1 = new Model() { Text = "Item1" };
            Model model2 = new Model() { Text = "Item2" };
            Model model3 = new Model() { Text = "Item3" };

            ModelItems.Add(model1);
            ModelItems.Add(model2);
            ModelItems.Add(model3);
        }

    }

   


}
