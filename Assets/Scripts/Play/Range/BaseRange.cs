using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRange : MonoBehaviour {
    public GameObject EC;

    void OnMouseEnter() {
        EC.GetComponent<EventController>().onBase = true;
    }

    void OnMouseExit() {
        EC.GetComponent<EventController>().onBase = false;
    }
}
