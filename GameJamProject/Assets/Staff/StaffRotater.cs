using UnityEngine;
using System.Collections;

public class StaffRotater : MonoBehaviour {

    [SerializeField]
    PlayerAttacker player_attacker = null;

    float count = 0;

    [SerializeField]
    float itweenFinishTime = 0.3f;
	
	// Update is called once per frame
	void Update () {
        count += Time.deltaTime;
        if (player_attacker.isAttack)
        {
            count = 0;
            iTween.Stop();
            transform.rotation = Quaternion.identity;
            iTween.RotateTo(gameObject, iTween.Hash("z", -27.0f, "time", itweenFinishTime, "easetype", iTween.EaseType.easeOutBack));
        }
        else
        {
            if (count >= itweenFinishTime)
            {
                iTween.RotateTo(gameObject, iTween.Hash("z", 0.0f, "time", itweenFinishTime, "easetype", iTween.EaseType.easeInBack));
            }
        }
	}
}
