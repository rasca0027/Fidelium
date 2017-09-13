using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalMapController : MonoBehaviour {

	Vector3 oldCameraPos;

	// Use this for initialization
	void Start () {
		oldCameraPos = Camera.main.transform.position;
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
			float GoalX = GameObject.Find ("local_map_001").transform.position.x;
			Vector3 OldPos = Camera.main.transform.position;
			Camera.main.transform.position = new Vector3 (GoalX, OldPos.y, OldPos.z);
		}
	}

	public void BackBtnHandler () {

		Camera.main.transform.position = oldCameraPos;
	}
}
