using System;
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

        private void LegacyRibbonOpen_OnItemClick(Object sender, ItemClickEventArgs e)
        {
            var window = new LegacyRibbonWindow();
            window.Show();
        }

        private void LegacyModalOpen_OnItemClick(Object sender, ItemClickEventArgs e)
        {
            var window = new LegacyWindow();
            window.ShowDialog();
        }
    }
}
