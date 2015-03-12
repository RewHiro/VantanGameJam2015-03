using UnityEngine;
using System.Collections;

public class wazaBmove : MonoBehaviour {

	float kakudo = 0.0f;
	float kasoku = 0.0f;
	
	int countTime = 0;
	
	public const float ATTAKU = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (countTime > 60) {
			Destroy(gameObject);
		}

		countTime++;
	}
}
