//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpaceTraffic.GithubToTfsSync
{
    
    
    /// <summary>
    /// The MirrorConfiguration Configuration Section.
    /// </summary>
    public partial class MirrorConfiguration : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the MirrorConfiguration Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string MirrorConfigurationSectionName = "mirrorConfiguration";
        
        /// <summary>
        /// The XML path of the MirrorConfiguration Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string MirrorConfigurationSectionPath = "mirrorConfiguration";
        
        /// <summary>
        /// Gets the MirrorConfiguration instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public static global::SpaceTraffic.GithubToTfsSync.MirrorConfiguration Instance
        {
            get
            {
                return ((global::SpaceTraffic.GithubToTfsSync.MirrorConfiguration)(global::System.Configuration.ConfigurationManager.GetSection(global::SpaceTraffic.GithubToTfsSync.MirrorConfiguration.MirrorConfigurationSectionPath)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::SpaceTraffic.GithubToTfsSync.MirrorConfiguration.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::SpaceTraffic.GithubToTfsSync.MirrorConfiguration.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region SourceRepository Property
        /// <summary>
        /// The XML name of the <see cref="SourceRepository"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string SourceRepositoryPropertyName = "sourceRepository";
        
        /// <summary>
        /// Gets or sets the SourceRepository.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The SourceRepository.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::SpaceTraffic.GithubToTfsSync.MirrorConfiguration.SourceRepositoryPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual global::SpaceTraffic.GithubToTfsSync.SourceRepository SourceRepository
        {
            get
            {
                return ((global::SpaceTraffic.GithubToTfsSync.SourceRepository)(base[global::SpaceTraffic.GithubToTfsSync.MirrorConfiguration.SourceRepositoryPropertyName]));
            }
            set
            {
                base[global::SpaceTraffic.GithubToTfsSync.MirrorConfiguration.SourceRepositoryPropertyName] = value;
            }
        }
        #endregion
        
        #region TargetRepositories Property
        /// <summary>
        /// The XML name of the <see cref="TargetRepositories"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string TargetRepositoriesPropertyName = "targetRepositories";
        
        /// <summary>
        /// Gets or sets the TargetRepositories.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The TargetRepositories.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::SpaceTraffic.GithubToTfsSync.MirrorConfiguration.TargetRepositoriesPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual global::SpaceTraffic.GithubToTfsSync.TargetRepositoryCollection TargetRepositories
        {
            get
            {
                return ((global::SpaceTraffic.GithubToTfsSync.TargetRepositoryCollection)(base[global::SpaceTraffic.GithubToTfsSync.MirrorConfiguration.TargetRepositoriesPropertyName]));
            }
            set
            {
                base[global::SpaceTraffic.GithubToTfsSync.MirrorConfiguration.TargetRepositoriesPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace SpaceTraffic.GithubToTfsSync
{
    
    
    /// <summary>
    /// The TargetRepository Configuration Element.
    /// </summary>
    public partial class TargetRepository : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Id Property
        /// <summary>
        /// The XML name of the <see cref="Id"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string IdPropertyName = "id";
        
        /// <summary>
        /// Gets or sets unique identifier of the repository entry.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("Unique identifier of the repository entry.")]
        [global::System.Configuration.RegexStringValidatorAttribute("[A-Za-z0-9_]+")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::SpaceTraffic.GithubToTfsSync.TargetRepository.IdPropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false, DefaultValue="_")]
        public virtual string Id
        {
            get
            {
                return ((string)(base[global::SpaceTraffic.GithubToTfsSync.TargetRepository.IdPropertyName]));
            }
            set
            {
                base[global::SpaceTraffic.GithubToTfsSync.TargetRepository.IdPropertyName] = value;
            }
        }
        #endregion
        
        #region Url Property
        /// <summary>
        /// The XML name of the <see cref="Url"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string UrlPropertyName = "url";
        
        /// <summary>
        /// Gets or sets uRL of the target repository.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("URL of the target repository.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::SpaceTraffic.GithubToTfsSync.TargetRepository.UrlPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string Url
        {
            get
            {
                return ((string)(base[global::SpaceTraffic.GithubToTfsSync.TargetRepository.UrlPropertyName]));
            }
            set
            {
                base[global::SpaceTraffic.GithubToTfsSync.TargetRepository.UrlPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace SpaceTraffic.GithubToTfsSync
{
    
    
    /// <summary>
    /// A collection of TargetRepository instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::SpaceTraffic.GithubToTfsSync.TargetRepository), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate, AddItemName=global::SpaceTraffic.GithubToTfsSync.TargetRepositoryCollection.TargetRepositoryPropertyName)]
    public partial class TargetRepositoryCollection : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::SpaceTraffic.GithubToTfsSync.TargetRepository"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string TargetRepositoryPropertyName = "repository";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override string ElementName
        {
            get
            {
                return global::SpaceTraffic.GithubToTfsSync.TargetRepositoryCollection.TargetRepositoryPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::SpaceTraffic.GithubToTfsSync.TargetRepositoryCollection.TargetRepositoryPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::SpaceTraffic.GithubToTfsSync.TargetRepository)(element)).Id;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::SpaceTraffic.GithubToTfsSync.TargetRepository"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::SpaceTraffic.GithubToTfsSync.TargetRepository"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::SpaceTraffic.GithubToTfsSync.TargetRepository();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::SpaceTraffic.GithubToTfsSync.TargetRepository"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::SpaceTraffic.GithubToTfsSync.TargetRepository"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::SpaceTraffic.GithubToTfsSync.TargetRepository this[int index]
        {
            get
            {
                return ((global::SpaceTraffic.GithubToTfsSync.TargetRepository)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::SpaceTraffic.GithubToTfsSync.TargetRepository"/> with the specified key.
        /// </summary>
        /// <param name="id">The key of the <see cref="global::SpaceTraffic.GithubToTfsSync.TargetRepository"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::SpaceTraffic.GithubToTfsSync.TargetRepository this[object id]
        {
            get
            {
                return ((global::SpaceTraffic.GithubToTfsSync.TargetRepository)(base.BaseGet(id)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::SpaceTraffic.GithubToTfsSync.TargetRepository"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="repository">The <see cref="global::SpaceTraffic.GithubToTfsSync.TargetRepository"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public void Add(global::SpaceTraffic.GithubToTfsSync.TargetRepository repository)
        {
            base.BaseAdd(repository);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::SpaceTraffic.GithubToTfsSync.TargetRepository"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="repository">The <see cref="global::SpaceTraffic.GithubToTfsSync.TargetRepository"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public void Remove(global::SpaceTraffic.GithubToTfsSync.TargetRepository repository)
        {
            base.BaseRemove(this.GetElementKey(repository));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::SpaceTraffic.GithubToTfsSync.TargetRepository"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::SpaceTraffic.GithubToTfsSync.TargetRepository"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::SpaceTraffic.GithubToTfsSync.TargetRepository GetItemAt(int index)
        {
            return ((global::SpaceTraffic.GithubToTfsSync.TargetRepository)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::SpaceTraffic.GithubToTfsSync.TargetRepository"/> with the specified key.
        /// </summary>
        /// <param name="id">The key of the <see cref="global::SpaceTraffic.GithubToTfsSync.TargetRepository"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::SpaceTraffic.GithubToTfsSync.TargetRepository GetItemByKey(string id)
        {
            return ((global::SpaceTraffic.GithubToTfsSync.TargetRepository)(base.BaseGet(((object)(id)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}
namespace SpaceTraffic.GithubToTfsSync
{
    
    
    /// <summary>
    /// The SourceRepository Configuration Element.
    /// </summary>
    public partial class SourceRepository : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Url Property
        /// <summary>
        /// The XML name of the <see cref="Url"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string UrlPropertyName = "url";
        
        /// <summary>
        /// Gets or sets uRL of the source repository.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("URL of the source repository.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::SpaceTraffic.GithubToTfsSync.SourceRepository.UrlPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string Url
        {
            get
            {
                return ((string)(base[global::SpaceTraffic.GithubToTfsSync.SourceRepository.UrlPropertyName]));
            }
            set
            {
                base[global::SpaceTraffic.GithubToTfsSync.SourceRepository.UrlPropertyName] = value;
            }
        }
        #endregion
    }
}