using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesChange_G_U : MonoBehaviour
{
    // ���� -> ����
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
}
