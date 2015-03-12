using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

	struct Status{
		private int sls;

		public int souls{
			get {return sls;}
			set {sls = value;}
		}

		private int lvl;

		public int level{
			get {return lvl;}
			set {lvl = value;}
		}

		private int exp;

		public int experience{
			get {return exp;}
			set {exp = value;}
		}

		private int atkPwr;

		public int attackPower{
			get {return atkPwr;}
			set {atkPwr = value;}
		}

		private int sklTyp;
		
		public int skillType{
			get {return sklTyp;}
			set {skillType = value;}
		}
		
	};
	
    Status status;

	[SerializeField]
	int souls;
	[SerializeField]
	int level;
	[SerializeField]
	int experience;
	[SerializeField]
	int attackPower;
	[SerializeField]
	int skillType;

	// Use this for initialization
	void Start () {
		status.souls = 0;
		status.level = 1;
		status.experience = 0;
		status.attackPower = 10;
		status.skillType = 1;
		souls = status.souls;
		level = status.level;
		experience = status.experience;
		attackPower = status.attackPower;
		skillType = status.skillType;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public int UsingSkill(){
		return status.skillType;
	}

	public void ChangeSkill(int id){
		status.skillType = id;
	}

	public int ReturnSouls(){
		return status.souls;
	}

	public void AddSouls(int qty){
		status.souls += qty;
	}

	public void SpendSouls(int qty){
		status.souls -= qty;
	}
}
