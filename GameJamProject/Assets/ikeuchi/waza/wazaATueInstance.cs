using UnityEngine;
using System.Collections;

public class wazaATueInstance : MonoBehaviour {

	[SerializeField]
	private GameObject Prefab = null;
	
	public const float Posx = 0.0f;
	public const float Posy = 4.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			var clone = (GameObject)Instantiate (Prefab);
			clone.transform.position = new Vector3 (0.0f, 10.0f, 0.0f);
			clone.transform.localScale = new Vector3 (5.0f, 5.0f, 5.0f);
			clone.transform.SetParent (this.transform);
		}
	}
}
