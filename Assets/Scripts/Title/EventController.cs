using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventController : MonoBehaviour {
    public GameObject[] HelpContents = new GameObject[10];

    public void StoryModeStart() {
        if (!PlayerPrefs.HasKey("isMonsterTypeOff")) PlayerPrefs.SetInt("isMonsterTypeOff", 0);
        PlayerPrefs.SetInt("Mode", 0);
        SceneManager.LoadScene("Play");
    }
    
    public void InfinityModeStart() {
        if (!PlayerPrefs.HasKey("isMonsterTypeOff")) PlayerPrefs.SetInt("isMonsterTypeOff", 0);
        PlayerPrefs.SetInt("Mode", 1);
        SceneManager.LoadScene("Play");
    }
}
