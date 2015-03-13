using UnityEngine;
using System.Collections;

public class wazaDTuemove : MonoBehaviour {

    int countTime = 0;

    const int DELETE_COUNT = 390;

    // Use this for initialization
    void Start()
    {
        GetComponent<Renderer>().sortingLayerName = "Staff";
    }

    // Update is called once per frame
    void Update()
    {
        if (countTime < DELETE_COUNT)
        {
            if (transform.position.y > 0.7f)
            {
                transform.Translate(new Vector3(0.0f, -0.2f, 0.0f));
            }
        }
        else
        {
            Destroy(gameObject);
        }
        countTime++;
    }
}
