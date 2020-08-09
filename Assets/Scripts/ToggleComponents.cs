using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;

public class ToggleComponents : MonoBehaviour
{
    public List<MonoBehaviour> monoBehaviorComponents;
    public List<Collider> colliderObjects;
    // Start is called before the first frame update
    
    public void DisableComponents() {
        // GetComponent<NearInteractionGrabbable>().enabled = false;
        // GetComponent<BoxCollider>().enabled = false;
        // GetComponent<ObjectManipulator>().enabled = false;

        // for (int i = 0; i < monoBehaviorComponents.Count; i++) {
        //     monoBehaviorComponents[i].enabled = false;
        // }

        // for (int i = 0; i < colliderObjects.Count; i++) {
        //     colliderObjects[i].enabled = false;
        // }

        GetComponent<NearInteractionGrabbable>().enabled = !GetComponent<NearInteractionGrabbable>().enabled;
        GetComponent<BoxCollider>().enabled = !GetComponent<BoxCollider>().enabled;
        GetComponent<ObjectManipulator>().enabled = !GetComponent<ObjectManipulator>().enabled;
    }
}
