using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using AvaloniaGUI.Models;
using ReactiveUI;

namespace AvaloniaGUI.ViewModels
{
    public class AddPageViewModel : ReactiveObject
    {
        // Create instance of the Card class in here. Use RaiseAndSetIfChanged to detect change and bind to the views.
        private Card _card;

        public Card Card
        {
            get => _card;
            set => this.RaiseAndSetIfChanged(ref _card, value);
        }

        public AddPageViewModel()
        {
            Card = new Card();
        }
    }
}
