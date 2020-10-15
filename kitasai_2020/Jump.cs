using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jump : MonoBehaviour
{
	public GameObject PlayerController;

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
	}
}