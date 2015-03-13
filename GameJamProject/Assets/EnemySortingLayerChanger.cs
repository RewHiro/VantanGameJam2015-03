using UnityEngine;
using System.Collections;

public class EnemySortingLayerChanger : MonoBehaviour {

  GameObject gate = null;

  [SerializeField]
  string sortingLayerName = string.Empty;

  MeshRenderer meshRenderer = null;

	// Use this for initialization
	void Start () {
    gate = GameObject.Find("EnemyGate");
    meshRenderer = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
    if (meshRenderer.sortingLayerName == sortingLayerName) return;

    if (gate.transform.position.z >= transform.position.z)
    {
      meshRenderer.sortingLayerName = sortingLayerName;
    }
	}
}
