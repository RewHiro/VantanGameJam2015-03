using UnityEngine;
using System.Collections;

public class EnemyMoveBoss : MonoBehaviour {
  
  [SerializeField]
  private float moveSpeedMin = 0.0f;
  
  [SerializeField]
  private float moveSpeedMax = 0.0f;

  private const float POS_Y = 0.5f;
  
  void Start()
  {
    float posX = transform.position.x * 0.25f;
    Vector3 goalPos = new Vector3(posX, POS_Y, 0);
    float moveTime = Random.Range(moveSpeedMin, moveSpeedMax);
    
    iTween.MoveTo(gameObject, iTween.Hash("x", goalPos.x,
                                          "y", goalPos.y,
                                          "z", goalPos.z,
                                          "time", moveTime,
                                          "easetype", iTween.EaseType.easeOutExpo));
  }
}
