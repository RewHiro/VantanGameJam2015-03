﻿using UnityEngine;
using System.Collections;

public class wazaAmove : MonoBehaviour {

	//GameObject enemy = null;
	float kakudo = 0.0f;
	float kasoku = 0.0f;

	int countTime = 0;

	public const float ATTAKU = 5.0f;

	// Use this for initialization
	void Start () {
		//var enemylist = GameObject.FindGameObjectsWithTag("enemy");
		//enemy = enemylist [Random .Range(0, enemylist.Length)];
		kakudo = Random.Range (-0.5f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		countTime++;
		kasoku += 0.01f;
		if (countTime > 20) {
			kasoku += 0.1f;
		}
		transform.Translate (new Vector3 (Mathf.Cos(kakudo) * kasoku,
		                                  Mathf.Sin(kakudo) * kasoku,
		                                  0.0f));
		if (countTime > 60) {
			Destroy(gameObject);
		}
	}
}
