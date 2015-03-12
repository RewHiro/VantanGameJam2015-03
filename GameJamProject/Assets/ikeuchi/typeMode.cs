<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

public class typeMode : MonoBehaviour {

	public float Posx{ get; private set;}
	public float Posy{ get; private set;}
	
	public int type{ get; private set;}

	// Use this for initialization
	void Start () {
		type = 0;
		Posx = 0.0f;
		Posy = -1.0f;
	}
	
	// Update is called once per frame
	void Update () {	
		if (Input.GetKeyDown (KeyCode.W)) {
			type++;

			if(type > 1){
				//Debug.Log (type);
				type = 0;
			}

			//Debug.Log(type);
		}

	}
}
=======
﻿using UnityEngine;
using System.Collections;

public class typeMode : MonoBehaviour {

	public float Posx{ get; private set;}
	public float Posy{ get; private set;}
	
	public int type{ get; private set;}

	// Use this for initialization
	void Start () {
		type = 0;
		Posx = 0.0f;
		Posy = -1.0f;
	}
	
	// Update is called once per frame
	void Update () {	
		if (Input.GetKeyDown (KeyCode.W)) {
			type++;

			if(type > 1){
				//Debug.Log (type);
				type = 0;
			}

			//Debug.Log(type);
		}

	}
}
>>>>>>> 8bd91e946a372622525b6572039c66b8cf95a2a2
