using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum CharacterState {
        // attacking a target
        Attacking,
        // see a nearby enemy and walking towards
        Homing,
        // walking forwards
        Walking
}

public class CharacterActiveController : MonoBehaviour
{
    CharacterController characterController;
    // Animator animatorController;
    CharacterState currentState;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        characterController.enabled = true;
        // animatorController = GetComponent<Animator>();
        currentState = CharacterState.Walking;
    }

    private void OnTriggerEnter(Collider other)
    {
        // characterController has its own collider so have to check its not that one
        if (other.gameObject.tag == "characterUnit" && other.gameObject != this.gameObject) {
            currentState = CharacterState.Attacking;
            // animatorController.SetBool("attacking", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentState) {
            case CharacterState.Walking:
                characterController.SimpleMove(transform.TransformDirection(Vector3.forward) * speed * Time.deltaTime);
                break;
            case CharacterState.Homing:
                break;
            case CharacterState.Attacking:
                break;
            default:
                break;
        }
    }
}
