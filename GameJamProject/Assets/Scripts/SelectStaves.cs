using UnityEngine;
using System.Collections;

public class SelectStaves : MonoBehaviour {

	Event eve;
	Vector3 mousePos;

	[SerializeField]
	bool isSelecting;

	void Start(){
		isSelecting = false;
	}

	void Update (){

		if (Input.GetMouseButton(0)) {
			eve = Event.current;
			mousePos = eve.mousePosition;
			
			this.gameObject.transform.position = (mousePos);
			ConsoleMousePos ();
		} 
	}

	void ConsoleMousePos(){
		Debug.Log ("Mouse Pressed");
	}

}
