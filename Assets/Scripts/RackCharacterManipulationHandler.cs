using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RackCharacterManipulationHandler : MonoBehaviour
{   
    // Start is called before the first frame update
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ManipulationEnded() {
        SpawnManager.Instance.SpawnCharacter(gameObject.transform.position);
    }
}
