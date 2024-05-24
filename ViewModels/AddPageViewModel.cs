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
        private Card _card;
        private string _validationErrorMsg;
        public ReactiveCommand<Unit, Unit> AddCardCommand { get; }

        public AddPageViewModel()
        {
            Card = new Card();
            AddCardCommand = ReactiveCommand.Create(AddCard);
            ValidationErrorMsg = string.Empty;
        }

        public Card Card
        {
            get => _card;
            set => this.RaiseAndSetIfChanged(ref _card, value);
        }

        public string ValidationErrorMsg
        {
            get => _validationErrorMsg;
            set => this.RaiseAndSetIfChanged(ref _validationErrorMsg, value);
        }

        public void AddCard()
        {
            try
            {
                // Add the card to the database
                // Clear the textboxes
                ValidationErrorMsg = string.Empty;
            }
            catch (Exception ex)
            {
                ValidationErrorMsg = ex.Message;
            }
        }

        public void ValidateCard()
        {
            try
            {
                // Validate the card
                ValidationErrorMsg = string.Empty;
            }
            catch (Exception ex)
            {
                ValidationErrorMsg = ex.Message;
            }
        }
    }
}
