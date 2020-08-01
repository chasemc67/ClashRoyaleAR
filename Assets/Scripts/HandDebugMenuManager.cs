using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandDebugMenuManager : MonoBehaviour
{
    public GameObject Gameboard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TouchGameBoard() {
        Destroy(Gameboard);
    }
}
