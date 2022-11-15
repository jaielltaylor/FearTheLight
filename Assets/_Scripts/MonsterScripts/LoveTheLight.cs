using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoveTheLight : MonoBehaviour
{
    private float deathCounter = 0;
    private bool monsterIn = false;   

    void Update()
    {
        if (monsterIn)
        {
            deathCounter += Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        monsterIn = true;
    }

    private void OnCollisionStay(Collision otherObj)
    {
        if (deathCounter >= 1 && monsterIn == true)
        {
            if (otherObj.transform.tag.Equals("LightisDeath"))
            {
                //Destroy(collision.transform.gameObject);
                otherObj.transform.SendMessage("FearTheLight", SendMessageOptions.DontRequireReceiver);
                deathCounter = 0;
            }
        }
    }

    private void OnCollisionExit(Collision otherObj)
    {
        monsterIn = false;
    }
}
