<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

public class moveEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3(Mathf.Sin( Time.time * 2 ) * 0.1f,
		                          	0,
		                            0 ));
	}
}
=======
﻿using UnityEngine;
using System.Collections;

public class moveEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3(Mathf.Sin( Time.time * 2 ) * 0.1f,
		                          	0,
		                            0 ));
	}
}
>>>>>>> 8bd91e946a372622525b6572039c66b8cf95a2a2
