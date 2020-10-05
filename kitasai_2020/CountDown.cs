using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
	public Text CountTime;
	public float time;
	int seconds;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		time -= Time.deltaTime;
		seconds = (int)time;
		CountTime.text = seconds.ToString();
		if(seconds == 0)
		{
			SceneManager.LoadScene("GameOver");
		}
	}
}
