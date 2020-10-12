using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour{
	public float speed = 8f;
	public float life = 3f;

	public string blockTag = "Block";

	// public GameObject textObject;

	void Start(){
		// textObject = GameObject.Find("Timer");
	}

	// 当たり判定
	void OnCollisionEnter2D(Collision2D collision)
	{
		
		if(life == 0)
		{
			if(collision.collider.tag == blockTag)
			{
				SceneManager.LoadScene("GameOver");
			}
		}else
		{
			if(collision.collider.tag == blockTag)
			{
				life--;
			}
		}
	}

	void Update(){
		/* if(textObject.GetComponent<TimerController>().seconds > 0)
		{
			return;
		}*/
		
		if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(speed * Time.deltaTime, speed * Time.deltaTime, 0);
		} else {
			transform.Translate(speed * Time.deltaTime, 0, 0);
		}
		transform.position = new Vector2(Mathf.Clamp(transform.position.x, -20f, 20f), Mathf.Clamp(transform.position.y, -30f, 50f));

		if(transform.position.y < -20)
		{
			SceneManager.LoadScene("GameOver");
		}
		if(transform.position.x > 19)
		{
			SceneManager.LoadScene("GameOver");
		}
	}
}
