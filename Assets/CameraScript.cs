using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float mouseX;
    public float mouseY;
    public GameObject player;

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        CameraControl();
	}

    void CameraControl()
    {
        player.transform.eulerAngles += new Vector3(-mouseY, transform.eulerAngles.y, 0.0f);
        transform.eulerAngles += new Vector3(transform.eulerAngles.x, mouseX, 0.0f);
    }
}
