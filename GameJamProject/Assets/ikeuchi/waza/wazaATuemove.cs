using UnityEngine;
using System.Collections;

public class wazaATuemove : MonoBehaviour {

	int countTime = 0;

	const int DELETE_COUNT = 310;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (countTime < DELETE_COUNT) {
			if(transform.position.y > 2.0f){
				transform.Translate(new Vector3(0.0f,-0.1f,0.0f));
			} 
		}
		else {
			Destroy(gameObject);
		}
		countTime++;
	}
}
