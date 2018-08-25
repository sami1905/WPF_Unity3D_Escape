using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockScript : MonoBehaviour {

	public bool inTrigger;

	void OnTriggerEnter(Collider other)
	{
		inTrigger = true;
	}

	void OnTriggerExit(Collider other)
	{
		inTrigger = false;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(inTrigger){
			OpenDoorWithKey.locked = false;
		}
	}
}
