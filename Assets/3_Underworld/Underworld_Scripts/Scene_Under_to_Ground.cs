using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Under_to_Ground : MonoBehaviour
{
    // ���� -> ����
    private void OnMouseDown()
    {
        SceneManager.LoadScene(0);
    }
}
