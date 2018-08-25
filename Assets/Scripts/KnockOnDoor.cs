using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockOnDoor : MonoBehaviour
{


    private Animator _animator;
    public bool locked;
    public bool inTrigger;
	public static bool knock;
	public static float flt;

    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
		_animator.SetBool("inTrigger", true);
		if (flt > 0.0){
			FindObjectOfType<AudioManager>().Play("DropDoor");
		}
        _animator.SetBool("open", false);
		locked = true;
		flt = 0.0f;

    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
		_animator.SetBool("inTrigger", false);


    }

    // Use this for initialization
    void Start()
    {
        
        _animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {


        if (inTrigger)
        {
			
            if (locked)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
					_animator.SetBool("locked", true);
                    FindObjectOfType<AudioManager>().Play("LockedDoor");
                }
            }
			if (locked == false){
				_animator.SetBool("locked", false);
                
				
			}
            
        }

		if (knock){
			_animator.SetBool("knock", true);
            
		}

		if (knock == false){
			_animator.SetBool("knock", false);
		}

		if(flt > 0.0f){
			_animator.SetFloat("float", 1.0f);
			_animator.SetBool("open", true);

		}
        

    }
}
