using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{

    public bool inTrigger;
	public float flt;

    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
		if(flt < 1.0f){
			FindObjectOfType<AudioManager>().Play("KnockOnDoor");
		}


    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
		  
    }

    // Use this for initialization
    void Start()
    {
		flt = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (inTrigger)
        {   
			if (flt < 1.0f){
			    KnockOnDoor.knock = true;

			    KnockOnDoor.flt = 1.0f;
				flt = 1.0f;
			}
        }

		if(inTrigger == false){
			KnockOnDoor.knock = false;

		}
    }
}
