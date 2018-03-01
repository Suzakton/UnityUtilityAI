// ----------------------------------------------------------------------------
// Unity - Utility AI Demo Scene
//
// Author: Yann Lacour
// Date:   01/03/2018
// ----------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.AI;
using UtilityAI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentBehavior : MonoBehaviour
{

    public Transform workSpace;
    public Transform eatSpace;
    public Transform sleepSpace;

    public UtilityVariable money;
    public UtilityVariable hunger;
    public UtilityVariable sleepiness;


    private NavMeshAgent agent;
    private string zoneName = "";

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        money.currentValue = 0;
        hunger.currentValue = 0;
        sleepiness.currentValue = 0;
    }


    void Update()
    {
        checkIfDead();
        changeVariables();
        checkZone();
    }

    private void checkIfDead()
    {
        if (hunger.currentValue >= hunger.maxValue)
        {
            Debug.Log("Died of hunger");
            Destroy(this.gameObject);
        }

        if (sleepiness.currentValue >= sleepiness.maxValue)
        {
            Debug.Log("Died of sleepiness");
            Destroy(this.gameObject);
        }
    }


    private void changeVariables()
    {
        hunger.currentValue += (2 * Time.deltaTime);
        sleepiness.currentValue += Time.deltaTime;
    }

    private void checkZone()
    {
        switch (zoneName)
        {
            case "WorkZone":
                money.currentValue += 7 * Time.deltaTime;
                break;
            case "EatZone":
                if (money.currentValue > 2 * Time.deltaTime)
                {
                    money.currentValue -= 2 * Time.deltaTime;
                    hunger.currentValue -= 6 * Time.deltaTime;
                }
                break;
            case "SleepZone":
                sleepiness.currentValue -= 4 * Time.deltaTime;
                break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        zoneName = other.gameObject.tag;
    }

    void OnTriggerExit(Collider other)
    {
        zoneName = "";
    }

    #region Event functions
    public void goToWork()
    {
        agent.SetDestination(workSpace.position);
    }

    public void goToEat()
    {
        agent.SetDestination(eatSpace.position);
    }

    public void goToSleep()
    {
        agent.SetDestination(sleepSpace.position);
    }

    #endregion
}
