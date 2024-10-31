using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class SpringPaddle : MonoBehaviour

{
    
    public KeyCode key;
    public Animation anim;
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            anim.Play();
        }
    }
}
