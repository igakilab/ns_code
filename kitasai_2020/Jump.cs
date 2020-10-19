using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jump : MonoBehaviour
{
	public GameObject PlayerController;
	public int up = 0;

	// Start is called before the first frame update
	void Start()
	{
		PlayerController = GameObject.Find("Player");
	}

	// Update is called once per frame
	void Update()
	{
	}

	public void onClick()
	{
		PlayerController.GetComponent<PlayerController>().mvJump = true;
		// PlayerController.GetComponent<PlayerController>().mvJump = false;
		up++;
		/*if (Input.GetButtonUp("Jump"))
		{
			PlayerController.GetComponent<PlayerController>().mvJump = false;
		}*/
		if(up == 2)
		{
			PlayerController.GetComponent<PlayerController>().mvJump = false;
			up = 0;
		}
	}
}