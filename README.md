# UnityUtilityAI
Utility AI for Unity with Scriptable Object

## Getting Started
To use this project the Code folder (under the Asset one) is enough.
The other one are for the demo scene.

## Using the UtilityAI

### UtilityVariable

An UtilityVariable is a ScriptableObject that represent a variable your AI want to use to make decisions.

### UtilityFunction

This function use UtilityVariables and curves to give a value which represent how much we want this function to weight on the decision.
Each UtilityVariables are associated with a curve. This curve must be defined between 0 and 1 on the x-axis.
Each curves will be evaluated and a value between 0 and weight will be returned.


### AIBrain

This script is a Monobehavior script.
It take UtilityFunctions associated with UnityEvent. The UnityEvent is invoked if the associated UtilityFunction return the highest value. Careful it's invoked each update().
