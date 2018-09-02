using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child_Wispher_lvl4 : MonoBehaviour {

	public bool inTrigger;
	float flt = 0.0f;

    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inTrigger)
        {
			if(flt == 0.0){
				FindObjectOfType<AudioManager>().Play("Whisper");
				flt = 1.0f;
            }
		}
    }
}
