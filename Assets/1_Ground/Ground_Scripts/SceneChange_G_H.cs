using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange_G_H : MonoBehaviour
{
    // ���� -> õ��
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
    }
}
