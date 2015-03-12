using UnityEngine;
using System.Collections;

public class SortingLayerUtility : MonoBehaviour {

	//[SerializeField]
	//GameObject enemy = null;
	[SerializeField]
	GameObject door = null;
	[SerializeField]
	GameObject skill = null;
	[SerializeField]
	GameObject player = null;

	// Use this for initialization
	void Start () {
		//enemy.GetComponent<MeshRenderer>().sortingLayerName = "Enemy";
		door.GetComponent<MeshRenderer>().sortingLayerName = "Door";
		skill.GetComponent<MeshRenderer>().sortingLayerName = "Skill";
		player.GetComponent<MeshRenderer>().sortingLayerName = "Player";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
