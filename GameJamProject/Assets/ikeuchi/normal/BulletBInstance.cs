using UnityEngine;
using System.Collections;

public class BulletBInstance : MonoBehaviour {
	
	[SerializeField]
	private GameObject Prefab = null;

    [SerializeField]
    PlayerAttacker player = null;

	public float Posx = 0.0f;
	public float Posy = 0.0f;

	public float exp = 0.0f;

	public int typeShot = 0;

	public const float TAMA_MAX = 50.0f;
	public const float SYOKICHI = 1.0f;
	public const float SIZE = 3.0f;

	//const int TAMAMAX = 4;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (player.isAttack)
        {
			var typeRoot = GameObject.Find("BulletRoot").GetComponent<typeMode>();
			typeShot = typeRoot.type;
			if (typeShot == 1) {
				Posx = typeRoot.Posx;
				Posy = typeRoot.Posy;

				exp += 0.01f;

				float tamaMax = exp * 0.1f + SYOKICHI;
				if(tamaMax > TAMA_MAX){ tamaMax = TAMA_MAX; }

				for (float i = 0.0f; i < tamaMax; i++) {
					var clone = (GameObject)Instantiate (Prefab);
					clone.transform.position = new Vector3 (Posx, Posy, 0.0f);
					clone.transform.localScale = new Vector3 (SIZE, SIZE, SIZE);
					clone.transform.SetParent (this.transform);
				}
			}
		}
	}
}
