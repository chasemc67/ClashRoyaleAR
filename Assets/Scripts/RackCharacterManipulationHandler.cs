using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RackCharacterManipulationHandler : MonoBehaviour
{
    Vector3 RackPosition;   
    // Start is called before the first frame update
    void Awake()
    {
        RackPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void ManipulationEnded() {
        Vector3 pos = gameObject.transform.position;
        transform.position = RackPosition;
        SpawnManager.Instance.SpawnDropCharacter(pos);
    }
}
