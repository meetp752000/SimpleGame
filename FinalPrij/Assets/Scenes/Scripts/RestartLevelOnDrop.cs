using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartLevelOnDrop : MonoBehaviour
{
    [SerializeField]
    string PlayerTag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == PlayerTag)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
