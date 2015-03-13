using UnityEngine;
using System.Collections;

public class BulletBmove : MonoBehaviour {

	GameObject enemy = null;
	float kakudo = 0;
	float kasoku = 0;
	int tuisekiTime = 0;

	int deleteTime = 0;

	float damageSum = 0.0f;
	float tamaNum = 0.0f;
	public float ATTAKU = 5.0f / 2.0f;

	// Use this for initialization
	void Start () {
		tamaNum = GameObject.Find("BulletRootB").GetComponent<BulletBInstance>().tamaMax;
		var damage = FindObjectOfType (typeof(StageInformation)) as StageInformation;
		damageSum = damage.nowStage * 5.0f;
		//Debug.Log (damageSum);
		ATTAKU = damageSum / tamaNum;

		var enemylist = GameObject.FindGameObjectsWithTag("enemy");
		if (enemylist.Length <= 0) {
			enemy.transform.position = new Vector3(Random.Range(-3.0f,5.0f),
			                                       Random.Range(1.0f,8.0f),
			                                       0.0f);
			//Destroy(gameObject);
			return;
		}
		enemy = enemylist [Random .Range(0, enemylist.Length)];
		kakudo = Random.Range (0.0f, 6.28f);
	}
	
	// Update is called once per frame
	void Update () {
		tuisekiTime++;
		if (tuisekiTime > 20) {
			if (enemy != null) {
				kakudo = Mathf.Atan2 (enemy.transform.position.y - transform.position.y,
				                      enemy.transform.position.x - transform.position.x);
			}
		}
		kasoku += 0.01f;
		transform.Translate (new Vector3 (Mathf.Cos (kakudo) * kasoku,
		                                  Mathf.Sin (kakudo) * kasoku,
		                                  (Mathf.Cos (kakudo) + Mathf.Sin (kakudo)) * kasoku));

		if (tuisekiTime > 80) {
			Destroy(gameObject);
		}
	}
}
