using Correcao.Views;
using Correcao.Models;
using Correcao.ViewModels;

namespace Correcao.Views;

public partial class DiceView : ContentPage
{
    public DiceView()
    {
        InitializeComponent();
        BindingContext = new DiceViewModel();
    }
}