using UnityEngine;
using System.Collections;

public class BulletBmove : MonoBehaviour {

	GameObject enemy = null;
	float kakudo = 0;
	float kasoku = 0;
	int tuisekiTime = 0;

	// Use this for initialization
	void Start () {
		var enemylist = GameObject.FindGameObjectsWithTag("enemy");
		if (enemylist.Length <= 0) {
			enemy.transform.position = new Vector3(Random.Range(-3,3),
			                                       Random.Range(1,3),
			                                       0.0f);
			return;
		}
		enemy = enemylist [Random .Range(0, enemylist.Length)];
		kakudo = Random.Range (0.0f, 6.28f);
	}
	
	// Update is called once per frame
	void Update () {
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
