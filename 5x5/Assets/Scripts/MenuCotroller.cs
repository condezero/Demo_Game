﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCotroller : MonoBehaviour {

	// Use this for initialization
	public void StartGame(){
		SceneManager.LoadScene ("main");
	}
}
