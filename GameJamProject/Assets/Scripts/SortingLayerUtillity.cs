using UnityEngine;
using System.Collections;

public class SortingLayerUtillity : MonoBehaviour {

    [SerializeField]
    GameObject backGround = null;

	// Use this for initialization
	void Start () {
    backGround.GetComponent<MeshRenderer>().sortingLayerName = "backGround";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
