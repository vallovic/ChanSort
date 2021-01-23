﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChanSort.Loader.LG {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ChanSort.Loader.LG.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to -.
        /// </summary>
        internal static string GcSerializer_ReadChannelLists_NoChannelsCap {
            get {
                return ResourceManager.GetString("GcSerializer_ReadChannelLists_NoChannelsCap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -.
        /// </summary>
        internal static string GcSerializer_ReadChannelLists_NoChannelsMsg {
            get {
                return ResourceManager.GetString("GcSerializer_ReadChannelLists_NoChannelsMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your TV will only import the GlobalClone file when there are no files named xx*.TLL in the same directory.
        ///Do you want ChanSort to rename the conflicting files?.
        /// </summary>
        internal static string GcSerializer_ReadModelInfo_ModelWarning {
            get {
                return ResourceManager.GetString("GcSerializer_ReadModelInfo_ModelWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ATTENTION:
        ///Please make sure that your webOS based TV is using a recent firmware version (LB600 and higher: 4.41.32, UB: 4.51.44).
        ///Older LG firmware for webOS based TV models does not handle the import of channel lists properly and randomly reorders channels.
        ///(If your firmware is newer, you can ignore is message.).
        /// </summary>
        internal static string GcSerializer_webOsFirmwareWarning {
            get {
                return ResourceManager.GetString("GcSerializer_webOsFirmwareWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to !!! ATTENTION !!!
        ///
        ///LG channel lists can ONLY be imported back into the TV, when special options were selected during the TV&apos;s channel search process:
        ///- Provider: MUST be None/Other (do NOT select your cable provider or Astra 19.2E)
        ///- Blindscan: MUST be selected
        ///- Network search: optional (can be selected)
        ///
        ///Your TV will not process the list correctly if these steps are not followed!.
        /// </summary>
        internal static string LG_BlindscanInfo {
            get {
                return ResourceManager.GetString("LG_BlindscanInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancel.
        /// </summary>
        internal static string LG_BlindscanInfo_Cancel {
            get {
                return ResourceManager.GetString("LG_BlindscanInfo_Cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I searched for channels as described above.
        /// </summary>
        internal static string LG_BlindscanInfo_Continue {
            get {
                return ResourceManager.GetString("LG_BlindscanInfo_Continue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Read information about webOS 5 support on github.com.
        /// </summary>
        internal static string LG_BlindscanInfo_OpenWebpage {
            get {
                return ResourceManager.GetString("LG_BlindscanInfo_OpenWebpage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading process was canceled.
        /// </summary>
        internal static string LG_BlindscanInfo_Rejected {
            get {
                return ResourceManager.GetString("LG_BlindscanInfo_Rejected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Channel #{0} (Pr# {1}) was erased because it is a duplicate of channel #{2} (Pr# {3}): {4}.
        /// </summary>
        internal static string TllFileSerializer_ERR_dupeChannel {
            get {
                return ResourceManager.GetString("TllFileSerializer_ERR_dupeChannel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong checksum: calculated {1:x8} but file has {0:x8}.
        /// </summary>
        internal static string TllFileSerializer_ERR_wrongChecksum {
            get {
                return ResourceManager.GetString("TllFileSerializer_ERR_wrongChecksum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File size {0} is larger than allowed maxiumum of {1}.
        /// </summary>
        internal static string TllFileSerializerPlugin_ERR_fileTooBig {
            get {
                return ResourceManager.GetString("TllFileSerializerPlugin_ERR_fileTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file content doesn&apos;t match any supported model.
        /// </summary>
        internal static string TllFileSerializerPlugin_ERR_modelUnknown {
            get {
                return ResourceManager.GetString("TllFileSerializerPlugin_ERR_modelUnknown", resourceCulture);
            }
        }
    }
}
