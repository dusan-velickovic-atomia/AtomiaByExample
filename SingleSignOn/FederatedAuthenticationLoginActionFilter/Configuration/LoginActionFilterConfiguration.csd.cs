//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Atomia.Custom.FederatedAuthenticationLoginActionFilter.Configuration
{
    
    
    /// <summary>
    /// The LoginActionFilterConfiguration Configuration Section.
    /// </summary>
    public partial class LoginActionFilterConfiguration : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the LoginActionFilterConfiguration Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string LoginActionFilterConfigurationSectionName = "loginActionFilterConfiguration";
        
        /// <summary>
        /// Gets the LoginActionFilterConfiguration instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public static global::Atomia.Custom.FederatedAuthenticationLoginActionFilter.Configuration.LoginActionFilterConfiguration Instance
        {
            get
            {
                return ((global::Atomia.Custom.FederatedAuthenticationLoginActionFilter.Configuration.LoginActionFilterConfiguration)(global::System.Configuration.ConfigurationManager.GetSection(global::Atomia.Custom.FederatedAuthenticationLoginActionFilter.Configuration.LoginActionFilterConfiguration.LoginActionFilterConfigurationSectionName)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Atomia.Custom.FederatedAuthenticationLoginActionFilter.Configuration.LoginActionFilterConfiguration.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::Atomia.Custom.FederatedAuthenticationLoginActionFilter.Configuration.LoginActionFilterConfiguration.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Host Property
        /// <summary>
        /// The XML name of the <see cref="Host"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string HostPropertyName = "host";
        
        /// <summary>
        /// Gets or sets the Host.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Host.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Atomia.Custom.FederatedAuthenticationLoginActionFilter.Configuration.LoginActionFilterConfiguration.HostPropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string Host
        {
            get
            {
                return ((string)(base[global::Atomia.Custom.FederatedAuthenticationLoginActionFilter.Configuration.LoginActionFilterConfiguration.HostPropertyName]));
            }
            set
            {
                base[global::Atomia.Custom.FederatedAuthenticationLoginActionFilter.Configuration.LoginActionFilterConfiguration.HostPropertyName] = value;
            }
        }
        #endregion
        
        #region Url Property
        /// <summary>
        /// The XML name of the <see cref="Url"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string UrlPropertyName = "url";
        
        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Url.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Atomia.Custom.FederatedAuthenticationLoginActionFilter.Configuration.LoginActionFilterConfiguration.UrlPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string Url
        {
            get
            {
                return ((string)(base[global::Atomia.Custom.FederatedAuthenticationLoginActionFilter.Configuration.LoginActionFilterConfiguration.UrlPropertyName]));
            }
            set
            {
                base[global::Atomia.Custom.FederatedAuthenticationLoginActionFilter.Configuration.LoginActionFilterConfiguration.UrlPropertyName] = value;
            }
        }
        #endregion
        
        #region Realm Property
        /// <summary>
        /// The XML name of the <see cref="Realm"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string RealmPropertyName = "realm";
        
        /// <summary>
        /// Gets or sets the Realm.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Realm.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Atomia.Custom.FederatedAuthenticationLoginActionFilter.Configuration.LoginActionFilterConfiguration.RealmPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string Realm
        {
            get
            {
                return ((string)(base[global::Atomia.Custom.FederatedAuthenticationLoginActionFilter.Configuration.LoginActionFilterConfiguration.RealmPropertyName]));
            }
            set
            {
                base[global::Atomia.Custom.FederatedAuthenticationLoginActionFilter.Configuration.LoginActionFilterConfiguration.RealmPropertyName] = value;
            }
        }
        #endregion
    }
}