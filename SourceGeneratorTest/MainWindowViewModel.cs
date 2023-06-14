using CommunityToolkit.Mvvm.ComponentModel;
using System.Diagnostics;

namespace SourceGeneratorTest;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(TestCommand))]
    private int _TestInt;

    [CommunityToolkit.Mvvm.Input.RelayCommand]
    private void Test()
    {
        Debug.WriteLine("Hello World!");
    }
}
