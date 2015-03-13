﻿using UnityEngine;
using System.Collections;

public class BulletCInstance : MonoBehaviour {

	[SerializeField]
	private GameObject Prefab = null;

	[SerializeField]
	PlayerAttacker player = null;
	
	public float Posx = 0.0f;
	public float Posy = 0.0f;
	
	public float exp = 0.0f;
	
	public int typeShot = 0;

	public float tamaMax = 0.0f;

	public const float EXP_UP = 0.01f;
	public const float BAIRITU = 0.2f;
	public const float TAMA_SIZE = 0.2f;
	public const float TAMA_MAX = 50.0f;
	public const float SYOKICHI = 10.0f;
	
	// Use this for initialization
	void Start () {
		exp = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (player.isAttack) {
			var typeRoot = GameObject.Find("BulletRoot").GetComponent<typeMode>();
			typeShot = typeRoot.type;
			if (typeShot == 2) {
				Posx = typeRoot.Posx;
				Posy = typeRoot.Posy;
				
				exp += EXP_UP;

				float tamaMax = exp * BAIRITU + SYOKICHI;
				if(tamaMax > TAMA_MAX){ tamaMax = TAMA_MAX; }

				for(int i = 0; i < tamaMax; i++){
					var clone = (GameObject)Instantiate (Prefab);
					clone.transform.position = new Vector3 (Posx, Posy, 0.0f);
					clone.transform.localScale = new Vector3 (TAMA_SIZE, TAMA_SIZE, TAMA_SIZE);
					clone.transform.SetParent (this.transform);
				}
			}
		}
	}
}
