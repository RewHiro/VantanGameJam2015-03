using UnityEngine;
using System.Collections;

public class wazaAInstance : MonoBehaviour {

	[SerializeField]
	private GameObject Prefab = null;
	
	public const float Posx = 0.0f;
	public const float Posy = 4.0f;

	public float tamaSize = 0.0f;

	public int counter = 0;
	public int countTime = 0;
	public bool onOff = false;


    public void UseSpecialSkill()
    {
        onOff = true;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			//Posx = GameObject.Find ("BulletRoot").GetComponent<typeMode> ().Posx;
			//Posy = GameObject.Find ("BulletRoot").GetComponent<typeMode> ().Posy;
			onOff = true;
			/*
			for (int i = 0; i < 100; i++) {
				tamaSize = Random.Range (0.5f, 1.0f);
				//Posx = Random.Range (0.5f, 1.0f);
				//Posy = Random.Range (0.5f, 1.0f);
				var clone = (GameObject)Instantiate (Prefab);
				clone.transform.position = new Vector3 (Posx, Posy, 0.0f);
				clone.transform.localScale = new Vector3 (tamaSize, tamaSize, tamaSize);
				clone.transform.SetParent (this.transform);
			}
			*/
		}

		if (onOff == true) {
			if(countTime % 10 == 0){
				for (int i = 0; i < 100; i++) {
					tamaSize = Random.Range (0.5f, 1.0f);
					//Posx = Random.Range (0.5f, 1.0f);
					//Posy = Random.Range (0.5f, 1.0f);
					var clone = (GameObject)Instantiate (Prefab);
					clone.transform.position = new Vector3 (Posx, Posy, 0.0f);
					clone.transform.localScale = new Vector3 (tamaSize, tamaSize, tamaSize);
					clone.transform.SetParent (this.transform);
				}
				counter++;
			}
			countTime++;
			if(counter > 10){
				onOff = false;
				counter = 0;
				countTime = 0;
			}
		}
	}
}
