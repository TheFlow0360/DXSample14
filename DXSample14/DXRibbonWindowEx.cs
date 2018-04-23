using System.Windows.Media;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Ribbon;

namespace DXSample14
{
    public class DXRibbonWindowEx : DXRibbonWindow
    {
        public DXRibbonWindowEx()
        {
            UseLayoutRounding = true;
            BorderEffect = BorderEffect.Default;
            BorderEffectActiveColor = new SolidColorBrush(Colors.Black);
        }
    }
}