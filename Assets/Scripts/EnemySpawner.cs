using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;   
    [SerializeField]
    private float spawnTime;   
    [SerializeField]
    private Transform[] wayPoints;  

    private void Awake()
    {
        // 적 생성 코루틴 메소드 호출
        StartCoroutine(nameof(SpawnEnemy));
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            GameObject clone = Instantiate(enemyPrefab); 
            Enemy enemy = clone.GetComponent<Enemy>(); 

            enemy.Setup(wayPoints);                             

            yield return new WaitForSeconds(spawnTime); 
        }
    }
}