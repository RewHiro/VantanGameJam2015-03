using UnityEngine;
using System.Collections;

<<<<<<< HEAD
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
=======
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
>>>>>>> 46c16a0561a83314d4af8df6b6d4351dcce8dc7a
    }

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
