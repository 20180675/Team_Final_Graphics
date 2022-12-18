using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Under_to_Heaven : MonoBehaviour
{
    // 지하 -> 천상
    private void OnMouseDown()
    {
        print("Heaven");
        SceneManager.LoadScene(1);
    }
}
