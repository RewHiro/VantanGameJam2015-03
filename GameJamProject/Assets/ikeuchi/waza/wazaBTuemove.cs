using UnityEngine;
using System.Collections;

public class wazaBTuemove : MonoBehaviour {

	int countTime = 0;
	
	const int DELETE_COUNT = 310;

	const float SPEED = 0.7f;
	const float STOPER = 6.0f;

	bool rightLeft = false;

	const int ATTAKU_START_TIME = 120;
	const int SKILL_TIME = 430;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (countTime < ATTAKU_START_TIME) {
			if (transform.position.y > 3.0f) {
				transform.Translate (new Vector3 (0.0f, -0.1f, 0.0f));
			}
			else if(countTime > 90){
				if(transform.rotation.z < 90){
					transform.Rotate(0,0,3);
				}
			}
		}
		else if (countTime >= ATTAKU_START_TIME && countTime < SKILL_TIME) {
			if(rightLeft == false){
				transform.Translate (new Vector3 (0.0f, SPEED, 0.0f));
			}
			else{
				transform.Translate (new Vector3 (0.0f, SPEED, 0.0f));
			}

			if (transform.position.x > STOPER){
				rightLeft = true;
				transform.position = new Vector3(6.0f,2.0f,0.0f);
				//transform.localRotation = Quaternion.Euler(0,0,90);
				transform.eulerAngles = new Vector3(0.0f,0.0f,90.0f);
			}
			if (transform.position.x < -STOPER){
				rightLeft = false;
				transform.position = new Vector3(-6.0f,3.0f,0.0f);
				//transform.localRotation = Quaternion.Euler(0,0,-90);
				transform.eulerAngles = new Vector3(0.0f,0.0f,270.0f);
			}
		}
		else {
			Destroy(gameObject);
			countTime = 0;
		}
		countTime++;
	}
}
