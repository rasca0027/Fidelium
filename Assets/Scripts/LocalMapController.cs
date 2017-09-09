using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalMapController : MonoBehaviour {

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
				if (hit.collider.CompareTag ("Church")) {
					Debug.Log ("hit church");
					ZoomInChurch (1);
				}

			}
		}
	}

	void ZoomInChurch(int cityID) {
		if (cityID == 1) {
			Vector3 goal = GameObject.Find ("church_bg_001").transform.position;
			Vector3 OldPos = Camera.main.transform.position;
			Camera.main.transform.position = new Vector3 (OldPos.x, goal.y, OldPos.z);
		}
	}
}
