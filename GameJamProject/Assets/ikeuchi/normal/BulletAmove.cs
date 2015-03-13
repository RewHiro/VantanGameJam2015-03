using UnityEngine;
using System.Collections;

public class BulletAmove : MonoBehaviour {

	GameObject enemy = null;
	float kakudo = 0;
	float kasoku = 0;

	int deleteTime = 0;

	public float ATTAKU = 5.0f;

	// Use this for initialization
	void Start () {
		var enemylist = GameObject.FindGameObjectsWithTag("enemy");
		if (enemylist.Length <= 0) {
			enemy.transform.position = new Vector3(Random.Range(-3.0f,5.0f),
			                                       Random.Range(1.0f,8.0f),
			                                       0.0f);
			//Destroy(gameObject);
			return;
		}
		enemy = enemylist [Random .Range(0, enemylist.Length)];
//		enemy = GameObject.Find ("enemy");
	}
	
	// Update is called once per frame
	void Update () {
		kasoku += 0.01f;
		if (enemy != null) {
			kakudo = Mathf.Atan2 (enemy.transform.position.y - transform.position.y,
		                      enemy.transform.position.x - transform.position.x);
		}
		transform.Translate (new Vector3 (Mathf.Cos (kakudo) * kasoku,
		                                  Mathf.Sin (kakudo) * kasoku,
		                                  0.0f));

		deleteTime++;
		if (deleteTime > 60) {
			Destroy(gameObject);
		}
	}
}
