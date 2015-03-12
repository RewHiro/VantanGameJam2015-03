using UnityEngine;
using System.Collections;

public class AttackEffectCreater : MonoBehaviour {

    [SerializeField]
    PlayerAttacker playerAttacker = null;

    [SerializeField]
    GameObject attackEffect = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (playerAttacker.isAttack)
        {
            var mousePosition = Input.mousePosition;
            mousePosition.z = 90.0f;
            var effectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Instantiate(attackEffect, effectPosition, Quaternion.identity);
        }
	}
}
