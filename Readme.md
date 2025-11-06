#  How to Bind WPF ComboBoxAdv in MVVM
This guide explains how to bind the ComboBoxAdv control in an MVVM architecture using Syncfusion WPF components.

## Creating the Project
To get started:
- Create a new WPF project in Visual Studio.
- Add the required Syncfusion assembly reference: Syncfusion.Shared.WPF

### Adding ComboBoxAdv in XAML
To manually add the control in XAML:
1. Import the Syncfusion WPF schema:
```XAML
xmlns:syncfusion="http://schemas.syncfusion.com/wpf"
```
2. Declare the control:
```XAML
<Grid>
    <syncfusion:ComboBoxAdv Height="30" Width="150"/>
</Grid>
```

### Adding ComboBoxAdv in C#
To add the control programmatically:
```C#
using Syncfusion.Windows.Tools.Controls;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ComboBoxAdv comboBoxAdv = new ComboBoxAdv
        {
            Height = 30,
            Width = 150,
            DefaultText = "Choose Items"
        };
        this.Content = comboBoxAdv;
    }
}
```

### Binding ComboBoxAdv in MVVM
**[XAML]**
```XAML
<syncfusion:ComboBoxAdv
    VerticalAlignment="Center"
    ItemsSource="{Binding ModelItems}" 
    DisplayMemberPath="Text" 
    SelectedItem="{Binding SelectedModel, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}" 
    HorizontalAlignment="Center" 
    Width="126"/>
````

**ViewModel**
```C#
public class ViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Model> ModelItems { get; set; }

    private Model selectedModel;
    public Model SelectedModel
    {
        get => selectedModel;
        set
        {
            selectedModel = value;
            OnPropertyChanged(nameof(SelectedModel));
        }
    }

    public ViewModel()
    {
        ModelItems = new ObservableCollection<Model>
        {
            new Model { Text = "Item1" },
            new Model { Text = "Item2" },
            new Model { Text = "Item3" }
        };
        SelectedModel = ModelItems[0];
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
```
## Running the Application
- Clone the repository.
- Open the solution in Visual Studio 2022.
- Build and run the project to see the ComboBoxAdv in action.

## Troubleshooting
### Path Too Long Exception
If you encounter a "path too long" error during build:
- Close Visual Studio.
- Rename the repository folder to a shorter name.
- Reopen and build the project.
