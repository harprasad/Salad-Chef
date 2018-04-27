using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerTableController : MonoBehaviour {

	public List<GameObject> Container;
	public List<string> RequestedCombination;
	public GameObject Pickup;
	GameObject[] PickupPoints;
	public float WaitTime;
	public float StartTime;
	float burnrate = 1;
	bool delivered = false;
	// Use this for initialization
	void Start () {
		PickupPoints = GameObject.FindGameObjectsWithTag(Constants.PICKUP_SPAWN_POINT_TAGS);
	}
	
	// Update is called once per frame
	void Update () {
		WaitForFood();
	}

	/// <summary>
	/// This function runs every frame and reduces Waiting time
	/// Incase of TIMEOUT both the players are penalised
	/// </summmary>
	void WaitForFood()
	{
		if(delivered == true){
			Destroy(gameObject);
			return;
		}
		WaitTime -= (Time.deltaTime * burnrate);
		if(WaitTime <= 0){
			GameObject[] Players =  GameObject.FindGameObjectsWithTag("Player");
			foreach (var player in Players)
			{
				player.GetComponent<PlayerController>().PlayerScore += Constants.PENALTY_POINTS;
			}
			Destroy(gameObject);
		}
	}


	/// <summary>
	/// This function is used to calculate FEEDBACK SCORE incase of 
	/// Wrong Delivery A Negative score is returned .This function is called by players hence its public
	/// </summmary>
	public int FeedBack(){
		int count = RequestedCombination.Count;
		int match = 0 ;
		foreach (var item in Container)
		{
			if(RequestedCombination.Contains(item.name)){
				match++;
			}
		}
		float completionRate = (WaitTime / StartTime ) * 100;
		if(count == match  && completionRate > Constants.GOOD_PERCENT){
			delivered = true;
			//Spawn Pickups
			return Constants.REWARD_POINTS;
		}else if(count == match){
			delivered = true;
			return Constants.REWARD_POINTS;
		}else{
			burnrate = 2;
			return Constants.PENALTY_POINTS;
		}
	}



	
}
