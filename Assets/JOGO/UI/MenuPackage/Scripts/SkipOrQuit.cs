using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipOrQuit : MonoBehaviour
{
    [SerializeField]
    string loadScene;

    [SerializeField]
    LoadNextScene _loadNextScene;

    private void Start()
    {
        if (_loadNextScene == null)
            _loadNextScene = GetComponent<LoadNextScene>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Escape))
        {
            if (loadScene != null)
                _loadNextScene.LoadSceneName(loadScene);
        }
            
    }
}
