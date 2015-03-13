using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour {

	[SerializeField]
	GameObject button_1 = null;
	[SerializeField]
	GameObject button_2 = null;
	[SerializeField]
	GameObject button_3 = null;
	[SerializeField]
	GameObject button_4 = null;

	ButtonSelected button1;
	ButtonSelected button2;
	ButtonSelected button3;
	ButtonSelected button4;

	// Use this for initialization
	void Start () {
		button1 = button_1.GetComponent<ButtonSelected> ();
		button2 = button_2.GetComponent<ButtonSelected> ();
		button3 = button_3.GetComponent<ButtonSelected> ();
		button4 = button_4.GetComponent<ButtonSelected> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ActivateButton_1(){
		button1.Activate ();
		button2.Deactivate ();
		button3.Deactivate ();
		button4.Deactivate ();
	}

	public void ActivateButton_2(){
		button1.Deactivate ();
		button2.Activate ();
		button3.Deactivate ();
		button4.Deactivate ();
	}

	public void ActivateButton_3(){
		button1.Deactivate ();
		button2.Deactivate ();
		button3.Activate ();
		button4.Deactivate ();
	}

	public void ActivateButton_4(){
		button1.Deactivate ();
		button2.Deactivate ();
		button3.Deactivate ();
		button4.Activate ();
	}

	public void DeactivateAll(){
		button1.Deactivate ();
		button2.Deactivate ();
		button3.Deactivate ();
		button4.Deactivate ();
	}

}
