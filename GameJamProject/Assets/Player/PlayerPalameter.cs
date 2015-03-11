using UnityEngine;
using System.Collections;

public class PlayerPalameter : MonoBehaviour {

    [SerializeField]
    int attackPower = 10;

    [SerializeField]
    int level = 1;

    [SerializeField]
    int  experience = 0;

    struct AttackPower
    {
        int attackPow;
    }

    enum RANK
    {
        BEGINNER,
        AMOUTURE,
        PRO,
        MASTER
    }

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
