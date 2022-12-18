using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange_H_G : MonoBehaviour
{
    // 천상 -> 지상
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(0);
    }
}
