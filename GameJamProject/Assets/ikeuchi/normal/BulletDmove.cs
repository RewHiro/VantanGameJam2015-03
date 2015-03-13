using UnityEngine;
using System.Collections;

public class BulletDmove : MonoBehaviour {

	GameObject enemy = null;
	float kakudo = 0;
	float kasoku = 0;

	int countTime = 0;

	float damageSum = 0;
	public float ATTAKU = 5.0f / 5.0f;

	// Use this for initialization
	void Start () {
		var damage = FindObjectOfType (typeof(StageInformation)) as StageInformation;
		damageSum = damage.nowStage * 5.0f;
		ATTAKU = damageSum / 5.0f;

		var enemylist = GameObject.FindGameObjectsWithTag("enemy");
		if (enemylist.Length <= 0) {
			enemy.transform.position = new Vector3(Random.Range(-3.0f,5.0f),
			                                       Random.Range(1.0f,8.0f),
			                                       0.0f);
			//Destroy(gameObject);
			return;
		}
		enemy = enemylist [Random .Range(0, enemylist.Length)];
		kakudo = Mathf.Atan2 (enemy.transform.position.y - transform.position.y,
		                      enemy.transform.position.x - transform.position.x);
	}
	
	// Update is called once per frame
	void Update () {
		countTime++;
		if (countTime > 60) {
			Destroy(gameObject);
		}
		kasoku += 0.02f;
		
		transform.Translate (new Vector3 (Mathf.Cos (kakudo) * kasoku,
		                                  Mathf.Sin (kakudo) * kasoku,
		                                  (Mathf.Cos (kakudo) + Mathf.Sin (kakudo)) * kasoku));
	}
}
