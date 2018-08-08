using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.W))
        {

            transform.position += transform.forward * 0.1f;
        }
        if (Input.GetKey(KeyCode.S))
        {

            transform.position -= transform.forward * 0.1f;
        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.position -= transform.right * 0.1f;
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.position += transform.right * 0.1f;
        }
    }
}
