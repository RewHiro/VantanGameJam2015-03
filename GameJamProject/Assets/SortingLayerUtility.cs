using UnityEngine;
using System.Collections;

public class SortingLayerUtility : MonoBehaviour {

	[SerializeField]
	GameObject player = null;

	// Use this for initialization
	void Start () {
		player.GetComponent<MeshRenderer>().sortingLayerName = "Player";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
