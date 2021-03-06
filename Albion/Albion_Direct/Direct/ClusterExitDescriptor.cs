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

using System;
using System.Collections.Generic;
using System.Reflection;

namespace Albion_Direct
{
    /* Internal type: ani */
    public partial class ClusterExitDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ani _internal;
        
        #region Properties
        
        public ani ClusterExitDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public ClusterDescriptor GetDestination() => _internal.p();
        public ClusterExitKind GetKind() => _internal.s().ToWrapped();
        public Point2 GetPosition() => _internal.w();
        public ClusterDescriptor GetSource() => _internal.m();
        public void SetDestination(ClusterDescriptor A_0) => _methodReflectionPool[0].Invoke(_internal,new object[]{(anh)A_0});
        public void SetSource(ClusterDescriptor A_0) => _methodReflectionPool[1].Invoke(_internal,new object[]{(anh)A_0});
        
        #endregion
        
        #region Constructor
        
        public ClusterExitDescriptor(ani instance)
        {
            _internal = instance;
        }
        
        static ClusterExitDescriptor()
        {
            _methodReflectionPool.Add(typeof(ani).GetMethod("m", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance, null, new Type[]{typeof(and)}, null));
            _methodReflectionPool.Add(typeof(ani).GetMethod("n", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance, null, new Type[]{typeof(and) }, null));
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ani(ClusterExitDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ClusterExitDescriptor(ani instance)
        {
            return new ClusterExitDescriptor(instance);
        }
        
        public static implicit operator bool(ClusterExitDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
