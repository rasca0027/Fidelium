using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour {

	public enum GameStates
	{
		SETUP,
		START,
		PLAYERTURN,
		GAMETURN,
		LOSS,
		WIN
	}


	public List<List<int>> coolDownList;

	private GameStates currentState;

	// Use this for initialization
	void Start ()
	{
		currentState = GameStates.START;
		coolDownList = new List<List<int>>();
	}

	// Update is called once per frame
	void Update ()
	{
		
		switch (currentState)
		{
			case (GameStates.START):
				//populate all cities and initialize base follower population
				PopulateCities();
				//update global display of followers and loyalty


				//switching to first player turn
				currentState = GameStates.PLAYERTURN;
				break;

			case (GameStates.PLAYERTURN):
				//Service.playerScript.Update();
				//Service.moneyManager.Update();
				break;

			case (GameStates.GAMETURN):

				//Service.actionManager.Update();
				//UpdateIncome();
				//Service.playerScript.RegenerateActionPoints();
				//gameObject.GetComponent<MenuManagerScript>().UpdateGlobalFollowerDisplay();
				//gameObject.GetComponent<MenuManagerScript>().UpdateGlobalLoyaltyDisplay();
				//gameObject.GetComponent<MenuManagerScript>().UpdateLocalDisplay();
				//Service.moneyManager.Update();
				//UpdateMenu();
				currentState = GameStates.PLAYERTURN;
				break;
			case (GameStates.WIN):
				break;
			case (GameStates.LOSS):
				break;
		}

	}

	void PopulateCities() {

		Debug.Log ("generate city");
	}

}