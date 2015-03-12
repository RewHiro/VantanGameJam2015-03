using UnityEngine;
using System.Collections;

public class HitD : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "enemy") { 
			//Destroy(gameObject);
			col.gameObject.GetComponent<EnemyLife>().Damage(1);
		}
	}
}
