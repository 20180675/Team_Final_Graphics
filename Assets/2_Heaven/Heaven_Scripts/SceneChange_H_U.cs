using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange_H_U : MonoBehaviour
{
    // 천상 -> 지하
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
}
