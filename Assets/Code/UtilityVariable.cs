// ----------------------------------------------------------------------------
// Unity - Utility AI
// 
// Author: Yann Lacour
// Date:   01/03/2018
// ----------------------------------------------------------------------------

using UnityEngine;

namespace UtilityAI
{
    [CreateAssetMenu(fileName = "UtilityVariable", menuName = "UtilityAI/Utility variable")]
    public class UtilityVariable : ScriptableObject
    {

        public float _currentValue;
        public float currentValue
        {
            get { return _currentValue; }
            set
            {
                if (value < minValue)
                {
                    this._currentValue = minValue;
                }
                else if (value > maxValue)
                {
                    this._currentValue = maxValue;
                }
                else
                {
                    this._currentValue = value;
                }
            }
        }

        public float minValue;
        public float maxValue;

        public float getValueBetween0and1()
        {
            return (currentValue - minValue) / (maxValue - minValue);
        }
    }
}
