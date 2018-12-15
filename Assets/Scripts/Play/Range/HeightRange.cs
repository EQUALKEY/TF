using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightRange : MonoBehaviour {
    public GameObject EC;

    void OnMouseEnter() {
        EC.GetComponent<EventController>().onHeight = true;
    }

    void OnMouseExit() {
        EC.GetComponent<EventController>().onHeight = false;
    }
}
