﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace OnSite_Kiosk
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        private global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlMetaDataProvider __appProvider;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlMetaDataProvider _AppProvider
        {
            get
            {
                if (__appProvider == null)
                {
                    __appProvider = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlMetaDataProvider();
                }
                return __appProvider;
            }
        }

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            return _AppProvider.GetXamlType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            return _AppProvider.GetXamlType(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return _AppProvider.GetXmlnsDefinitions();
        }
    }
}

namespace OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo
{
    /// <summary>
    /// Main class for providing metadata for the app or library
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class XamlMetaDataProvider : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlTypeInfoProvider _provider = null;

        private global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlTypeInfoProvider Provider
        {
            get
            {
                if (_provider == null)
                {
                    _provider = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlTypeInfoProvider();
                }
                return _provider;
            }
        }

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            return Provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            return Provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            lock (_xamlTypeCacheByType) 
            { 
                if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
                {
                    return xamlType;
                }
                int typeIndex = LookupTypeIndexByType(type);
                if(typeIndex != -1)
                {
                    xamlType = CreateXamlType(typeIndex);
                }
                if (xamlType != null)
                {
                    _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                    _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
                }
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            lock (_xamlTypeCacheByType)
            {
                if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
                {
                    return xamlType;
                }
                int typeIndex = LookupTypeIndexByName(typeName);
                if(typeIndex != -1)
                {
                    xamlType = CreateXamlType(typeIndex);
                }
                if (xamlType != null)
                {
                    _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                    _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
                }
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            lock (_xamlMembers)
            {
                if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
                {
                    return xamlMember;
                }
                xamlMember = CreateXamlMember(longMemberName);
                if (xamlMember != null)
                {
                    _xamlMembers.Add(longMemberName, xamlMember);
                }
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[15];
            _typeNameTable[0] = "OnSite_Kiosk.UI.Home";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "String";
            _typeNameTable[4] = "OnSite_Kiosk.UI.MainPage";
            _typeNameTable[5] = "OnSite_Kiosk.UI.SettingsPage";
            _typeNameTable[6] = "OnSite_Kiosk.UI.SignInOutComplete";
            _typeNameTable[7] = "OnSite_Kiosk.UI.Staff.Staff_Select";
            _typeNameTable[8] = "OnSite_Kiosk.UI.Staff.Staff_SignOut";
            _typeNameTable[9] = "OnSite_Kiosk.UI.Staff.Staff_SignOutOther";
            _typeNameTable[10] = "Windows.UI.Xaml.Controls.ContentDialog";
            _typeNameTable[11] = "Windows.UI.Xaml.Controls.ContentControl";
            _typeNameTable[12] = "OnSite_Kiosk.UI.Student.Student_Select";
            _typeNameTable[13] = "OnSite_Kiosk.UI.Visitor.Visitor_SelectInOut";
            _typeNameTable[14] = "OnSite_Kiosk.UI.Visitor.Visitor_SignIn";

            _typeTable = new global::System.Type[15];
            _typeTable[0] = typeof(global::OnSite_Kiosk.UI.Home);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::System.String);
            _typeTable[4] = typeof(global::OnSite_Kiosk.UI.MainPage);
            _typeTable[5] = typeof(global::OnSite_Kiosk.UI.SettingsPage);
            _typeTable[6] = typeof(global::OnSite_Kiosk.UI.SignInOutComplete);
            _typeTable[7] = typeof(global::OnSite_Kiosk.UI.Staff.Staff_Select);
            _typeTable[8] = typeof(global::OnSite_Kiosk.UI.Staff.Staff_SignOut);
            _typeTable[9] = typeof(global::OnSite_Kiosk.UI.Staff.Staff_SignOutOther);
            _typeTable[10] = typeof(global::Windows.UI.Xaml.Controls.ContentDialog);
            _typeTable[11] = typeof(global::Windows.UI.Xaml.Controls.ContentControl);
            _typeTable[12] = typeof(global::OnSite_Kiosk.UI.Student.Student_Select);
            _typeTable[13] = typeof(global::OnSite_Kiosk.UI.Visitor.Visitor_SelectInOut);
            _typeTable[14] = typeof(global::OnSite_Kiosk.UI.Visitor.Visitor_SignIn);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_Home() { return new global::OnSite_Kiosk.UI.Home(); }
        private object Activate_4_MainPage() { return new global::OnSite_Kiosk.UI.MainPage(); }
        private object Activate_5_SettingsPage() { return new global::OnSite_Kiosk.UI.SettingsPage(); }
        private object Activate_6_SignInOutComplete() { return new global::OnSite_Kiosk.UI.SignInOutComplete(); }
        private object Activate_7_Staff_Select() { return new global::OnSite_Kiosk.UI.Staff.Staff_Select(); }
        private object Activate_8_Staff_SignOut() { return new global::OnSite_Kiosk.UI.Staff.Staff_SignOut(); }
        private object Activate_9_Staff_SignOutOther() { return new global::OnSite_Kiosk.UI.Staff.Staff_SignOutOther(); }
        private object Activate_12_Student_Select() { return new global::OnSite_Kiosk.UI.Student.Student_Select(); }
        private object Activate_13_Visitor_SelectInOut() { return new global::OnSite_Kiosk.UI.Visitor.Visitor_SelectInOut(); }
        private object Activate_14_Visitor_SignIn() { return new global::OnSite_Kiosk.UI.Visitor.Visitor_SignIn(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  OnSite_Kiosk.UI.Home
                userType = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_Home;
                userType.AddMemberName("PageTitle");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  String
                xamlType = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 4:   //  OnSite_Kiosk.UI.MainPage
                userType = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_4_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  OnSite_Kiosk.UI.SettingsPage
                userType = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_5_SettingsPage;
                userType.AddMemberName("PageTitle");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 6:   //  OnSite_Kiosk.UI.SignInOutComplete
                userType = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_6_SignInOutComplete;
                userType.AddMemberName("PageTitle");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 7:   //  OnSite_Kiosk.UI.Staff.Staff_Select
                userType = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_Staff_Select;
                userType.AddMemberName("PageTitle");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  OnSite_Kiosk.UI.Staff.Staff_SignOut
                userType = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_Staff_SignOut;
                userType.AddMemberName("PageTitle");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  OnSite_Kiosk.UI.Staff.Staff_SignOutOther
                userType = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.ContentDialog"));
                userType.Activator = Activate_9_Staff_SignOutOther;
                userType.AddMemberName("Reason");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 10:   //  Windows.UI.Xaml.Controls.ContentDialog
                xamlType = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 11:   //  Windows.UI.Xaml.Controls.ContentControl
                xamlType = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 12:   //  OnSite_Kiosk.UI.Student.Student_Select
                userType = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_Student_Select;
                userType.AddMemberName("PageTitle");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  OnSite_Kiosk.UI.Visitor.Visitor_SelectInOut
                userType = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_Visitor_SelectInOut;
                userType.AddMemberName("PageTitle");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 14:   //  OnSite_Kiosk.UI.Visitor.Visitor_SignIn
                userType = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_14_Visitor_SignIn;
                userType.AddMemberName("PageTitle");
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_Home_PageTitle(object instance)
        {
            var that = (global::OnSite_Kiosk.UI.Home)instance;
            return that.PageTitle;
        }
        private object get_1_SettingsPage_PageTitle(object instance)
        {
            var that = (global::OnSite_Kiosk.UI.SettingsPage)instance;
            return that.PageTitle;
        }
        private object get_2_SignInOutComplete_PageTitle(object instance)
        {
            var that = (global::OnSite_Kiosk.UI.SignInOutComplete)instance;
            return that.PageTitle;
        }
        private object get_3_Staff_Select_PageTitle(object instance)
        {
            var that = (global::OnSite_Kiosk.UI.Staff.Staff_Select)instance;
            return that.PageTitle;
        }
        private object get_4_Staff_SignOut_PageTitle(object instance)
        {
            var that = (global::OnSite_Kiosk.UI.Staff.Staff_SignOut)instance;
            return that.PageTitle;
        }
        private object get_5_Staff_SignOutOther_Reason(object instance)
        {
            var that = (global::OnSite_Kiosk.UI.Staff.Staff_SignOutOther)instance;
            return that.Reason;
        }
        private object get_6_Student_Select_PageTitle(object instance)
        {
            var that = (global::OnSite_Kiosk.UI.Student.Student_Select)instance;
            return that.PageTitle;
        }
        private object get_7_Visitor_SelectInOut_PageTitle(object instance)
        {
            var that = (global::OnSite_Kiosk.UI.Visitor.Visitor_SelectInOut)instance;
            return that.PageTitle;
        }
        private object get_8_Visitor_SignIn_PageTitle(object instance)
        {
            var that = (global::OnSite_Kiosk.UI.Visitor.Visitor_SignIn)instance;
            return that.PageTitle;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlMember xamlMember = null;
            global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "OnSite_Kiosk.UI.Home.PageTitle":
                userType = (global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OnSite_Kiosk.UI.Home");
                xamlMember = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlMember(this, "PageTitle", "String");
                xamlMember.Getter = get_0_Home_PageTitle;
                xamlMember.SetIsReadOnly();
                break;
            case "OnSite_Kiosk.UI.SettingsPage.PageTitle":
                userType = (global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OnSite_Kiosk.UI.SettingsPage");
                xamlMember = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlMember(this, "PageTitle", "String");
                xamlMember.Getter = get_1_SettingsPage_PageTitle;
                xamlMember.SetIsReadOnly();
                break;
            case "OnSite_Kiosk.UI.SignInOutComplete.PageTitle":
                userType = (global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OnSite_Kiosk.UI.SignInOutComplete");
                xamlMember = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlMember(this, "PageTitle", "String");
                xamlMember.Getter = get_2_SignInOutComplete_PageTitle;
                xamlMember.SetIsReadOnly();
                break;
            case "OnSite_Kiosk.UI.Staff.Staff_Select.PageTitle":
                userType = (global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OnSite_Kiosk.UI.Staff.Staff_Select");
                xamlMember = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlMember(this, "PageTitle", "String");
                xamlMember.Getter = get_3_Staff_Select_PageTitle;
                xamlMember.SetIsReadOnly();
                break;
            case "OnSite_Kiosk.UI.Staff.Staff_SignOut.PageTitle":
                userType = (global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OnSite_Kiosk.UI.Staff.Staff_SignOut");
                xamlMember = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlMember(this, "PageTitle", "String");
                xamlMember.Getter = get_4_Staff_SignOut_PageTitle;
                xamlMember.SetIsReadOnly();
                break;
            case "OnSite_Kiosk.UI.Staff.Staff_SignOutOther.Reason":
                userType = (global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OnSite_Kiosk.UI.Staff.Staff_SignOutOther");
                xamlMember = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlMember(this, "Reason", "String");
                xamlMember.Getter = get_5_Staff_SignOutOther_Reason;
                xamlMember.SetIsReadOnly();
                break;
            case "OnSite_Kiosk.UI.Student.Student_Select.PageTitle":
                userType = (global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OnSite_Kiosk.UI.Student.Student_Select");
                xamlMember = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlMember(this, "PageTitle", "String");
                xamlMember.Getter = get_6_Student_Select_PageTitle;
                xamlMember.SetIsReadOnly();
                break;
            case "OnSite_Kiosk.UI.Visitor.Visitor_SelectInOut.PageTitle":
                userType = (global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OnSite_Kiosk.UI.Visitor.Visitor_SelectInOut");
                xamlMember = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlMember(this, "PageTitle", "String");
                xamlMember.Getter = get_7_Visitor_SelectInOut_PageTitle;
                xamlMember.SetIsReadOnly();
                break;
            case "OnSite_Kiosk.UI.Visitor.Visitor_SignIn.PageTitle":
                userType = (global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OnSite_Kiosk.UI.Visitor.Visitor_SignIn");
                xamlMember = new global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlMember(this, "PageTitle", "String");
                xamlMember.Getter = get_8_Visitor_SignIn_PageTitle;
                xamlMember.SetIsReadOnly();
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);
    internal delegate object CreateFromStringMethod(string args);
    internal delegate object BoxInstanceMethod(object instance);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlSystemBaseType
        , global::Windows.UI.Xaml.Markup.IXamlType2
    {
        global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;
        global::Windows.UI.Xaml.Markup.IXamlType _boxedType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }
        public global::Windows.UI.Xaml.Markup.IXamlType BoxedType { get { return _boxedType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            global::System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (BoxedType != null)
            {
                return BoxInstance(BoxedType.CreateFromString(input));
            }

            if (CreateFromStringMethod != null)
            {
                return this.CreateFromStringMethod(input);
            }
            else if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }
        public CreateFromStringMethod CreateFromStringMethod {get; set; }
        public BoxInstanceMethod BoxInstance {get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void SetBoxedType(global::Windows.UI.Xaml.Markup.IXamlType boxedType)
        {
            _boxedType = boxedType;
        }

        public object BoxType<T>(object instance) where T: struct
        {
            T unwrapped = (T)instance;
            return new global::System.Nullable<T>(unwrapped);
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::OnSite_Kiosk.OnSite_Kiosk_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}
