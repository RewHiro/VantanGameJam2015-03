using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SoulCounter : MonoBehaviour {

	Text text;

	[SerializeField]
	GameObject player;

	[SerializeField]
	int soul_count;

	void Start(){
		text = GetComponent<Text> ();
		soul_count = player.GetComponent<PlayerStats> ().ReturnSouls ();
	}

	void Update(){
		text.text = "Souls: " + soul_count.ToString ();
	}

	public void UpdateText(){
		soul_count = player.GetComponent<PlayerStats> ().ReturnSouls ();
	}
}
