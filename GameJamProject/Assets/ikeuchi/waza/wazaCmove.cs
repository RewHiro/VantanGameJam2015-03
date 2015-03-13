using UnityEngine;
using System.Collections;

public class wazaCmove : MonoBehaviour {

	GameObject enemy = null;

	float kakudo = 0.0f;
	float kasoku = 0.05f;

	int countTime = 0;

	const float HABA = 0.1f;

	float damageSum = 0.0f;
	public float ATTAKU = 0.0f; //300 * ? = 1100

	[SerializeField]
	private float turningTime = 1.0f;
	// Use this for initialization
	void Start () {
		ATTAKU = damageSum / 3.66666666f;

		var enemylist = GameObject.FindGameObjectsWithTag("enemy");
		if (enemylist.Length <= 0) {

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
		} else if (countTime == 60) {
			if (enemy != null) {
				//	kakudo = Mathf.Atan2 (enemy.transform.position.y - transform.position.y,
				//                     enemy.transform.position.x - transform.position.x);

				iTween.MoveTo (gameObject, iTween.Hash ("position", enemy.transform.position));

			}
		} else if (countTime > 60 && countTime <= 120) {
			if (turningTime > 1.0f)
				turningTime -= 1; 
			turningTime += Time.deltaTime;
			transform.localRotation = Quaternion.Euler( new Vector3 (0.0f, 0.0f, 180 / turningTime));
		}
        else if (countTime > 120) {

			Destroy(gameObject);
		}

		countTime++;



		//if (kasoku < 5.0f) {
			//kasoku += 0.05f;
		//}
		//kakudo += 0.05f;
	}
}
