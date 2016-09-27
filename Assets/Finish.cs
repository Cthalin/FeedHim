using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject cam = GameObject.Find("Main Camera");
        DraggingScript camScript = cam.GetComponent<DraggingScript>();

        if (camScript.score >= 100f)
        {
            print("FINISH");
            Application.LoadLevel("finish");
        }
        else
        {
            //print("Möp."); //Test
        }
    }
}
