using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public int duration = 60;
	private float timeLeft = 60f;
	public int timeRemaining;
	public bool isCountingDown = false;
	public Text count;

	void Start(){

	}

	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			SceneManager.LoadScene ("menu");
		}
		count.text = timeLeft.ToString();
	}
}
