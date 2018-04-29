using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {
	GameObject[] Players;
	PlayerController[] Playercontrollers;
	public Text PlayerOneScore;
	public Text PlayerOneTime;
	public Text PlayerTwoScore;
	public Text PlayerTwoTime;

	// Use this for initialization
	void Start () {
		Players = GameObject.FindGameObjectsWithTag(Constants.PLAYER_TAG);
		Playercontrollers = new PlayerController[Players.Length];
		for(int i = 0; i < Players.Length ;i++){
			Playercontrollers[i] = Players[i].GetComponent<PlayerController>();
		}
	}
	
	// Update is called once per frame
	void Update () {
		updateScoreAndTime();
	}

	void updateScoreAndTime()
	{
		PlayerOneScore.text = "Score : " + Playercontrollers[0].PlayerScore.ToString();
		PlayerOneTime.text = "Time : " + Playercontrollers[0].TimeLeft.ToString();
		PlayerTwoScore.text = "Score : " + Playercontrollers[1].PlayerScore.ToString();
		PlayerTwoTime.text = "Time : " + Playercontrollers[1].TimeLeft.ToString();
	}
}
