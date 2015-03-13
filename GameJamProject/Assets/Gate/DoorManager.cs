using UnityEngine;
using System.Collections;

public class DoorManager : MonoBehaviour {



    [SerializeField]
    private float changeTime = 1.0f;

    public float ChangeTime { get { return changeTime; } private set { changeTime = value; } }

    [SerializeField]
    private float delayTime = 0.0f;

    public float DelayTime { get { return delayTime; } private set { delayTime = value; } }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
