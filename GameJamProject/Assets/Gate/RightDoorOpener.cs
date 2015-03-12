using UnityEngine;
using System.Collections;

public class RightDoorOpener : MonoBehaviour {

    [SerializeField]
    private float changeTime = 1.0f;


    [SerializeField]
    private float maxAngle = -180.0f;

    // Use this for initialization
    void Start()
    {
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            iTween.RotateTo(gameObject, iTween.Hash("y", maxAngle, "time", changeTime, "easetype", iTween.EaseType.easeOutExpo));
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            iTween.RotateTo(gameObject, iTween.Hash("y", -0.5, "time", changeTime, "easetype", iTween.EaseType.easeOutExpo));
        }
    }

}
