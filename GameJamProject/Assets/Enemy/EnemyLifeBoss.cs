using UnityEngine;
using System.Collections;

public class EnemyLifeBoss : MonoBehaviour {
  
  [SerializeField]
  private int health = 1;

  [SerializeField]
  private float alphaTime = 0.0f;
  
  private bool isDead = false;
  private EnemyManager manager = null;
  
  void Start()
  {
    manager = FindObjectOfType(typeof(EnemyManager)) as EnemyManager;
  }
  
  void Update()
  {
    if (manager.IsTimeOver()) DestroyTask();
    if (!isDead && IsDead()) DeadTask();
  }
  
  private void DeadTask()
  {
    isDead = true;
    
    manager.EnemyDead();
    DestroyTask();
  }

  public void DestroyTask()
  {
    GameObject.Destroy(gameObject, alphaTime);
    
    iTween.FadeTo(gameObject, iTween.Hash("alpha", 0,
                                          "time", alphaTime,
                                          "easetype", iTween.EaseType.easeInCubic));
  }
  
  public bool IsDead()
  {
    return health <= 0;
  }
  
  public void Damage(int attackPower)
  {
    health -= attackPower;
  }
  
  public void SetHealth(int healthPower)
  {
    health = healthPower;
  }
}
