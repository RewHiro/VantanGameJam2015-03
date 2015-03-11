using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

	struct Status{
		private int p_skillType;
		private int p_souls;
		private int p_atk;

		public int skillType{
			get {return p_skillType;}
			set {p_skillType = value;}
		}

		public int souls{
			get {return p_souls;}
			set {p_souls = value;}
		}

		public int atk{
			get {return p_atk;}
			set {p_atk = value;}
		}
	};
	
    Status stats;

	// Use this for initialization
	void Start () {
		stats.skillType = 1;
		stats.souls = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public int UsingSkill(){
		return stats.skillType;
	}

	public void ChangeSkill(int id){
		stats.skillType = id;
	}

	public int ReturnSouls(){
		return stats.souls;
	}

	public void AddSouls(int qty){
		stats.souls += qty;
	}

	public void SpendSouls(int qty){
		stats.souls -= qty;
	}
}
