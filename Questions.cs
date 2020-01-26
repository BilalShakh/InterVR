using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour
{
    private int num = 1;
    public AudioSource clip1;
    public AudioSource clip2;
    public AudioSource clip3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (num == 1)
            {
                clip2.Play();
                num++;
            }
            else if (num ==2)
            {
                clip3.Play();
                num++;
            }
        }
    }
}
