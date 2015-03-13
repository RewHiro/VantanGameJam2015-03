using UnityEngine;
using System.Collections;

public class wazaBmove : MonoBehaviour {

	float kakudo = 0.0f;
	float kasoku = 0.0f;
	
	int countTime = 0;
	
	public const float ATTAKU = 5.0f;

	// Use this for initialization
	void Start () {
		kakudo = Random.Range (0.0f, 6.28f);
	}
	
	// Update is called once per frame
	void Update () {
		kasoku += 0.01f;
		transform.Translate (new Vector3 (Mathf.Cos(kakudo) * kasoku,
		                                  Mathf.Sin(kakudo) * kasoku,
		                                  0.0f));
		if (countTime > 60) {
			Destroy(gameObject);
		}

		countTime++;
	}
}
