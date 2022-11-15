using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoSwap : MonoBehaviour
{
    public float logotime;
    private float t = 0;
    private void Update()
    {
        t += Time.deltaTime;
        if (t >= logotime)
        {
            SceneManager.LoadScene(1);
        }
    }
}
