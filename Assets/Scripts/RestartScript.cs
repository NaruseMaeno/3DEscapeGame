﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("return")) //マウス左クリック、エンター(リターン)キー
				{
					SceneManager.LoadScene("start");//demoシーンをロード
					//build settings 遷移したいシーンをお願いします。
		}
	}
}
