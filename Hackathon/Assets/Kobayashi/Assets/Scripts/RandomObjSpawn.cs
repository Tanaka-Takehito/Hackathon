using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjSpawn : MonoBehaviour
{
    [SerializeField] private GameObject spawnObj;
    [SerializeField] private float randomSpawnTimeMax = 0f;//ランダムの最大値
    [SerializeField] private float randomSpawnTimeMin = 0f;//ランダムの最小値
    [SerializeField] private float randomSpawnHeightMax = 0f;//ランダムスポーンの最高値
    [SerializeField] private float randomSpawnHeightMin = 0f;//ランダムスポーンの最低値
    [SerializeField] private int objIndex;//オブジェクト
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RandomSpawnObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator RandomSpawnObject()
    {
        
        for(int i = 0; i < objIndex; i++)
        {
            float randomTime = Random.Range(randomSpawnTimeMin, randomSpawnTimeMax);
            float randomPos = Random.Range(randomSpawnHeightMin, randomSpawnHeightMax);
            Instantiate(spawnObj, new Vector3(9.5f, randomPos, 0),Quaternion.identity,this.gameObject.transform);
            Debug.Log(randomTime);
            Debug.Log(randomPos);
            yield return new WaitForSeconds(randomTime);
        }
    }
}
