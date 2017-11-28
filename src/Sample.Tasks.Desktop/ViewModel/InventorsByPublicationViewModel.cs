using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Sample.Tasks.Desktop.Annotations;
using Sample.Tasks.Desktop.Infrastructure;
using Sample.Tasks.Desktop.Messages;

namespace Sample.Tasks.Desktop.ViewModel
{
    public sealed class InventorsByPublicationViewModel : INotifyPropertyChanged
    {
        private readonly IMessageBus bus;

        public InventorsByPublicationViewModel(IMessageBus bus)
        {
            this.bus = bus;
        }

        private string publicationNumber;
        private InventorsViewModel inventors;        

        public string PublicationNumber
        {
            get { return publicationNumber; }
            set
            {
                if (value == publicationNumber) return;
                publicationNumber = value;
                OnPropertyChanged();
            }
        }

        public InventorsViewModel Inventors
        {
            get { return inventors; }
            private set
            {
                if (Equals(value, inventors)) return;
                inventors = value;
                OnPropertyChanged();
            }
        }

        public void WhenFetchInventor()
        {
            bus.Publish(new GetInventorsByPublication(new CallMeEnvelope(), PublicationNumber));
        }

        public ICommand FetchInventor { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}