// ----------------------------------------------------------------------------
// Unity - Utility AI Demo Scene
//
// Author: Yann Lacour
// Date:   01/03/2018
// ----------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.UI;
using UtilityAI;

[RequireComponent(typeof(Text))]
public class VariableDebugText : MonoBehaviour
{

    public UtilityVariable variableToDebug;
    public string variableName;

    private Text textToChange;

    void Start()
    {
        textToChange = GetComponent<Text>();
    }

    void Update()
    {
        textToChange.text = variableName + " : " + variableToDebug.minValue + " | " + variableToDebug.currentValue.ToString("F2") + " | " + variableToDebug.maxValue;
    }
}
