using UnityEngine;
using System.Collections;

public class AttackEffectRotater : MonoBehaviour {

	// Use this for initialization
	void Start () {
        iTween.RotateTo(gameObject, iTween.Hash("z", -100.0f, "time", 0.5f,"looptype",iTween.LoopType.loop));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
