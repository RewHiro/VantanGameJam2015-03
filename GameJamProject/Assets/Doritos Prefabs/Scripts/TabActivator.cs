using UnityEngine;
using System.Collections;

public class TabActivator : MonoBehaviour {

    [SerializeField]
	GameObject skillTab = null;

    [SerializeField]
	GameObject specialTab = null;

    [SerializeField]
	GameObject optionTab = null;

	[SerializeField]
	bool isSkillActive;
	[SerializeField]
	bool isSpecialActive;
	[SerializeField]
	bool isOptionActive;
	
	void Start () {
		isSkillActive = true;
		isSpecialActive = false;
		isOptionActive = false;
	}

	void Update(){
		if (isSkillActive) {
			skillTab.SetActive (true);
		}else {
			skillTab.SetActive (false);
		}

		if (isSpecialActive) {
			specialTab.SetActive (true);
		}else {
			specialTab.SetActive (false);
		}

		if (isOptionActive) {
			optionTab.SetActive (true);
		}else {
			optionTab.SetActive (false);
		}
	}

	public void ActivateSkill(){
		if (!isSkillActive) {
			isSkillActive = true;
			isSpecialActive = false;
			isOptionActive = false;
		} 
		else {
			//Do Nothing
		}
	}

	public void ActivateSpecial(){
		if (!isSpecialActive) {
			isSkillActive = false;
			isSpecialActive = true;
			isOptionActive = false;
		} 
		else {
			//Do Nothing
		}
	}

	public void ActivateOption(){
		if (!isOptionActive) {
			isSkillActive = false;
			isSpecialActive = false;
			isOptionActive = true;
		} 
		else {
			//Do Nothing
		}
	}
}
