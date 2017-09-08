using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalMapController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
			if (hit) {
				Debug.Log (hit.collider.gameObject.name);
				if (hit.collider.CompareTag ("City")) {
					Debug.Log ("hit city");
					ZoomInLocal (1);
				}

			}
		}
	}


	void ZoomInLocal(int cityID) {
		if (cityID == 1) {
			float GoalX = GameObject.Find ("temp").transform.position.x;
			Vector3 OldPos = Camera.main.transform.position;
			Camera.main.transform.position = new Vector3 (GoalX, OldPos.y, OldPos.z);
		}
	}
}
