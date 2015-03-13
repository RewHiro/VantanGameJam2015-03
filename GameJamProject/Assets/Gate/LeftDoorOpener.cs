using UnityEngine;
using System.Collections;

public class LeftDoorOpener : MonoBehaviour {

    [SerializeField]
    private float minAngle = 0.5f;

    [SerializeField]
    private float maxAngle = 180.0f;

    private DoorManager DoorMngr = null;

	// Use this for initialization
	void Start () {
        DoorMngr = GameObject.FindObjectOfType(typeof(DoorManager)) as DoorManager;
	}
	


	// Update is called once per frame
	void Update () {
        //if(Input.GetKeyDown(KeyCode.O))
        //{
        //    iTween.RotateTo(gameObject, iTween.Hash("y", maxAngle, "time", changeTime, "easetype", iTween.EaseType.easeOutExpo));
        //}
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    iTween.RotateTo(gameObject, iTween.Hash("y", minAngle, "time", changeTime, "easetype", iTween.EaseType.easeOutExpo));
        //}
    }


    public void DoorOpen()
    {
        iTween.RotateTo(gameObject, iTween.Hash("y", maxAngle, "time", DoorMngr.ChangeTime,"delay",DoorMngr.DelayTime, "easetype", iTween.EaseType.easeOutExpo));
    }

    public void DoorClose()
    {
        iTween.RotateTo(gameObject, iTween.Hash("y", minAngle, "time", DoorMngr.ChangeTime, "easetype", iTween.EaseType.easeOutExpo));
    }
}
