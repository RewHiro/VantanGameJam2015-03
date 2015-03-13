using UnityEngine;
using System.Collections;

public class BulletCmove : MonoBehaviour {

	GameObject enemy = null;
	float kakudo = 0;
	float kasoku = 0;
	
	public int countTime{ get; private set;}

	float damageSum = 0.0f;
	float tamaNum = 0.0f;
	public float ATTAKU = 5.0f / 10.0f;



	// Use this for initialization
	void Start () {
		tamaNum = GameObject.Find("BulletRootC").GetComponent<BulletCInstance>().tamaMax;
		var damage = FindObjectOfType (typeof(StageInformation)) as StageInformation;
		damageSum = damage.nowStage * 5.0f;
		//Debug.Log (damageSum);
		ATTAKU = damageSum / tamaNum;

		countTime = 0;
		kakudo = Random.Range (-0.3f, 1.8f);
		//		enemy = GameObject.Find ("enemy");
	}
	
	// Update is called once per frame
	void Update () {
		countTime++;

		kasoku += 0.02f;

		transform.Translate (new Vector3 (Mathf.Cos (kakudo) * kasoku,
		                                  Mathf.Sin (kakudo) * kasoku,
		                                  0.0f));

		if (countTime > 60) {
			Destroy(gameObject);
		}

	}
}
