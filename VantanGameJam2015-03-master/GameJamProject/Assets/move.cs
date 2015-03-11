using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	GameObject enemy = null;
	float kakudo = 0;
	float kasoku = 0;
	int tuisekiTime = 0;
	int typeShot = 0;

	// Use this for initialization
	void Start () {
		enemy = GameObject.Find ("enemy");
		kakudo = Random.Range (0.0f, 6.28f);
		typeShot = GameObject.Find("BulletRoot").GetComponent<testInstance>().type;
	}
	
	// Update is called once per frame
	void Update () {
		/*
		transform.position = Vector3.MoveTowards (transform.position,
		                                          new Vector3( 
		            enemy.transform.position.x, enemy.transform.position.y, enemy.transform.position.z)
		                                          , 0.5f);
		*/

		if (typeShot == 0) {
			kasoku += 0.01f;
			kakudo = Mathf.Atan2 (enemy.transform.position.y - transform.position.y,
			                      enemy.transform.position.x - transform.position.x);
			transform.Translate (new Vector3 (Mathf.Cos (kakudo) * kasoku,
			                                  Mathf.Sin (kakudo) * kasoku,
			                                  0.0f));
		} 
		else if (typeShot == 1) {
			tuisekiTime++;
			if (tuisekiTime > 20) {
				kakudo = Mathf.Atan2 (enemy.transform.position.y - transform.position.y,
			                      enemy.transform.position.x - transform.position.x);
			}
			kasoku += 0.01f;
			transform.Translate (new Vector3 (Mathf.Cos (kakudo) * kasoku,
		                                  Mathf.Sin (kakudo) * kasoku,
		                                  0.0f));
		}

	}
}
