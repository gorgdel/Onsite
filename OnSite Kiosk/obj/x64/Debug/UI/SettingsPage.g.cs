﻿#pragma checksum "C:\Users\pprice\source\repos\OnSite Kiosk\OnSite Kiosk\UI\SettingsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E93085ABEC7A4D46D9AB5FD162FDA090"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnSite_Kiosk.UI
{
    partial class SettingsPage : 
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
            case 1: // UI\SettingsPage.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                }
                break;
            case 2: // UI\SettingsPage.xaml line 12
                {
                    this.lbl_SiteID = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // UI\SettingsPage.xaml line 13
                {
                    this.txt_SiteID = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // UI\SettingsPage.xaml line 15
                {
                    this.lbl_APIBase = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // UI\SettingsPage.xaml line 16
                {
                    this.txt_APIBase = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // UI\SettingsPage.xaml line 18
                {
                    this.lbl_EndOfDay = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // UI\SettingsPage.xaml line 19
                {
                    this.txt_EndOfDay = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // UI\SettingsPage.xaml line 21
                {
                    this.lbl_enabled_modules = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // UI\SettingsPage.xaml line 22
                {
                    this.sw_mod_student = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                }
                break;
            case 10: // UI\SettingsPage.xaml line 23
                {
                    this.sw_mod_staff = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                }
                break;
            case 11: // UI\SettingsPage.xaml line 24
                {
                    this.sw_mod_visitor = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                }
                break;
            case 12: // UI\SettingsPage.xaml line 26
                {
                    global::Windows.UI.Xaml.Controls.Button element12 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element12).Click += this.Button_Click;
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

