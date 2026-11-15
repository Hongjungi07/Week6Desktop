using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject towerPrefab;
    [SerializeField]
    private int towerBuildGold = 50;
    [SerializeField]
    private PlayerGold playerGold;
    [SerializeField]
    private EnemySpawner enemySpawner;

    public void TrySpawnTower(Transform tileTransform)
    {
        if (towerBuildGold > playerGold.CurrentGold) return;

        Tile tile = tileTransform.GetComponent<Tile>();

        if (tile.IsBuildTower == true)
        {
            return;
        }

        tile.IsBuildTower = true;
        playerGold.CurrentGold -= towerBuildGold;
        Vector3 position = tileTransform.position + Vector3.back;
        var clone = Instantiate(towerPrefab, position, Quaternion.identity);
        clone.GetComponent<TowerWeapon>().Setup(enemySpawner);
    }
}