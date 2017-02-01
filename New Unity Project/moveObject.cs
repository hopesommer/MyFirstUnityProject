using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour {

<<<<<<< HEAD
    //classes are the blueprint for individual objects 


=======
>>>>>>> master
	// Use this for initialization
	void Update () {
        if (Input.GetKey (KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(-.5f, 0, 0);
        }
		if (Input.GetKey (KeyCode.RightArrow))
        {
            gameObject.transform.Translate(.5f, 0, 0);
        }
        if (Input.GetKey (KeyCode.UpArrow))
        {
            gameObject.transform.Translate(0, .5f, 0);
        }
        if (Input.GetKey (KeyCode.DownArrow))
        {
            gameObject.transform.Translate(0, -.5f, 0);

        }
	}
		// Update is called once per frame
 
		
	}

