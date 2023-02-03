using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandObstacle : MonoBehaviour
{
    [SerializeField] private GameObject spawnObj;
    [SerializeField] private float randomSpawnTimeMax = 0f;//ランダムの最大値
    [SerializeField] private float randomSpawnTimeMin = 0f;//ランダムの最小値
    [SerializeField] private float randomSpawnHeightMax = 0f;//ランダムスポーンの最高値
    [SerializeField] private float randomSpawnHeightMin = 0f;//ランダムスポーンの最低値
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(RandomSpawnObstacle());
    }

    IEnumerator RandomSpawnObstacle()
    {
        float randomTime = Random.Range(randomSpawnTimeMin, randomSpawnTimeMax);
        float randomPos = Random.Range(randomSpawnHeightMin, randomSpawnHeightMax);
        Instantiate(spawnObj, new Vector3(9.5f, randomPos, 0), Quaternion.identity, this.gameObject.transform);
        yield return new WaitForSeconds(randomTime);
    }
}
