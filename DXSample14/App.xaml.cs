using System.Windows;
using DevExpress.Xpf.Core;

namespace DXSample14
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var theme = new Theme("SelectLineCrmClassic", "SelectLine Crm Classic", "SelectLine Themes")
            {
                AssemblyName = "DevExpress.Xpf.Themes.SelectLineCrmClassic.v18.1"
            };
            Theme.RegisterTheme(theme);
            ApplicationThemeHelper.ApplicationThemeName = theme.Name;
        }
    }
}
