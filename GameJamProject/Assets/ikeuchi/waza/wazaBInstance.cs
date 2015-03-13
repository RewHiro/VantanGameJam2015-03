using UnityEngine;
using System.Collections;

public class wazaBInstance : MonoBehaviour {

	[SerializeField]
	private GameObject Prefab = null;

	public float Posx = 0.0f;
	public float Posy = 0.0f;

	int countTime = 0;

	bool onOff = false;
	bool rightLeft = false;

	public const float tamaSize = 0.5f;

	const float SPEED = 0.7f;
	const float STOPER = 6.0f;

	// Use this for initialization
	void Start () {
	
	}

	public void SetBool(){
		onOff = true;
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKeyDown (KeyCode.E)) {
		//	onOff = true;
		//}

		if (onOff == true) {
			countTime++;
			if (countTime < 120) {
				Posy = 3.0f;
			}
			else if(countTime >= 120 && countTime < 730){
				if(rightLeft == false){
					Posx -= SPEED;
				}
				else{
					Posx += SPEED;
				}

				if (Posx < -STOPER){
					rightLeft = true;
					Posx = -6.0f;
					Posy = 2.0f;
				}
				if (Posx > STOPER){
					rightLeft = false;
					Posx = 6.0f;
					Posy = 3.0f;
				}

				for(int i = 0; i < 50; i++){
					var clone = (GameObject)Instantiate (Prefab);
					clone.transform.position = new Vector3 (Posx, Posy, 0.0f);
					clone.transform.localScale = new Vector3 (tamaSize, tamaSize, tamaSize);
					clone.transform.SetParent (this.transform);
				}
			}
			else{
				onOff = false;
				countTime = 0;
				Posx = 0.0f;
			}
		}
	}
}
