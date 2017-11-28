using System.Windows;
using Sample.Tasks.Desktop.Infrastructure;

namespace Sample.Tasks.Desktop.View
{
    public sealed partial class App
    {        
        protected override void OnStartup(StartupEventArgs e)
        {            
            base.OnStartup(e);
        
            var bus = new MessageBus();
            var view = new InventorsByPublicationView(bus);
            view.Show();
        }
    }
}
