using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 maxLeft;
    public Vector3 maxRight;
    public float speed;


    // Update is called once per frame
    void Update()
    {
        var axisMotion = Input.GetAxis("Horizontal");
        var targetDirection = new Vector3();
        
        if (axisMotion > 0)
	    {
		    targetDirection = maxRight;
	    }
        else
        {
            if (axisMotion < 0)
	        {
		        targetDirection = maxLeft;
	        }else
            {
                targetDirection  = transform.position;
            }
        }

        var smoothing = Time.deltaTime * speed;
        transform.position = Vector3.Lerp(transform.position, targetDirection, smoothing);
    }
}
