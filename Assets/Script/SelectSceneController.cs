using System.Runtime.CompilerServices;
using UnityEngine;

public class SelectSceneController : MonoBehaviour
{
    private GameObject sceneController;
    void Start()
    {
        sceneController = GameObject.Find("SceneController");
    }
}
