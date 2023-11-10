#   How to bind ComboBoxAdv in MVVM
This section explains how to bind ComboBoxAdv in MVVM.

# Creating project
Below section provides detailed information to create new project in Visual Studio to display ComboBoxAdv.
# Adding control manually in XAML
In order to add ComboBoxAdv control manually in XAML, do the below steps,

1. Add the below required assembly references to the project,

   * Syncfusion.Shared.WPF
2. Import Syncfusion WPF schema http://schemas.syncfusion.com/wpf in XAML page or Syncfusion.Windows.Tools.Controls namespace.

3. Declare ComboBoxAdv in XAML page.
**[XAML]**

```
 <Grid>
      <syncfusion:ComboBoxAdv Height="30" Width="150"/>
 </Grid>
```

# Adding control manually in C#
In order to add ComboBoxAdv control manually in C#, do the below steps,

1. Add the below required assembly references to the project,

    * Syncfusion.Shared.WPF
2. Import ComboBoxAdv namespace Syncfusion.Windows.Tools.Controls.

3. Create ComboBoxAdv control instance and add it to the page.


**[C#]**
```
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ComboBoxAdv comboBoxAdv = new ComboBoxAdv();
        this.Content = comboBoxAdv;
        comboBoxAdv.Height = 30;
        comboBoxAdv.Width = 150;
        comboBoxAdv.DefaultText = "choose Items";
    }
}
```
#   Bind ComboBoxAdv in MVVM
**[XAML]**

```
<syncfusion:ComboBoxAdv VerticalAlignment="Center" 
                        ItemsSource="{Binding ModelItems}" 
                        DisplayMemberPath="Text" 
                        SelectedItem="{Binding SelectedModel,Mode=TwoWay,UpdateSourceTrigger=PropertyChanged}" 
                        HorizontalAlignment="Center" 
                        Width="126">
            
</syncfusion:ComboBoxAdv>
````

**ViewModel**

**[C#]**
```

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
```
## How to run this application?
To run this application, you need to first clone the How-to-bind-ComboBoxAdv-in-MVVM- and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.
## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
## License
Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.