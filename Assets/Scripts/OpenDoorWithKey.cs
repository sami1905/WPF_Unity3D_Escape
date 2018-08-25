using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorWithKey : MonoBehaviour {


	private Animator _animator;
	public static bool locked;
	public bool inTrigger;
	public string levelToLoad;
	private float timer = 3f;

	void OnTriggerEnter(Collider other)
	{
		inTrigger = true;
		_animator.SetFloat("float", 1.0f);
	}

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
		_animator.SetFloat("float", 1.0f);

    }

	// Use this for initialization
	void Start () {
		locked = true;
		_animator = GetComponent<Animator>();

	}

	// Update is called once per frame
	void Update () {
        
		if(locked == false){
			_animator.SetBool("locked", false);
			_animator.SetBool("StartOpen", true);
		}

		if(inTrigger){
			if(locked){
				if(Input.GetKeyDown(KeyCode.E)){
					_animator.SetBool("locked", true);
					_animator.SetFloat("float", 0.0f);
                    FindObjectOfType<AudioManager>().Play("LockedDoor");
				}
			}
			if(locked == false){
				if (Input.GetKeyDown(KeyCode.E))
				{
					_animator.SetBool("open", true);
					FindObjectOfType<AudioManager>().Play("OpenDoor");
				}
			}
		}
		if (_animator.GetBool("open"))
        {


            timer -= Time.deltaTime;
            if (timer <= 1.3)
            {
                float fadeTime = GameObject.Find("Terrain").GetComponent<Fading>().BeginFade(1);
            }
            if (timer <= 0)
            {

                Application.LoadLevel(levelToLoad);
            }
        }
		
	}
}
