using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "enemy") { 
			Destroy(gameObject);
            col.gameObject.GetComponent<EnemyLifeMob>().Damage(1);
		}
	}

	/*
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "enemy") { 
			Destroy(gameObject);
		}
	}
	*/
}
