using UnityEngine;
using UnityEngine.Scripting;

namespace Quantum.Game
{
    [Preserve]
    public class SomeSystem : SystemSignalsOnly, ISignalOnPlayerAdded
    {
        public void OnPlayerAdded(Frame f, PlayerRef player, bool firstTime)
        {
            Debug.Log("On Player added");
            f.Create(f.FindAsset(f.RuntimeConfig.SomePrototype));
        }
    }
}