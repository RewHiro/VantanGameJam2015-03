using UnityEngine;
using System.Collections;

public class PlayerAttacker : MonoBehaviour {

    public bool isAttack{get;private set;}

    [SerializeField]
    RectTransform playerAttackZone = null;

    void Awake()
    {
        isAttack = false;
    }
	// Use this for initialization

    void HitZone()
    {
        if (!(playerAttackZone.anchoredPosition3D.x < Input.mousePosition.x)) return;
        if (!(Input.mousePosition.x < playerAttackZone.sizeDelta.x)) return;
        if (!(playerAttackZone.anchoredPosition3D.y < Input.mousePosition.y)) return;
        if (!(Input.mousePosition.y < playerAttackZone.sizeDelta.y)) return;
        isAttack = true;
        Debug.Log(playerAttackZone.rect);
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            HitZone();
            
        }
        else
        {
            isAttack = false;
        }
	}
}
