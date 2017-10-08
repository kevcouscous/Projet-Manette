using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    private float horizontal = 0;
    private float vertical = 0;
    public float multHorizontal = 0;
    public float multVertical = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(horizontal * multHorizontal, vertical * multVertical, 0);
    }
}
