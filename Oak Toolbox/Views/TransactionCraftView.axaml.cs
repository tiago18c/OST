using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace OSTApp.Views
{
    public partial class TransactionCraftView : UserControl
    {
        public TransactionCraftView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
