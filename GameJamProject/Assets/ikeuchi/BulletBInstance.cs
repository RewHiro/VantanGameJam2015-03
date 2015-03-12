<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

public class BulletBInstance : MonoBehaviour {
	
	[SerializeField]
	private GameObject Prefab = null;
	
	public float Posx = 0.0f;
	public float Posy = 0.0f;

	public float exp = 0.0f;

	public int typeShot = 0;

	//const int TAMAMAX = 4;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) {
			typeShot = GameObject.Find("BulletRoot").GetComponent<typeMode>().type;

			if (typeShot == 1) {
				Posx = GameObject.Find("BulletRoot").GetComponent<typeMode>().Posx;
				Posy = GameObject.Find("BulletRoot").GetComponent<typeMode>().Posy;

				exp += 0.01f;

				float tamaMax = exp * 0.1f + 1.0f;
				if(tamaMax > 50){ tamaMax = 0.0f; }

				for (float i = 0.0f; i < tamaMax; i++) {
					var clone = (GameObject)Instantiate (Prefab);
					clone.transform.position = new Vector3 (Posx, Posy, 0.0f);
					clone.transform.SetParent (this.transform);
				}
			}
		}
	}
}
=======
﻿using UnityEngine;
using System.Collections;

public class BulletBInstance : MonoBehaviour {
	
	[SerializeField]
	private GameObject Prefab = null;
	
	public float Posx = 0.0f;
	public float Posy = 0.0f;

	public float exp = 0.0f;

	public int typeShot = 0;

	//const int TAMAMAX = 4;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) {
			typeShot = GameObject.Find("BulletRoot").GetComponent<typeMode>().type;

			if (typeShot == 1) {
				Posx = GameObject.Find("BulletRoot").GetComponent<typeMode>().Posx;
				Posy = GameObject.Find("BulletRoot").GetComponent<typeMode>().Posy;

				exp += 0.01f;

				float tamaMax = exp * 0.1f + 1.0f;
				if(tamaMax > 50){ tamaMax = 0.0f; }

				for (float i = 0.0f; i < tamaMax; i++) {
					var clone = (GameObject)Instantiate (Prefab);
					clone.transform.position = new Vector3 (Posx, Posy, 0.0f);
					clone.transform.SetParent (this.transform);
				}
			}
		}
	}
}
>>>>>>> 8bd91e946a372622525b6572039c66b8cf95a2a2
