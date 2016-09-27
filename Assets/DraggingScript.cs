using UnityEngine;
using System.Collections;

public class DraggingScript : MonoBehaviour {

    public GameObject gameObjectToDrag; //refer to GO being dragged

    public Vector2 GOcenter; //GameObjectCenter
    public Vector2 touchPosition; //Touch or Click Position
    public Vector2 offset; //Vector between GOcenter & touchPosition
    public Vector2 newGOcenter; //new center of GO
    public float score = 0f;

    RaycastHit hit; //store hit object info

    public bool draggingMode = false;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //if Ray hits collider
            if (Physics.Raycast(ray, out hit))
            {
                gameObjectToDrag = hit.collider.gameObject;
                GOcenter = gameObjectToDrag.transform.position;
                touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                offset = touchPosition - GOcenter;
                draggingMode = true;
            }
        }

        if (Input.GetMouseButton(0) && gameObjectToDrag!=null)
        {
            if (draggingMode)
            {
                touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                newGOcenter = touchPosition - offset;
                gameObjectToDrag.transform.position = new Vector2(newGOcenter.x, newGOcenter.y);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            draggingMode = false;
            //Check if above monster head=Feeded
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //if (Physics.Raycast(ray, out hit))
            //{
            //    if (hit.transform.tag == "monster")
            //    {
            //        //score = score + 10f;
            //        //print("Score: " + score);
            //    }
            //}
        }
	
	}
}
