using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour {

    public Camera cam;

	// Use this for initialization
	void Start () {
        cam = GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        cam.transform.localRotation = Quaternion.Euler(new Vector3(-mouseY,0,0)) * cam.transform.localRotation;
        transform.rotation = Quaternion.Euler(new Vector3(0,mouseX,0)) * transform.rotation;

        if (Input.GetKey(KeyCode.W)) {
            
            transform.position += transform.forward*0.1f;
        }
        if (Input.GetKey(KeyCode.S)) {
           
            transform.position -= transform.forward*0.1f;
        }if (Input.GetKey(KeyCode.A)) {
            
            transform.position -= transform.right*0.1f;
        }if (Input.GetKey(KeyCode.D)) {
            
            transform.position += transform.right*0.1f;
        }
    }
}
