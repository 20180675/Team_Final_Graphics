using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Under_to_Ground : MonoBehaviour
{
    // 지하 -> 지상
    private void OnMouseDown()
    {
        SceneManager.LoadScene(0);
    }
}
