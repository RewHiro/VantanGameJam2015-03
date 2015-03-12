using UnityEngine;
using System.Collections;

public class EnemyLife : MonoBehaviour {

  [SerializeField]
  int health = 0;

  EnemyManager manager = null;

  void Start() {
    manager = FindObjectOfType(typeof(EnemyManager)) as EnemyManager;
  }

  void Update() {
    if (health > 0) return;

    manager.EnemyDead();
    GameObject.Destroy(gameObject);
  }

  public void Damage(int attackPower) {
    health -= attackPower;
  }

  public void SetHealth(int val) {
    health = val;
  }
}
