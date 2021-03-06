﻿// ----------------------------------------------------------------------------
// Unity - Utility AI
// 
// Author: Yann Lacour
// Date:   01/03/2018
// ----------------------------------------------------------------------------

using UnityEngine;

namespace UtilityAI
{
    [CreateAssetMenu(fileName = "UtilityFunction", menuName = "UtilityAI/Utility function")]
    public class UtilityFunction : ScriptableObject
    {
        /// <summary>
        /// Used to "weigth" the utility function.
        /// </summary>
        public float weight;

        /// <summary>
        /// List of watched variables and their curve
        /// </summary>
        public UtilityValue[] utilities;

        /// <summary>
        /// Main utility function. Return a value between -weight and weight.
        /// </summary>
        public float getUtilityValue()
        {
            float utilityValue = 0;
            foreach (UtilityValue uf in utilities)
            {
                utilityValue += Mathf.Clamp(uf.evaluateCurve(), -1, 1);
            }
            return (utilityValue / utilities.Length) * weight;
        }


    }
}
