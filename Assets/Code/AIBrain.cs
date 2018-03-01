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
    public class AIBrain : MonoBehaviour
    {
        [Tooltip("Utility functions and events to invoke")]
        public DecisionFunction[] decisionFunctions;

        void Update()
        {
            takeDecision();
        }

        /// <summary>
        /// Look for the highest value from the decison functions and raise the associated events.
        /// </summary>
        private void takeDecision()
        {
            if (decisionFunctions.Length == 0)
            {
                return;
            }

            DecisionFunction maxValuefunction = decisionFunctions[0];
            for (int i = 1; i < decisionFunctions.Length; i++)
            {
                if (decisionFunctions[i].function.getUtilityValue() > maxValuefunction.function.getUtilityValue())
                {
                    maxValuefunction = decisionFunctions[i];
                }
            }

            maxValuefunction.eventToRaise.Invoke();
        }
    }
}