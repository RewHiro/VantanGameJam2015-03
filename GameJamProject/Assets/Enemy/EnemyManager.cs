using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

  [SerializeField]
  int spawnCount = 0;

  [SerializeField]
  int spawnLimit = 0;

  private int liveEnemy = 0;
  private bool spawnBoss = false;

  void Update() {
  }

  bool BossStage() {
    //var stage = Find...
    //return (stage % 5) == 0;
    return false;//debug
  }

  // EnemySpawn.sc
  public bool IsAbleToSpawnMob() {
    return (liveEnemy < spawnLimit && spawnCount > 0);
  }

  // EnemySpawn.sc
  public void LiveCountUp() {
    --spawnCount;
    ++liveEnemy;
  }
  
  // EnemyLife.sc
  public void EnemyDead() {
    --liveEnemy;
  }
}
