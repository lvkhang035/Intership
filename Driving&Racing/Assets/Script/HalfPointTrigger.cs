using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HalfPointTrigger : MonoBehaviour {
    public GameObject LapCompleteTrig;
    public GameObject HalfPointTrig;

    void OnTriggerEnter()
    {
        LapCompleteTrig.SetActive(true);
        HalfPointTrig.SetActive(false);

    }

}
