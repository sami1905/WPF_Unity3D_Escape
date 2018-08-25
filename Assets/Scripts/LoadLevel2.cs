using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadLevel2 : MonoBehaviour
{
	public string levelToLoad;
	private float timer = 8f;
	private Text timerSeconds;

    // Use this for initialization
    void Start()
    {
		timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
		
		timer -= Time.deltaTime;
		if(timer <= 1){
			float fadeTime = GameObject.Find("Canvas").GetComponent<Fading>().BeginFade(1);
		}
		timerSeconds.text = timer.ToString("f0");
		if(timer <= 0){
			
			Application.LoadLevel(levelToLoad);
		}

    }
}
