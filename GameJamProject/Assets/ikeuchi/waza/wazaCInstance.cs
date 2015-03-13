using UnityEngine;
using System.Collections;

public class wazaCInstance : MonoBehaviour {

	[SerializeField]
	private GameObject Prefab = null;
	
	public const float Posx = -1.5f;
	public const float Posy = 1.5f;

	public int countTime = 0;
	public bool onOff = false;
	
	const int HASSHA_COUNT = 90;
	const int RENSHA = 1;
	const int COUNT = 400;
	const float SIZE = 0.2f;
	
	const int DELETE_COUNT = 390;
	

	public void UseSpecialSkill()
	{
		onOff = true;
	}
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {	
		if (onOff == true) {
			if(countTime > HASSHA_COUNT && countTime % RENSHA == 0){
				//if(countTime % RENSHA == 0){
				//for(int i = 0; i < 100; i++){
					var clone = (GameObject)Instantiate (Prefab);
					clone.transform.position = new Vector3 (Posx, Posy, 0.0f);
					clone.transform.localScale = new Vector3 (SIZE, SIZE, SIZE);
					clone.transform.SetParent (this.transform);
				//}
				//}
			}

			countTime++;
			if(countTime > DELETE_COUNT){
				onOff = false;
				countTime = 0;
			}
		}
	}
}
