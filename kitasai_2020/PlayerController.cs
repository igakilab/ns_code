using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
	public float speed = 8f;
	public float life = 3f;
	public int jump = 0;

	public string blockTag = "Block";

	public bool mvJump = false;

	// public GameObject textObject;

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

	void Start()
	{
		// textObject = GameObject.Find("Timer");
		mvJump = false;
	}

	void Update()
	{
		/* if(textObject.GetComponent<TimerController>().seconds > 0)
		{
			return;
		}*/

		if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
		{
			if(jump == 0 || jump == 1)
			{
				transform.Translate(speed * Time.deltaTime * 2, speed * Time.deltaTime * 2, 0);
				jump++;
			}else
			{
				transform.Translate(speed * Time.deltaTime, 0, 0);
			}
		} else if(mvJump == true)
		{
			if(jump == 0 || jump == 1)
			{
				transform.Translate(speed * Time.deltaTime, speed * Time.deltaTime, 0);
				jump++;
			}else
			{
				transform.Translate(speed * Time.deltaTime, 0, 0);
			}
		} else {
			transform.Translate(speed * Time.deltaTime, 0, 0);
		}
		transform.position = new Vector2(Mathf.Clamp(transform.position.x, -20f, 20f), Mathf.Clamp(transform.position.y, -30f, 50f));
		if(jump == 2)
		{
			jump = 0;
		}

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
