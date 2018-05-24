using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	private Animator _animator;

	public GameObject OpenPanel = null;

	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator>();
		OpenPanel.SetActive(false);
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{


			OpenPanel.SetActive(true);

		}
	}
  

	// Update is called once per frame
	void OnTriggerExit(Collider other) {
		_animator.SetBool("open", false);
		OpenPanel.SetActive(false);

		
	}

	private bool IsOpenPanelActive{
		get{
			return OpenPanel.activeInHierarchy;
		}
	}

	private void Update()
	{
		if(IsOpenPanelActive){
			if(Input.GetKeyDown(KeyCode.E)){
				OpenPanel.SetActive(false);
				_animator.SetBool("open", true);
			}
		}
	}
}
