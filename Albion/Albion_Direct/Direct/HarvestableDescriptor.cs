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
using System.Linq;

namespace Albion_Direct
{
    /* Internal type: h9 */
    public partial class HarvestableDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private h9 _internal;
        
        #region Properties
        
        public h9 HarvestableDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public HarvestableTierDescriptor[] GetTiers() => _internal.i().Select(x =>(HarvestableTierDescriptor)x).ToArray();
        
        #endregion
        
        #region Constructor
        
        public HarvestableDescriptor(h9 instance)
        {
            _internal = instance;
        }
        
        static HarvestableDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator h9(HarvestableDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator HarvestableDescriptor(h9 instance)
        {
            return new HarvestableDescriptor(instance);
        }
        
        public static implicit operator bool(HarvestableDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
