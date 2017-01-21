using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour {
	private const int DEFAULT_TEXT_SPEED=20;
	public int TextSpeed=DEFAULT_TEXT_SPEED;

	// Use this for initialization
	void Start () {
		TextSpeed = PlayerPrefs.GetInt ("TextSpeed", DEFAULT_TEXT_SPEED);
		print(TextSpeed);
	}

	public void ShowSettingsMenu() {
		print ("mmm settings");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
