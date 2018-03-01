// ----------------------------------------------------------------------------
// Unity - Utility AI
// 
// Author: Yann Lacour
// Date:   01/03/2018
// ----------------------------------------------------------------------------

using UnityEngine;

namespace UtilityAI
{
    [System.Serializable]
    public class UtilityValue
    {

        public UtilityVariable value;
   
        /// <summary>
        /// The curve used th evaluate the utility variable.
        /// This curve must be defined between 0 and 1 on the x-axis.
        /// If no curve is defined on a value, 0 is returned.
        /// </summary>
        public AnimationCurve curve = AnimationCurve.Linear(0, 0, 1, 1);


        /// <summary>
        /// Return the evaluation of the value on the curve.
        /// Return a float between 0 and 1.
        /// </summary>
        public float evaluateCurve()
        {
            if (value.getValueBetween0and1() < curve.keys[0].time || value.getValueBetween0and1() > curve.keys[curve.keys.Length - 1].time)
            {

                return 0;
            }
            else
            {
                return curve.Evaluate(value.getValueBetween0and1());
            }
        }
    }
}