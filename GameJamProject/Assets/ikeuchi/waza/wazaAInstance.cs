using UnityEngine;
using System.Collections;

public class wazaAInstance : MonoBehaviour {

	[SerializeField]
	private GameObject Prefab = null;
	
	public const float Posx = -1.5f;
	public const float Posy = 1.5f;

	//public float tamaSize = 5.0f;

	//public int counter = 0;
	public int countTime = 0;
	public bool onOff = false;

	const int HASSHA_COUNT = 90;
	const int RENSHA = 5;
	const int COUNT = 400;
	const float SIZE = 0.5f;

	const int DELETE_COUNT = 310;

    public void UseSpecialSkill()
    {
        onOff = true;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKeyDown (KeyCode.Q)) {
			//Posx = GameObject.Find ("BulletRoot").GetComponent<typeMode> ().Posx;
			//Posy = GameObject.Find ("BulletRoot").GetComponent<typeMode> ().Posy;
			//onOff = true;
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
		//}

		if (onOff == true) {
			if(countTime > HASSHA_COUNT){
				//if(countTime % RENSHA == 0){
					//for (int i = 0; i < 10; i++) {
						//tamaSize = Random.Range (0.5f, 1.0f);
						//Posx = Random.Range (0.5f, 1.0f);
						//Posy = Random.Range (0.5f, 1.0f);
						var clone = (GameObject)Instantiate (Prefab);
						clone.transform.position = new Vector3 (Posx, Posy, 0.0f);
						clone.transform.localScale = new Vector3 (SIZE, SIZE, SIZE);
						clone.transform.SetParent (this.transform);
					//}
					//counter++;
				//}
			}
			countTime++;
			//if(counter > COUNT){
			if(countTime > DELETE_COUNT){
				onOff = false;
				//counter = 0;
				countTime = 0;
			}
		}
	}
}
