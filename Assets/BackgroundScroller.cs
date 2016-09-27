using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour {

    public float scrollSpeed;
    public float tileSizeZ;
    public float horizontalDirection = -1;

    public Vector2 startPosition; 

	// Use this for initialization
	void Start () {
        //scrollSpeed = 0.5f;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(scrollSpeed * horizontalDirection * Time.deltaTime, 0, 0));
    }

    void Infinite()
    {

    }
}
