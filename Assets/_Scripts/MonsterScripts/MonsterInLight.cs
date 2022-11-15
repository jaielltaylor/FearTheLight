using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterInLight : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int health;

    private Animator animator;
    private UnityEngine.AI.NavMeshAgent agent;
    public Transform target;
    private Transform[] navPoints;

    private void Start()
    {
        if (agent == null)
        {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }
        animator = GetComponent<Animator>();
    }

    public void FearTheLight()
    {
        animator.SetTrigger("Take Damage");
        health -= 10;
        //RunAwayFromTarget();
        GameControl.control.score += 5;    // For every n seconds that the creature is in the light, it will take damage
        if (health <= 0)
        {
            GameControl.control.score += 100; // When the creature is destroyed, player gets 100points
            Transform myTrans = transform;
            GameObject expl = (GameObject)Instantiate(explosionPrefab, myTrans.position, myTrans.rotation);
            animator.SetTrigger("Die");
            Destroy(gameObject);
            Destroy(expl, 4);
        }
    }
    //NavMesh implementation pending (going to email you about that after this problem is fixed)
    /*void RunAwayFromTarget()
    {
        float furthestDistanceSoFar = 0;
        Vector3 runPosition = Vector3.zero;

        //Check each point
        foreach (Transform point in navPoints)
        {
            print(Vector3.Distance(target.position, point.position));
            float currentCheckDistance = Vector3.Distance(target.position, point.position);
            if (currentCheckDistance > furthestDistanceSoFar)
            {
                furthestDistanceSoFar = currentCheckDistance;
                runPosition = point.position;
            }
        }
        //Set the right destination for the furthest spot
        agent.SetDestination(runPosition);
    }
    */
}
