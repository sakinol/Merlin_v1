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
    /* Internal type: adw */
    public partial class FightingAttributes
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private adw _internal;
        
        #region Properties
        
        public adw FightingAttributes_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public float GetEnergyRegen() => _internal.bc();
        public float GetHealthRegen() => _internal.ba();
        public float GetMaxCraftingFocus() => _internal.cs();
        public float GetMaxCraftingRegeneration() => _internal.ct();
        public float GetMaxEnergy() => _internal.bb();
        public float GetMaxHealth() => _internal.a9();
        public float GetMaxLoad() => _internal.be();
        public float GetMoveSpeed() => _internal.bd();
        
        #endregion
        
        #region Constructor
        
        public FightingAttributes(adw instance)
        {
            _internal = instance;
        }
        
        static FightingAttributes()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator adw(FightingAttributes instance)
        {
            return instance._internal;
        }
        
        public static implicit operator FightingAttributes(adw instance)
        {
            return new FightingAttributes(instance);
        }
        
        public static implicit operator bool(FightingAttributes instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
