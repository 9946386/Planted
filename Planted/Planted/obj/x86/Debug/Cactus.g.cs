﻿#pragma checksum "C:\Users\user\Documents\Code\Planted\Planted\Planted\Cactus.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1AA7EF4D43171D328CE27A29CEAD070E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Planted
{
    partial class Cactus : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Cactus.xaml line 41
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.Back).Tapped += this.Back_Tapped;
                }
                break;
            case 3: // Cactus.xaml line 46
                {
                    this.topBanner = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // Cactus.xaml line 47
                {
                    this.foliageTitle = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5: // Cactus.xaml line 49
                {
                    this.BunnyEarsBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BunnyEarsBtn).Click += this.BunnyEarsBtn_Click;
                }
                break;
            case 6: // Cactus.xaml line 53
                {
                    this.EuphorbiaBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.EuphorbiaBtn).Click += this.EuphorbiaBtn_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

