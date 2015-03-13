using UnityEngine;
using System.Collections;

public class SoulCreator : MonoBehaviour {

    public struct CreateData
    {
        public CreateData(int num,int soulValue,Vector3 createPos):this()
        {
            this.num = num;
            this.soulValue = soulValue;
            this.createPos = createPos;
        }

        public int num { get; set; }
        public int soulValue { get; set; }
        public Vector3 createPos { get; set; }
    };

    [SerializeField]
    GameObject soulPrefab = null;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {

	}

    /// <summary>
    /// 生成する数を設定
    /// </summary>
    public void Create(CreateData data)
    {
        for (int i = 0; i < data.num; i++)
        {
            var clone = (GameObject)Instantiate(soulPrefab, Vector3.zero, Quaternion.identity);
            clone.name = soulPrefab.name;
            clone.transform.SetParent(transform);
            var rectTrans = clone.transform as RectTransform;

            var createPos = Camera.main.WorldToScreenPoint(data.createPos);
            createPos.z = 1.0f;
            rectTrans.transform.position = Camera.main.ScreenToWorldPoint(createPos);
            rectTrans.localScale = new Vector3(1,1,1);
            clone.GetComponent<SoulMover>().SetSoulValue(data.soulValue);
        }
    }

}

