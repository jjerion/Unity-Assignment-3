using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    //set speed
    float speed = 5f;
    //set height
    float height = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //put object's current position in variable
        Vector3 pos = transform.position;
        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed);
        //set object Y to new Y
        transform.position = new Vector3(pos.x, newY, pos.z) * height;

        if(newY <= .4)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = new Color(100, 0, 10);
           
        }

        if (newY >= -.4)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = new Color(0, 100, 100);

        }

    }
}
