﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disney.iDash.SRR.BusinessLayer.Spice.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=C:\\Projects\\iDash\\DataLayer\\Local.sdf")]
        public string LocalConnectionString {
            get {
                return ((string)(this["LocalConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute(@"Provider=IBMDA400.DataSource.1;Data Source=TDST.TDS.DISNEY.COM;Persist Security Info=True;Password=ch1cken;User ID=MLEVINE;Initial Catalog=TDST;Convert Date Time To Char=false;Library List=QTEMP,TDSFILDSS2,TDSFILUKS,TDSHSTUKS,TDSDB2DSS,IPTSFILUKS,IPSAFILUKS,IPASFILUKS,IPWMFILUKS,IPTSITGUKY,IPTSITGEUY,IPTSITGDSY,IPTSQUAUKY,IPTSQUAEUY,IPTSQUADSY,IPTSMODUKY,IPTSMODEUY,IPTSMODDSY,IPTSPCH,IPTSPGM,IPTSUTL,IPSAPGM,DISCMDLIS,DISCMDLIY,TDSWWFILY;Naming Convention=1")]
        public string ConnectionString {
            get {
                return ((string)(this["ConnectionString"]));
            }
        }
    }
}
