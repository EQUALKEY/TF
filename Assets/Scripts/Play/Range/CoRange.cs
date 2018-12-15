using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRange : MonoBehaviour {
    public GameObject EC;

    void OnMouseEnter() {
        EC.GetComponent<EventController>().onCoAngle = true;
    }

    void OnMouseExit() {
        EC.GetComponent<EventController>().onCoAngle = false;
    }
}
