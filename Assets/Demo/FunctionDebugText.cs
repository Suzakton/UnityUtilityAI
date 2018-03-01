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
public class FunctionDebugText : MonoBehaviour
{

    public UtilityFunction functionToDebug;
    public string functionName;

    private Text textToChange;

    void Start()
    {
        textToChange = GetComponent<Text>();
    }

    void Update()
    {
        textToChange.text = functionName + " : " + functionToDebug.getUtilityValue().ToString("F2");
    }
}
