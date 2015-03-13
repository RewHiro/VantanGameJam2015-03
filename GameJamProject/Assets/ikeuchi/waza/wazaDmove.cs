using UnityEngine;
using System.Collections;

public class wazaDmove : MonoBehaviour {

	GameObject enemy = null;
	
	float kakudo = 0.0f;
	float kasoku = 0.05f;
	
	int countTime = 0;
	
	const float HABA = 0.1f;
	
	float damageSum = 0.0f;
	public float ATTAKU = 0.0f; //300 * ? = 1100
	
	// Use this for initialization
	void Start () {
		ATTAKU = damageSum / 3.66666666f;

		//kakudo = Random.Range (-3.14f, 0.0f);
		//enemy = enemylist [Random .Range(0, enemylist.Length)];
		kakudo = Random.Range (0.0f, 6.28f);
	}
	
	// Update is called once per frame
	void Update () {
		if (countTime >= 0 && countTime < 480) {
			kakudo += 0.05f;
			kasoku += 0.03f;
			transform.Translate (new Vector3 (Mathf.Cos (kakudo) * HABA * kasoku,
			                                  Mathf.Sin (kakudo) * HABA / 5.0f * kasoku,
			                                  0.0f));
		}
		else {
			Destroy(gameObject);
		}
		
		countTime++;
		//if (kasoku < 5.0f) {
		//kasoku += 0.05f;
		//}
		//kakudo += 0.05f;
	}
}
