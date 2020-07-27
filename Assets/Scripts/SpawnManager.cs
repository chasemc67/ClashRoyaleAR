using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : Singleton<SpawnManager>
{
    public GameObject activeCharacterPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCharacter(Vector3 position) {
        Instantiate(activeCharacterPrefab, position, Quaternion.LookRotation(gameObject.transform.forward, gameObject.transform.up));
    }
}
