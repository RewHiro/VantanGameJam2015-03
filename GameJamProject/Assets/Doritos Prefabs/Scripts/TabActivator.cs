using UnityEngine;
using System.Collections;

public class TabActivator : MonoBehaviour {

	[SerializeField]
	GameObject skillTab;
	[SerializeField]
	GameObject itemTab;
	[SerializeField]
	GameObject shopTab;

	[SerializeField]
	bool isSkillactive;
	[SerializeField]
	bool isItemactive;
	[SerializeField]
	bool isShopactive;
	
	void Start () {
		isSkillactive = true;
		isItemactive = false;
		isShopactive = false;
	}

	void Update(){
		if (isSkillactive) {
			skillTab.SetActive (true);
		}else {
			skillTab.SetActive (false);
		}

		if (isItemactive) {
			itemTab.SetActive (true);
		}else {
			itemTab.SetActive (false);
		}

		if (isShopactive) {
			shopTab.SetActive (true);
		}else {
			shopTab.SetActive (false);
		}
	}

	public void ActivateSkill(){
		if (!isSkillactive) {
			isSkillactive = true;
			isItemactive = false;
			isShopactive = false;
		} 
		else {
			//Do Nothing
		}
	}

	public void ActivateItem(){
		if (!isItemactive) {
			isSkillactive = false;
			isItemactive = true;
			isShopactive = false;
		} 
		else {
			//Do Nothing
		}
	}

	public void ActivateShop(){
		if (!isSkillactive) {
			isSkillactive = false;
			isItemactive = false;
			isShopactive = true;
		} 
		else {
			//Do Nothing
		}
	}
}
