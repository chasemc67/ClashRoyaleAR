using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject activeCharacterPrefab;
    public Transform rackCharacterTransform;
    public Transform gameboard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnCharacter() {
        Instantiate(activeCharacterPrefab, rackCharacterTransform.position, Quaternion.LookRotation(gameObject.transform.forward, gameObject.transform.up), gameboard);
    }
}
