using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterBehavior : MonoBehaviour
{
    private Transform myTransform;
    public GameObject target;
    public float attackDistance;
    public float spotDistance;
    public float speed;

    public AudioClip onAttack;
    private AudioSource monsterAudio;
    private Animator animator;
    public float rateOfAttack;
    private float nextAttackTime;

    void Start()
    {
        monsterAudio = GetComponent<AudioSource>();
        myTransform = transform;
        nextAttackTime = Time.time;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(myTransform.position, target.transform.position);
        if (distance <= attackDistance)
        {   // The AI is in range to attack the player ("Attack" state)
            animator.SetTrigger("Smash Attack");
            monsterAudio.clip = onAttack;
            monsterAudio.Play();
            myTransform.LookAt(target.transform);
            myTransform.position = Vector3.MoveTowards(myTransform.position, target.transform.position, speed * Time.deltaTime);

            if (Time.time > nextAttackTime)
            {
                GameControl.control.health -= 10;   // Subtract 10 points from player's health on each attack
                nextAttackTime = Time.time + rateOfAttack;
                
                if (GameControl.control.health <= 0) // When player's health drops to 0 or below...
                {
                    SceneManager.LoadScene(5);
                }
            }

        }
        else if (distance <= spotDistance)
        {   // The AI is in the "Chase" state
            animator.SetBool("Run Forward", true);
            myTransform.LookAt(target.transform);
            myTransform.position = Vector3.MoveTowards(myTransform.position, target.transform.position, speed * Time.deltaTime);
        }
        else
        {   // The AI is in "Idle" state
            animator.Play("Idle");
        }
    }
}
