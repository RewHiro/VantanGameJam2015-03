using UnityEngine;
using System.Collections;

public class TabActivator : MonoBehaviour {

    [SerializeField]
	GameObject skillTab = null;

    [SerializeField]
	GameObject specialTab = null;

    [SerializeField]
	GameObject shopTab = null;

	[SerializeField]
	bool isSkillActive;
	[SerializeField]
	bool isSpecialActive;
	[SerializeField]
	bool isShopActive;
	
	void Start () {
		isSkillActive = true;
		isSpecialActive = false;
		isShopActive = false;
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

		if (isShopActive) {
			shopTab.SetActive (true);
		}else {
			shopTab.SetActive (false);
		}
	}

	public void ActivateSkill(){
		if (!isSkillActive) {
			isSkillActive = true;
			isSpecialActive = false;
			isShopActive = false;
		} 
		else {
			//Do Nothing
		}
	}

	public void ActivateSpecial(){
		if (!isSpecialActive) {
			isSkillActive = false;
			isSpecialActive = true;
			isShopActive = false;
		} 
		else {
			//Do Nothing
		}
	}

	public void ActivateShop(){
		if (!isShopActive) {
			isSkillActive = false;
			isSpecialActive = false;
			isShopActive = true;
		} 
		else {
			//Do Nothing
		}
	}
}
