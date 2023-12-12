using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Input;

namespace TreinamentoWPF.ViewModels
{
    public partial class ViewModelBase : ObservableObject
    {
        [RelayCommand]
        private void Next(object parameter)
        {
            TraversalRequest request = new(FocusNavigationDirection.Next);
            if (Keyboard.FocusedElement is UIElement element)
            {
                element.MoveFocus(request);

            }
        }
    }
}
