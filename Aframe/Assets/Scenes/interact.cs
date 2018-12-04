using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour {

    public BoxCollider cd;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider2D other)
    {
        if (other.gameObject.tag == "camera")
        {
            Destroy(this.gameObject);
        }
    }
}

