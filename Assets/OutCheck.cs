using UnityEngine;
using System.Collections;

public class OutCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Collision
    void OnCollisionEnter(Collision collisionInfo)
    {
        //print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
    }
}
