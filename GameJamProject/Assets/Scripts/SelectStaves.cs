using UnityEngine;
using System.Collections;

public class SelectStaves : MonoBehaviour {
	
	Vector2 mousePos;

	public GameObject st1;
	public GameObject st2;
	public GameObject st3;
	public GameObject st4;
	public GameObject st5;
	public GameObject st6;

	[SerializeField]
	bool isSelecting;
	int frameCount;

	void Start(){
		isSelecting = false;
		frameCount = 0;
		st1.SetActive(false);
		st2.SetActive(false);
		st3.SetActive(false);
		st4.SetActive(false);
		st5.SetActive(false);
		st6.SetActive(false);
	}

	void Update (){
		if(!isSelecting)
		mousePos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
		if (Input.GetMouseButtonDown (0)) {
			this.gameObject.transform.position = (mousePos);
			st1.SetActive(true);
			st2.SetActive(true);
			st3.SetActive(true);
			st4.SetActive(true);
			st5.SetActive(true);
			st6.SetActive(true);
			isSelecting=true;
		} 
		else if(Input.GetMouseButtonUp (0)){
			st1.SetActive(false);
			st2.SetActive(false);
			st3.SetActive(false);
			st4.SetActive(false);
			st5.SetActive(false);
			st6.SetActive(false);
			isSelecting=false;
		}
	}
}
