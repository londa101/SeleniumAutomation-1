﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Automation.Mobile.Common {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class MobileSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static MobileSettings defaultInstance = ((MobileSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new MobileSettings())));
        
        public static MobileSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\AbhishekSur\\Documents\\APIReports")]
        public string FolderUrl {
            get {
                return ((string)(this["FolderUrl"]));
            }
            set {
                this["FolderUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\AbhishekSur\\Documents\\Ideas\\DataFiles\\MTestCases.xlsx")]
        public string DataFile {
            get {
                return ((string)(this["DataFile"]));
            }
            set {
                this["DataFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Automation.www")]
        public string PackageName {
            get {
                return ((string)(this["PackageName"]));
            }
            set {
                this["PackageName"] = value;
            }
        }
    }
}
