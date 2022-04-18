using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosDown : MonoBehaviour {

    public GameObject positionDisplay;

    void OnTriggerExit(Collider orther)
    {
        if (orther.tag == "CarPos")
        {
            positionDisplay.GetComponent<Text>().text = "2nd Place";
        }
    }
}
