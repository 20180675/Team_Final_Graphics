using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesChange_G_U : MonoBehaviour
{
    // 지상 -> 지하
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
}
