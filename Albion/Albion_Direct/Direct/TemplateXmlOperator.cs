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
    /* Internal type: jv */
    public partial class TemplateXmlOperator
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private jv _internal;
        
        #region Properties
        
        public jv TemplateXmlOperator_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public TemplateXmlOperator(jv instance)
        {
            _internal = instance;
        }
        
        static TemplateXmlOperator()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator jv(TemplateXmlOperator instance)
        {
            return instance._internal;
        }
        
        public static implicit operator TemplateXmlOperator(jv instance)
        {
            return new TemplateXmlOperator(instance);
        }
        
        public static implicit operator bool(TemplateXmlOperator instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
