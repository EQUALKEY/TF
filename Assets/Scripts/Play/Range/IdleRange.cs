using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleRange : MonoBehaviour {
    public GameObject EC;

    void OnMouseEnter() {
        EC.GetComponent<EventController>().onIdleAngle = true;
    }

    void OnMouseExit() {
        EC.GetComponent<EventController>().onIdleAngle = false;
    }
}
