﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace GSoft.Dynamite.Lists
{
    /// <summary>
    /// Configuration object for metadata navigation and filtering for a list
    /// </summary>
    public class MetadataNavigationSettingsInfo
    {
        /// <summary>
        /// Default constructor for serialization purposes
        /// </summary>
        public MetadataNavigationSettingsInfo()
        {
        }

        /// <summary>
        /// Creates a new instance of MetadataNavigationSettingsInfo. Use this constructor if you have custom configurations
        /// </summary>
        /// <param name="list">The associated list</param>
        /// <param name="addFolderDefaultHierarchy">True to view the folder hierachy in the treeview. False otherwise</param>
        /// <param name="addContentTypeDefaultHierarchy">True to view the content type hierachy in the treeview. False otherwise</param>
        /// <param name="addContentTypeDefaultKeyFilter">True to view the content type key filter. False otherwise</param>
        /// <param name="hierachies">Treeview hierachies to add based on fields internal names</param>
        /// <param name="keyFilters">Fields internal names act as key filters</param>
        public MetadataNavigationSettingsInfo(
            ListInfo list,
            bool addFolderDefaultHierarchy,
            bool addContentTypeDefaultHierarchy,
            bool addContentTypeDefaultKeyFilter,
            IList<string> hierachies,
            IList<string> keyFilters)
        {
            this.List = list;

            this.AddContentTypeDefaultKeyFilter = addContentTypeDefaultKeyFilter;
            this.AddContentTypeDefaultHierarchy = addContentTypeDefaultHierarchy;
            this.AddFolderDefaultHierarchy = addFolderDefaultHierarchy;

            this.Hierarchies = hierachies;
            this.KeyFilters = keyFilters;
        }

        /// <summary>
        /// Creates a new instance of MetadataNavigationSettingsInfo. Use this constructor if you don't have any custom configurations
        /// </summary>
        /// <param name="list">The associated list</param>
        /// <param name="addFolderDefaultHierarchy">True to view the folder hierachy in the treeview. False otherwise</param>
        /// <param name="addContentTypeDefaultHierarchy">True to view the content type hierachy in the treeview. False otherwise</param>
        /// <param name="addContentTypeDefaultKeyFilter">True to view the content type key filter. False otherwise</param>
        public MetadataNavigationSettingsInfo(
            ListInfo list,
            bool addFolderDefaultHierarchy,
            bool addContentTypeDefaultHierarchy, 
            bool addContentTypeDefaultKeyFilter)
            : this(
            list,
            addFolderDefaultHierarchy, 
            addContentTypeDefaultHierarchy,
            addContentTypeDefaultKeyFilter, 
            null,
            null)
        {
        }

        /// <summary>
        /// The associated list
        /// </summary>
        public ListInfo List { get; set; }

        /// <summary>
        /// Fields internal names act as key filters
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "Allow overwrite of backing store to enable easier initialization of object.")]
        public IList<string> KeyFilters { get; set; }

        /// <summary>
        /// Treeview hierachies to add based on fields internal names
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "Allow overwrite of backing store to enable easier initialization of object.")]
        public IList<string> Hierarchies { get; set; }

        /// <summary>
        /// True to view the folder hierachy in the treeview. False otherwise
        /// </summary>
        public bool AddFolderDefaultHierarchy { get; set; }

        /// <summary>
        /// True to view the content type hierachy in the treeview. False otherwise
        /// </summary>
        public bool AddContentTypeDefaultHierarchy { get; set; }

        /// <summary>
        /// True to view the content type key filter. False otherwise
        /// </summary>
        public bool AddContentTypeDefaultKeyFilter { get; set; }
    }
}
