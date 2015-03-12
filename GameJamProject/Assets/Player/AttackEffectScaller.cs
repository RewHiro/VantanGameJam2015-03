using UnityEngine;
using System.Collections;

public class AttackEffectScaller : MonoBehaviour {

    float count = 0.0f;

	// Use this for initialization
	void Start () {
	    iTween.ScaleTo(gameObject,iTween.Hash("x",3.0f,"y",3.0f,"time",0.5f));
        iTween.ColorTo(gameObject, Color.clear, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
        count += Time.deltaTime;
        if (count > 0.5f)
        {
            Destroy(gameObject);
        }
	}
}
