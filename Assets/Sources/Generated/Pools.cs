//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.PoolsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {

    public partial class Pools {

        public static Pool CreatePool() {
            return CreatePool("Pool", ComponentIds.TotalComponents, ComponentIds.componentNames, ComponentIds.componentTypes);
        }

        public Pool[] allPools { get { return new[] { pool }; } }

        public Pool pool;

        public void SetAllPools() {
            pool = CreatePool();
        }
    }
}
