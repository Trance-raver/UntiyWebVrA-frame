using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour {

    // not used for WebVr A-frame

    GameObject game;
    public Text text;
    public float speed;
    private Rigidbody rb;
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("yes");
            //Vector3 movement = new Vector3(0,1f,0);
            // rb.AddForce(movement * speed);
            this.transform.Translate(Vector3.right * speed * Time.deltaTime);

        }
	}
}
