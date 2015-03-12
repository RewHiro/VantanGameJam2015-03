using UnityEngine;
using System.Collections;

public class BulletAInstance : MonoBehaviour {

	
	
	[SerializeField]
	private GameObject Prefab = null;

    [SerializeField]
    PlayerAttacker player = null;

	public float Posx = 0.0f;
	public float Posy = 0.0f;

	public float exp = 0.0f;

	public int typeShot = 0;

	public const float EXP_UP = 0.01f;
	public const float BAIRITU = 0.1f;
	public const float SYOKI_SIZE = 0.5f;

	// Use this for initialization
	void Start () {
		exp = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (player.isAttack)
        {
			var typeRoot = GameObject.Find("BulletRoot").GetComponent<typeMode>();
			typeShot = typeRoot.type;
			if (typeShot == 0) {
				Posx = typeRoot.Posx;
				Posy = typeRoot.Posy;

				exp += EXP_UP;

				//Debug.Log(exp);
				float tamaSize = exp * BAIRITU + SYOKI_SIZE;

				var clone = (GameObject)Instantiate (Prefab);
				clone.transform.position = new Vector3 (Posx, Posy, 0.0f);
				clone.transform.localScale = new Vector3 (tamaSize, tamaSize, tamaSize);
				clone.transform.SetParent (this.transform);
			}
		}
	}
}
