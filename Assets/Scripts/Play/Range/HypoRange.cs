using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HypoRange : MonoBehaviour {
    public GameObject EC;

    void OnMouseEnter() {
        EC.GetComponent<EventController>().onHypo = true;
    }

    void OnMouseExit() {
        EC.GetComponent<EventController>().onHypo = false;
    }
}
