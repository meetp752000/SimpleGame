using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelWithButton : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;

    [SerializeField]
    KeyCode keyMenu;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyRestart))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        if (Input.GetKey(keyMenu))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
