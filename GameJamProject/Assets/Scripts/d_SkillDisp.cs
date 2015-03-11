using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class d_SkillDisp : MonoBehaviour {

	public GameObject player;

	PlayerStats stats;

	int skillType;

	Text text;

	void Start () {
		stats = player.GetComponent<PlayerStats>();
		skillType = stats.UsingSkill ();
		text = GetComponent <Text>();
	}

	void Update(){
		text.text = "Skill Type: " + skillType.ToString ();
	}

	public void UpdateText(){
        //skillType = stats.UsingSkill ();
	}

}
