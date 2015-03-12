using UnityEngine;
using System.Collections;

public class typeMode : MonoBehaviour {

	public float Posx{ get; private set;}
	public float Posy{ get; private set;}
	
	public int type{ get; private set;}

	// Use this for initialization
	void Start () {
		type = 0;
		Posx = -1.3f;
		Posy = 0.7f;
	}

    public void ChangeSkill(int type)
    {
        if (type > 1) return;
        this.type = type;
    }

	// Update is called once per frame
	void Update () {	
        //if (Input.GetKeyDown (KeyCode.W)) {
        //    type++;

        //    if(type > 2){
        //        //Debug.Log (type);
        //        type = 0;
        //    }

        //    //Debug.Log(type);
        //}
	}
}
