﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudyExamples {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StudyExamples.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version = &quot;1.0&quot; encoding = &quot;UTF-8&quot;?&gt;
        ///&lt;Hardware&gt;  
        ///  &lt;Serveillance&gt;
        ///	&lt;ServeillanceDevice category = &quot;DVR&quot;&gt;
        ///	   &lt;SrNo&gt;1&lt;/SrNo&gt;
        ///	   &lt;Make&gt;Dahuva&lt;/Make&gt;
        /// 	   &lt;Model&gt;Dahuva Ch8&lt;/Make&gt;
        ///	   &lt;PurchaseOn&gt;11102016&lt;/PurchaseOn&gt;	
        ///	&lt;/ServeillanceDevice&gt;
        ///
        ///       	&lt;ServeillanceDevice category = &quot;DVR&quot;&gt;
        ///	   &lt;SrNo&gt;2&lt;/SrNo&gt;
        ///	   &lt;Make&gt;Dahuva&lt;/Make&gt;
        /// 	   &lt;Model&gt;Dahuva Ch16&lt;/Make&gt;
        ///	   &lt;PurchaseOn&gt;11102015&lt;/PurchaseOn&gt;	
        ///	&lt;/ServeillanceDevice&gt;
        ///	
        ///		&lt;ServeillanceDevice category = &quot;DVR&quot;&gt;
        ///	   &lt;SrNo&gt;3&lt;/SrNo&gt;
        ///	  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string hardware {
            get {
                return ResourceManager.GetString("hardware", resourceCulture);
            }
        }
    }
}