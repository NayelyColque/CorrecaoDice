using CommunityToolkit.Mvvm.ComponentModel;
using Correcao.Models;
using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao.ViewModels
{
    public partial class DiceViewModel : ObservableObject
    {
        [ObservableProperty]
        public int _resultado;

        [ObservableProperty]
        public int _numeroSelecionado;

        public ICommand RollCommand { get; }

        public void Roll()
        {
            Dice dice = new Dice(NumeroSelecionado);
            dice.Roll();
            Resultado = dice.NumeroSorteado;
        }

        public DiceViewModel() {
            RollCommand = new Command(Roll);
        }

    }
}

//192.168.2.167