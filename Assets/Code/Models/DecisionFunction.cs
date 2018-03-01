// ----------------------------------------------------------------------------
// Unity - Utility AI
// 
// Author: Yann Lacour
// Date:   01/03/2018
// ----------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.Events;

namespace UtilityAI
{
    [System.Serializable]
    public class DecisionFunction
    {
        public UtilityFunction function;
        public UnityEvent eventToRaise;

    }
}
