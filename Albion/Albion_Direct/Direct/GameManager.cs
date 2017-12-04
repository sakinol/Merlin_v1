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
    /* Internal type: a95 */
    public partial class GameManager
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a95 _internal;
        
        #region Properties
        
        public a95 GameManager_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public static GameManager GetInstance() => a95.s();
        public LandscapeManager GetLandscapeManager() => _internal.z();
        public LocalPlayerCharacterView GetLocalPlayerCharacterView() => _internal.v();
        public GameState GetState() => _internal.w().ToWrapped();
        public SimulationObjectView GetView(SimulationObject A_0) => _internal.a((ati)A_0);
        public SimulationObjectView GetView(long A_0) => _internal.a((long)A_0);
        
        #endregion
        
        #region Constructor
        
        public GameManager(a95 instance)
        {
            _internal = instance;
        }
        
        static GameManager()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a95(GameManager instance)
        {
            return instance._internal;
        }
        
        public static implicit operator GameManager(a95 instance)
        {
            return new GameManager(instance);
        }
        
        public static implicit operator bool(GameManager instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}