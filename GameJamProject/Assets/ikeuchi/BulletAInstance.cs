using UnityEngine;
using System.Collections;

public class BulletAInstance : MonoBehaviour {

	
	
	[SerializeField]
	private GameObject Prefab = null;

	public float Posx = 0.0f;
	public float Posy = 0.0f;

	public float exp = 0.0f;

	public int typeShot = 0;
	
	// Use this for initialization
	void Start () {
		exp = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) {
			typeShot = GameObject.Find("BulletRoot").GetComponent<typeMode>().type;
			if (typeShot == 0) {
				Posx = GameObject.Find("BulletRoot").GetComponent<typeMode>().Posx;
				Posy = GameObject.Find("BulletRoot").GetComponent<typeMode>().Posy;

				exp += 0.01f;

				//Debug.Log(exp);

				var clone = (GameObject)Instantiate (Prefab);
				clone.transform.position = new Vector3 (Posx, Posy, 0.0f);
				clone.transform.localScale = new Vector3 (exp * 0.1f + 0.5f, exp * 0.1f + 0.5f, exp * 0.1f + 0.5f);
				clone.transform.SetParent (this.transform);
			}
		}
	}
}
