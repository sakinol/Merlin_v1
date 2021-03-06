////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.336.100246-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Reflection;

namespace Albion_Direct
{
    /* Internal type: o6 */
    public partial class ClusterTypeDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private o6 _internal;
        
        #region Properties
        
        public o6 ClusterTypeDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public PvpRules GetPvpRules() => _internal.ap().ToWrapped();
        
        #endregion
        
        #region Constructor
        
        public ClusterTypeDescriptor(o6 instance)
        {
            _internal = instance;
        }
        
        static ClusterTypeDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator o6(ClusterTypeDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ClusterTypeDescriptor(o6 instance)
        {
            return new ClusterTypeDescriptor(instance);
        }
        
        public static implicit operator bool(ClusterTypeDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
