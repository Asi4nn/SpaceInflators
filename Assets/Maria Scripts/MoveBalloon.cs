using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBalloon : MonoBehaviour
{
    public static int movespeed = 1;
    //private bounds = new Vector3(0,0,0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Transform>().position -= transform.forward * movespeed * Time.deltaTime;

        if (gameObject.GetComponent<Transform>().position.z <=  0)
        {
            Destroy(this.gameObject);
        }
    }
}
