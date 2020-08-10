using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCharacterController : MonoBehaviour
{
    //public GameObject ActiveCharacterPrefab;
    //public Transform EnemySpawnPoint;
    //public GameObject SpawnParent;

    public delegate void HitGround(Vector3 param1);
    public event HitGround hitGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        // var Player = Instantiate(ActiveCharacterPrefab, transform.position, Quaternion.LookRotation(gameObject.transform.forward, gameObject.transform.up), SpawnParent.transform);
        // Player.GetComponent<EnemyBehavior>().destination = EnemySpawnPoint;
        // Destroy(gameObject);
        if (other.gameObject.tag == "Ground") {
            GetComponent<CapsuleCollider>().enabled = false;
            hitGround(transform.position);
            Destroy(gameObject);
        }
         
    }

}
