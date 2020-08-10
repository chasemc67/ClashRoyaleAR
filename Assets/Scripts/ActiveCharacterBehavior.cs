using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ActiveCharacterBehavior : MonoBehaviour
{
    public Transform destination;

    private NavMeshAgent agent;
    public Image healthBar;
    public float remainingHealth;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //healthBar = GetComponent<Image>();
        remainingHealth = 100f;
        MoveToNextPatrolLocation();
        
    }

    void MoveToNextPatrolLocation() {
        agent.destination = destination.position;
    }

    public void loseHealth() {
        if (remainingHealth > 1) {
            remainingHealth -= 0.1f;
            healthBar.fillAmount = (float) remainingHealth / 100;
        }

        if (remainingHealth < 50) {
            healthBar.color = Color.yellow;
        }

        if (remainingHealth < 20) {
            healthBar.color = Color.red;
        }
    }

    // Update is called once per frame
    void Update()
    {
        loseHealth();
    }
}
