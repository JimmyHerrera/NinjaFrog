using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
   private PlatformEffector2D effector;

   public float startWaitTime;

   private float waitedTime;
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            waitedTime = startWaitTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            if (waitedTime<=0)
            {
                effector.rotationalOffset = 180f;
                waitedTime = startWaitTime;
            }
            else 
            {
                waitedTime = Time.deltaTime;
            }
        }

        if (Input.GetKey("space"))
        {
            effector.rotationalOffset = 0;
        }
    }
}
