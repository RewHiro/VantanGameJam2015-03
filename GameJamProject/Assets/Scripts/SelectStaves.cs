using UnityEngine;
using System.Collections;

public class SelectStaves : MonoBehaviour {

	Event eve;
	Vector3 mousePos;

	[SerializeField]
	bool isSelecting;

	void Start(){
		isSelecting = false;
		this.gameObject.SetActive (false);
	}

	void Update(){
		eve = Event.current;
		mousePos = eve.mousePosition;
		this.gameObject.transform.position = (mousePos);
		if (Input.GetMouseButtonDown(0)) {
			isSelecting = true;
			this.gameObject.SetActive (true);
		} 
		else if(Input.GetMouseButtonUp (0)){
			isSelecting = false;
			this.gameObject.SetActive (false);
		}
	}
}
