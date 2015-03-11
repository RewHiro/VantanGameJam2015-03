using UnityEngine;
using System.Collections;

public class testInstance : MonoBehaviour {


	[SerializeField]
	private GameObject Prefab = null;
	const float Posx = -2.0f;
	const float Posy = 0.0f;

	public int type{ get; private set;}

	// Use this for initialization
	void Start () {
		type = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.A)) {
			if (type == 0) {
				var clone = (GameObject)Instantiate (Prefab);
				clone.transform.position = new Vector3 (Posx, Posy, 0.0f);
				clone.transform.SetParent (this.transform);
			}
			else if(type == 1){
				for (int i = 0; i < 4; i++) {
					var clone = (GameObject)Instantiate (Prefab);
					clone.transform.position = new Vector3 (Posx, Posy, 0.0f);
					clone.transform.SetParent (this.transform);
				}
			}
		}

		if (Input.GetKeyDown (KeyCode.W)) {
			type++;
			if(type > 1){type = 0;}
		}

	}
}
