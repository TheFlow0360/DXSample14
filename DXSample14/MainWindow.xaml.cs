using DevExpress.Xpf.Bars;

namespace DXSample14
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ModalWindowOpen_OnItemClick(object sender, ItemClickEventArgs e)
        {
            var window = new ModalWindow();
            window.ShowDialog();
        }
    }
}
