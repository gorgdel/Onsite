﻿#pragma checksum "C:\Users\pprice\source\repos\OnSite Kiosk\OnSite Kiosk\UI\Visitor\Visitor_SignIn.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2375BF75253DD8EFB8A7EA8022277582"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnSite_Kiosk.UI.Visitor
{
    partial class Visitor_SignIn : 
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
            case 1: // UI\Visitor\Visitor_SignIn.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                }
                break;
            case 2: // UI\Visitor\Visitor_SignIn.xaml line 109
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.Button_Click;
                }
                break;
            case 3: // UI\Visitor\Visitor_SignIn.xaml line 106
                {
                    this.chk_internet = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 4: // UI\Visitor\Visitor_SignIn.xaml line 100
                {
                    this.txt_search = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txt_search).TextChanged += this.txt_search_TextChanged;
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txt_search).KeyUp += this.txt_search_KeyUp;
                }
                break;
            case 5: // UI\Visitor\Visitor_SignIn.xaml line 101
                {
                    this.lst_results = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.lst_results).Tapped += this.lst_results_Tapped;
                }
                break;
            case 6: // UI\Visitor\Visitor_SignIn.xaml line 82
                {
                    this.lbl_wwvp = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // UI\Visitor\Visitor_SignIn.xaml line 88
                {
                    this.txt_wwvp = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // UI\Visitor\Visitor_SignIn.xaml line 89
                {
                    this.prg_wwvp = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 9: // UI\Visitor\Visitor_SignIn.xaml line 90
                {
                    this.img_wwvp_ok = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                }
                break;
            case 10: // UI\Visitor\Visitor_SignIn.xaml line 91
                {
                    this.img_wwvp_warn = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
                }
                break;
            case 11: // UI\Visitor\Visitor_SignIn.xaml line 70
                {
                    this.lbl_company = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // UI\Visitor\Visitor_SignIn.xaml line 76
                {
                    this.txt_company = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13: // UI\Visitor\Visitor_SignIn.xaml line 77
                {
                    this.img_company_ok = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                }
                break;
            case 14: // UI\Visitor\Visitor_SignIn.xaml line 78
                {
                    this.img_company_warn = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
                }
                break;
            case 15: // UI\Visitor\Visitor_SignIn.xaml line 58
                {
                    this.lbl_mobile = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // UI\Visitor\Visitor_SignIn.xaml line 64
                {
                    this.txt_mobile = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txt_mobile).LostFocus += this.txt_mobile_LostFocus;
                }
                break;
            case 17: // UI\Visitor\Visitor_SignIn.xaml line 65
                {
                    this.img_mobile_ok = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                }
                break;
            case 18: // UI\Visitor\Visitor_SignIn.xaml line 66
                {
                    this.img_mobile_warn = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
                }
                break;
            case 19: // UI\Visitor\Visitor_SignIn.xaml line 39
                {
                    this.lbl_lastname = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20: // UI\Visitor\Visitor_SignIn.xaml line 45
                {
                    this.txt_lastname = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txt_lastname).LostFocus += this.txt_lastname_LostFocus;
                }
                break;
            case 21: // UI\Visitor\Visitor_SignIn.xaml line 46
                {
                    this.img_lastname_ok = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                }
                break;
            case 22: // UI\Visitor\Visitor_SignIn.xaml line 47
                {
                    this.img_lastname_warn = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
                }
                break;
            case 23: // UI\Visitor\Visitor_SignIn.xaml line 26
                {
                    this.lbl_firstname = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 24: // UI\Visitor\Visitor_SignIn.xaml line 32
                {
                    this.txt_firstname = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 25: // UI\Visitor\Visitor_SignIn.xaml line 33
                {
                    this.img_firstname_ok = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                }
                break;
            case 26: // UI\Visitor\Visitor_SignIn.xaml line 34
                {
                    this.img_firstname_warn = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
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

