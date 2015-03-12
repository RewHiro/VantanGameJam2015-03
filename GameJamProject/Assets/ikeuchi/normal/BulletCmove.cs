using UnityEngine;
using System.Collections;

public class BulletCmove : MonoBehaviour {

	GameObject enemy = null;
	float kakudo = 0;
	float kasoku = 0;
	
	public int countTime{ get; private set;}
	
	// Use this for initialization
	void Start () {
		countTime = 0;
		kakudo = Random.Range (0.0f, 2.5f);
		//		enemy = GameObject.Find ("enemy");
	}
	
	// Update is called once per frame
	void Update () {
		countTime++;

		kasoku += 0.02f;

		transform.Translate (new Vector3 (Mathf.Cos (kakudo) * kasoku,
		                                  Mathf.Sin (kakudo) * kasoku,
		                                  0.0f));
	}
}
