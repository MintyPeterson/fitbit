﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FunkyMoonCow.Fitbit.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FunkyMoonCow.Fitbit.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to { &quot;type&quot;: &quot;object&quot;, &quot;properties&quot;: { &quot;collectionType&quot;: { &quot;type&quot;: &quot;string&quot; }, &quot;ownerId&quot;: { &quot;type&quot;: &quot;string&quot; }, &quot;ownerType&quot;: { &quot;type&quot;: &quot;string&quot; }, &quot;subscriberId&quot;: { &quot;type&quot;: &quot;string&quot; }, &quot;subscriptionId&quot;: { &quot;type&quot;: &quot;string&quot; } }, &quot;required&quot;: [ &quot;collectionType&quot;, &quot;ownerId&quot;, &quot;ownerType&quot;, &quot;subscriberId&quot;, &quot;subscriptionId&quot; ] }.
        /// </summary>
        internal static string AddSubscriptionSchema {
            get {
                return ResourceManager.GetString("AddSubscriptionSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;errors&quot;:{&quot;type&quot;:&quot;array&quot;,&quot;items&quot;:{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;errorType&quot;:{&quot;type&quot;:&quot;string&quot;},&quot;message&quot;:{&quot;type&quot;:&quot;string&quot;}},&quot;required&quot;:[&quot;errorType&quot;,&quot;message&quot;]}},&quot;success&quot;:{&quot;type&quot;:&quot;boolean&quot;}},&quot;required&quot;:[&quot;errors&quot;,&quot;success&quot;]}.
        /// </summary>
        internal static string ErrorSchema {
            get {
                return ResourceManager.GetString("ErrorSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to { &quot;type&quot;: &quot;array&quot;, &quot;items&quot;: { &quot;type&quot;: &quot;object&quot;, &quot;properties&quot;: { &quot;dateTime&quot;: { &quot;type&quot;: &quot;string&quot; }, &quot;value&quot;: { &quot;type&quot;: &quot;string&quot; } }, &quot;required&quot;: [ &quot;dateTime&quot;, &quot;value&quot; ] } }.
        /// </summary>
        internal static string GetActivityTimeSeriesSchema {
            get {
                return ResourceManager.GetString("GetActivityTimeSeriesSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to { &quot;type&quot;: &quot;object&quot;, &quot;properties&quot;: { &quot;badges&quot;: { &quot;type&quot;: &quot;array&quot;, &quot;items&quot;: { &quot;type&quot;: &quot;object&quot;, &quot;properties&quot;: { &quot;badgeType&quot;: { &quot;type&quot;: &quot;string&quot; }, &quot;dateTime&quot;: { &quot;type&quot;: &quot;string&quot; }, &quot;image50px&quot;: { &quot;type&quot;: &quot;string&quot; }, &quot;image75px&quot;: { &quot;type&quot;: &quot;string&quot; }, &quot;timesAchieved&quot;: { &quot;type&quot;: &quot;integer&quot; }, &quot;value&quot;: { &quot;type&quot;: &quot;integer&quot; }, &quot;unit&quot;: { &quot;type&quot;: &quot;string&quot; }, }, &quot;required&quot;: [ &quot;badgeType&quot;, &quot;dateTime&quot;, &quot;image50px&quot;, &quot;image75px&quot;, &quot;timesAchieved&quot;, &quot;value&quot; ] } } }, &quot;required&quot;: [ &quot;badges&quot; ] }.
        /// </summary>
        internal static string GetBadgesSchema {
            get {
                return ResourceManager.GetString("GetBadgesSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;activities&quot;:{&quot;type&quot;:&quot;array&quot;,&quot;items&quot;:{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;activityId&quot;:{&quot;type&quot;:&quot;integer&quot;},&quot;activityParentId&quot;:{&quot;type&quot;:&quot;integer&quot;},&quot;calories&quot;:{&quot;type&quot;:&quot;integer&quot;},&quot;description&quot;:{&quot;type&quot;:&quot;string&quot;},&quot;distance&quot;:{&quot;type&quot;:&quot;number&quot;},&quot;duration&quot;:{&quot;type&quot;:&quot;integer&quot;},&quot;hasStartTime&quot;:{&quot;type&quot;:&quot;boolean&quot;},&quot;isFavorite&quot;:{&quot;type&quot;:&quot;boolean&quot;},&quot;logId&quot;:{&quot;type&quot;:&quot;integer&quot;},&quot;name&quot;:{&quot;type&quot;:&quot;string&quot;},&quot;startTime&quot;:{&quot;type&quot;:&quot;string&quot;},&quot;steps&quot;:{&quot;type&quot;:&quot;integer&quot;}},&quot;required&quot;:[&quot;activityId&quot;,&quot;activityParentId&quot;,&quot;c [rest of stri....
        /// </summary>
        internal static string GetDailyActivitySummarySchema {
            get {
                return ResourceManager.GetString("GetDailyActivitySummarySchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to { &quot;type&quot;: &quot;array&quot;, &quot;items&quot;: { &quot;type&quot;: &quot;object&quot;, &quot;properties&quot;: { &quot;dateTime&quot;: { &quot;type&quot;: &quot;string&quot; }, &quot;value&quot;: { &quot;type&quot;: &quot;string&quot; } }, &quot;required&quot;: [ &quot;dateTime&quot;, &quot;value&quot; ] } }.
        /// </summary>
        internal static string GetFoodOrWaterTimeSeriesSchema {
            get {
                return ResourceManager.GetString("GetFoodOrWaterTimeSeriesSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to { &quot;type&quot;: &quot;object&quot;, &quot;properties&quot;: { &quot;user&quot;: { &quot;type&quot;: &quot;object&quot;, &quot;properties&quot;: {} } }, &quot;required&quot;: [ &quot;user&quot; ] }.
        /// </summary>
        internal static string GetProfileSchema {
            get {
                return ResourceManager.GetString("GetProfileSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;access_token&quot;:{&quot;type&quot;:&quot;string&quot;},&quot;expires_in&quot;:{&quot;type&quot;:&quot;integer&quot;},&quot;refresh_token&quot;:{&quot;type&quot;:&quot;string&quot;},&quot;token_type&quot;:{&quot;type&quot;:&quot;string&quot;},&quot;user_id&quot;:{&quot;type&quot;:&quot;string&quot;}},&quot;required&quot;:[&quot;access_token&quot;,&quot;expires_in&quot;,&quot;refresh_token&quot;,&quot;token_type&quot;,&quot;user_id&quot;]}.
        /// </summary>
        internal static string RefreshAccessTokenSchema {
            get {
                return ResourceManager.GetString("RefreshAccessTokenSchema", resourceCulture);
            }
        }
    }
}
