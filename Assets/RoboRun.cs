using UnityEngine;
using System.Collections;

public class RoboRun : MonoBehaviour {

    float speed = 0.1f;
    //public bool alive = true;
    public Vector3 posGO;
    public Quaternion quaGO;
    bool move = false;
    float randomLane;

    // Use this for initialization
    void Start () {
        posGO = gameObject.transform.position;
        quaGO = Quaternion.identity;
    }
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    //Movement function
    void Movement()
    {
        //with Key
        if (Input.GetKey (KeyCode.A))
        {
            //transform.Translate(Vector2.left * speed);
            //stop movement with A
            move = false;
        }

        //automatically
        if (move==true)
        {
            transform.Translate(Vector2.right * speed);
        }
    }

    //Resets Robo Position w/ Child + Destroy
    void ResetRobo ()
    {
        
        Instantiate(gameObject, posGO, quaGO);
        Destroy(gameObject);
    }

    //Checks Collision 
    void OnCollisionEnter(Collision col)
    {
        //w/ BottomBox
        if (col.transform.gameObject.name == "BottomBox")
        {
            //print("Bumm!");
            ResetRobo();
        }

        //Checks Collision w/ Lanes
        if (col.transform.gameObject.name == "Lane")
        {
            move = true;
            //speed = 0.1f;
            speed = Random.Range(0.05f,0.3f);
        }
        
        //Checks collision w/ Monster
        if (col.transform.gameObject.name == "Monster")
        {
            GameObject cam = GameObject.Find("Main Camera");
            DraggingScript camScript = cam.GetComponent<DraggingScript>();
            camScript.score = camScript.score + 10f;
            ResetRobo();
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.transform.gameObject.name == "Lane")
        {
            //move = false;
            speed = 0.03f;
        }
    }
}
