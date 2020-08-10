using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : Singleton<SpawnManager>
{
    public GameObject ActiveCharacterPrefab;
    public GameObject DropCharacterPrefab;
    public GameObject spawnParent;
    public GameObject enemySpawnPoint;
    public GameObject playerSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnDropCharacter(Vector3 position) {
        var DropPlayer = Instantiate(DropCharacterPrefab, position, Quaternion.LookRotation(gameObject.transform.forward, gameObject.transform.up), spawnParent.transform);
        DropPlayer.GetComponent<DropCharacterController>().hitGround += SpawnCharacter;
    }

    public void SpawnCharacter(Vector3 position) {
        var Player = Instantiate(ActiveCharacterPrefab, position, Quaternion.LookRotation(gameObject.transform.forward, gameObject.transform.up), spawnParent.transform);
        Player.GetComponent<EnemyBehavior>().destination = enemySpawnPoint.transform;
        var Enemy = Instantiate(ActiveCharacterPrefab, enemySpawnPoint.transform.position, Quaternion.LookRotation(gameObject.transform.forward, gameObject.transform.up), spawnParent.transform);
        Enemy.GetComponent<EnemyBehavior>().destination = playerSpawnPoint.transform;
    }
}
