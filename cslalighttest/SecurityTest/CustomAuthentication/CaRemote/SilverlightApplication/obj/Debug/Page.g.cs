#pragma checksum "C:\Projects\CSLALight\cslalighttest\SecurityTest\CustomAuthentication\CaRemote\SilverlightApplication\Page.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "95CE25CC32FBC4B58A3BB644478301CC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3031
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Hosting;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SilverlightApplication {
    
    
    public partial class Page : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button btnRemoteSuccessfulLogin;
        
        internal System.Windows.Controls.Button btnRemoteUnsuccessfulLogin;
        
        internal System.Windows.Controls.Button btnRemoteRoles;
        
        internal System.Windows.Controls.TextBlock txtRemoteSuccessfulLogin;
        
        internal System.Windows.Controls.TextBlock txtRemoteUnsuccessfulLogin;
        
        internal System.Windows.Controls.TextBlock txtRemoteRoles;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverlightApplication;component/Page.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.btnRemoteSuccessfulLogin = ((System.Windows.Controls.Button)(this.FindName("btnRemoteSuccessfulLogin")));
            this.btnRemoteUnsuccessfulLogin = ((System.Windows.Controls.Button)(this.FindName("btnRemoteUnsuccessfulLogin")));
            this.btnRemoteRoles = ((System.Windows.Controls.Button)(this.FindName("btnRemoteRoles")));
            this.txtRemoteSuccessfulLogin = ((System.Windows.Controls.TextBlock)(this.FindName("txtRemoteSuccessfulLogin")));
            this.txtRemoteUnsuccessfulLogin = ((System.Windows.Controls.TextBlock)(this.FindName("txtRemoteUnsuccessfulLogin")));
            this.txtRemoteRoles = ((System.Windows.Controls.TextBlock)(this.FindName("txtRemoteRoles")));
        }
    }
}