using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonSelected : MonoBehaviour {

	Image image;

	bool isSelected;
	
	// Use this for initialization
	void Start () {
		image = GetComponent<Image> ();
		isSelected = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isSelected) {
			image.color = new Color (1.0f, 1.0f, 1.0f, 0.5f);
		} else {
			image.color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
		}
	}

	public void Activate(){
		isSelected = true;
	}

	public void Deactivate(){
		isSelected = false;
	}
}
