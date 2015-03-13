using UnityEngine;
using System.Collections;

public class wazaCmove : MonoBehaviour {

	GameObject enemy = null;

	float kakudo = 0.0f;
	float kasoku = 0.05f;

	int countTime = 0;

	const float HABA = 0.1f;

	// Use this for initialization
	void Start () {
		var enemylist = GameObject.FindGameObjectsWithTag("enemy");
		if (enemylist.Length <= 0) {
			enemy.transform.position = new Vector3 (Random.Range (-3.0f, 5.0f),
			                                       Random.Range (1.0f, 8.0f),
			                                       0.0f);
			//Destroy(gameObject);
			//enemy = enemylist [Random .Range (0, enemylist.Length)];
			return;
		}
		enemy = enemylist [Random .Range (0, enemylist.Length)];
		//kakudo = Random.Range (-3.14f, 0.0f);
		//enemy = enemylist [Random .Range(0, enemylist.Length)];
	}
	
	// Update is called once per frame
	void Update () {
		if (countTime == 0) {
			kakudo = Random.Range (0.0f, 6.28f);
		} else if (countTime < 30) {
			transform.Translate (new Vector3 (Mathf.Cos (kakudo) * kasoku,
			                                 Mathf.Sin (kakudo) * kasoku,
			                                 0.0f));
		}
		else if (countTime == 30) {
			if (enemy != null) {
				kakudo = Mathf.Atan2 (enemy.transform.position.y - transform.position.y,
			                     enemy.transform.position.x - transform.position.x);
			}
		}
		else if (countTime > 30 && countTime < 60) {

		}
		else if (countTime >= 60 && countTime < 120) {
			kasoku += 0.05f;
			transform.Translate (new Vector3 (Mathf.Cos (kakudo) * kasoku,
			                                  Mathf.Sin (kakudo) * kasoku,
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
