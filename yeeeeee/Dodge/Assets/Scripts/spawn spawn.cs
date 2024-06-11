using UnityEngine;
using System.Collections;

public class SpawnSpawn : MonoBehaviour
{
    public GameObject bulletSpawnerPrefab; // 생성할 불렛 스포너 프리팹
    public Transform levelTransform; // 레벨의 Transform
    private float spawnDelay; // 생성 딜레이 시간

    void Start()
    {
        spawnDelay = Random.Range(3f, 5f);
        StartCoroutine(SpawnBulletSpawners());
    }

    IEnumerator SpawnBulletSpawners()
    {
        while (true)
        {
            float randomX = Random.Range(-13f, 13f);
            float randomZ = Random.Range(-13f, 13f);

            // y축으로 180도 회전된 상태로 생성
            GameObject newBulletSpawner = (GameObject)Instantiate(bulletSpawnerPrefab, new Vector3(randomX, 0.5f, randomZ), Quaternion.Euler(0f, 180f, 0f));
            newBulletSpawner.transform.SetParent(levelTransform);

            yield return new WaitForSeconds(Random.Range(3f, 5f));
        }
    }
}