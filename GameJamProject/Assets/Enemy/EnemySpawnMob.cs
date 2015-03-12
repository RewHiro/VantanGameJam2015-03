using UnityEngine;
using System.Collections;

public class EnemySpawnMob : MonoBehaviour {
  
  [SerializeField]
  int spawnIntervalMin = 0;
  
  [SerializeField]
  int spawnIntervalMax = 0;

  [SerializeField]
  EnemyManager manager = null;

  private int currentInterval = 0;
  
  [SerializeField]
  GameObject[] prefab = new GameObject[4];

  //private StageInformation stageInfo = null;

  void Start() {
    //stageInfo = FindObjectOfType(typeof(StageInformation)) as StageInformation;
    SetInterval();
  }

  void Update() {
    if (!IsAbleToSpawn()) return;
    if (!manager.IsAbleToSpawnMob()) return;

    SetInterval();
    var index = Random.Range(0, prefab.Length);
    var clone = (GameObject)Instantiate(prefab[index], transform.position, transform.rotation);
    clone.name = prefab[index].name;
    clone.transform.SetParent(transform);
    manager.LiveCountUp();

    //      var cloneHealth = GetComponent<EnemyLife>();
    //      cloneHealth.SetHealth(stageInfo.EnemyHealthCaliculate());

  }
  
  void SetInterval() {
    currentInterval = Random.Range(spawnIntervalMin, spawnIntervalMax);
  }
  
  bool IsAbleToSpawn() {
    if (currentInterval > 0) --currentInterval;
    return currentInterval <= 0;
  }
}
