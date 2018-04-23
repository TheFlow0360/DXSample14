using System;
using System.Windows;
using System.Windows.Media;
using DevExpress.Xpf.Core;

namespace DXSample14
{
    public class DXWindowEx : DXWindow
    {
        public DXWindowEx()
        {
            UseLayoutRounding = true;
            BorderEffect = BorderEffect.Default;
            BorderEffectActiveColor = new SolidColorBrush(Colors.Black);
            BorderBrush = ActiveBorderBrush;
            BorderThickness = new Thickness(0, 1, 0, 0);
        }

        private SolidColorBrush ActiveBorderBrush { get; } = new SolidColorBrush(Colors.Black);

        private SolidColorBrush InactiveBorderBrush { get; } = new SolidColorBrush(Color.FromRgb(0x99, 0x99, 0x99));

        protected override void OnIsActiveChanged(Boolean newValue)
        {
            base.OnIsActiveChanged(newValue);
            BorderBrush = newValue ? ActiveBorderBrush : InactiveBorderBrush;
        }
    }
}