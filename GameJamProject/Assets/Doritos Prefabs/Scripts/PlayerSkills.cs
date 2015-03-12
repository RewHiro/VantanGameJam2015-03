using UnityEngine;
using System.Collections;

public class PlayerSkills : MonoBehaviour {

	PlayerStats stats;

	void Start(){
		stats = GetComponent <PlayerStats>();
	}

	public void ChangeSkill(int skill_id){
		switch (skill_id) {
		case 1:
			stats.ChangeSkill(1);
			break;
		case 2:
			stats.ChangeSkill(2);
			break;
		//case 3............
		}
	}

}
