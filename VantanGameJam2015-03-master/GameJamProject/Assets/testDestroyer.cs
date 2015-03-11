using UnityEngine;
using System.Collections;

public class testDestroyer : MonoBehaviour {

	[SerializeField,Range(0.0f,10.0f)]
	private float DiiiiingTime = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.S)) {
			Destroy(GameObject.Find ("Cube(Clone)"));
		}
//		if (Input.GetKeyDown (KeyCode.S)) {
//			Destroy(gameObject,DiiiiingTime);
			//Destroy(this);
//		}

	}
}
