using UnityEngine;
using System.Collections;

public class SortingLayerUtillity : MonoBehaviour {

    [SerializeField]
    GameObject door = null;

    [SerializeField]
    GameObject skill = null;

    [SerializeField]
    GameObject player = null;

	// Use this for initialization
	void Start () {
        door.GetComponent<SpriteRenderer>().sortingLayerName = "Door";
        skill.GetComponent<SpriteRenderer>().sortingLayerName = "Skill";
        player.GetComponent<SpriteRenderer>().sortingLayerName = "Player";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
