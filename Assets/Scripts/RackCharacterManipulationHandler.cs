using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RackCharacterManipulationHandler : MonoBehaviour
{   
    private SpawnManager SpawnManager;
    // Start is called before the first frame update
    void Awake()
    {
        SpawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ManipulationEnded() {
        SpawnManager.SpawnCharacter(gameObject.transform.position);
    }
}
