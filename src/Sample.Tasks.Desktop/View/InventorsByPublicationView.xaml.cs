using System;
using System.ComponentModel;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using Sample.Tasks.Desktop.Infrastructure;
using Sample.Tasks.Desktop.ViewModel;

namespace Sample.Tasks.Desktop.View
{    
    public sealed partial class InventorsByPublicationView
    {
        public InventorsByPublicationView(MessageBus bus)
        {
            InitializeComponent();                       

            ViewModel = new InventorsByPublicationViewModel(bus);
        }

        public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
            "ViewModel", typeof (InventorsByPublicationViewModel), typeof (InventorsByPublicationView), new PropertyMetadata(default(InventorsByPublicationViewModel),  ViewModelSet));

        private static void ViewModelSet(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            var view = (InventorsByPublicationView)dependencyObject;
            var wm = (InventorsByPublicationViewModel)dependencyPropertyChangedEventArgs.NewValue;

            view.FetchInventor.Command = wm.FetchInventor;

            Observable.FromEventPattern<TextChangedEventHandler, TextChangedEventArgs>(
                h => view.PublicationNumber.TextChanged += h,
                h => view.PublicationNumber.TextChanged -= h
                ).Subscribe(x =>
                {
                    wm.PublicationNumber = ((TextBox) x.Sender).Text;
                });

            Observable.FromEventPattern<PropertyChangedEventHandler, PropertyChangedEventArgs>(
                h => wm.PropertyChanged += h,
                h => wm.PropertyChanged -= h)
                .Where(x => x.EventArgs.PropertyName == "Inventors")
                .Subscribe(x =>
                {
                    view.Inventor.Content = wm.Inventors;
                });
        }

        public InventorsByPublicationViewModel ViewModel
        {
            get { return (InventorsByPublicationViewModel) GetValue(ViewModelProperty); }
            private set { SetValue(ViewModelProperty, value); }
        }
    }
}
