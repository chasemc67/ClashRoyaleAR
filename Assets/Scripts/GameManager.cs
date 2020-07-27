using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    // game objects (other managers) that we want GameManager to create for us
    public GameObject[] SystemPrefabs;
    
    // keeping track of those gameobjects once they've been created
    private List<GameObject> _instancedSystemPrefabs;
    private string _currentLevelName = string.Empty;
    List<AsyncOperation> _loadOperations;

    private void Start() {
        DontDestroyOnLoad(gameObject);
        _loadOperations = new List<AsyncOperation>();
        _instancedSystemPrefabs = new List<GameObject>();
        InstantiateSystemPrefabs();
        // LoadLevel("Main");
    }

    void OnLoadOperationCompleted(AsyncOperation ao) {
        if (_loadOperations.Contains(ao)) {
            _loadOperations.Remove(ao);
        }
        Debug.Log("Load Complete.");
    }

    void OnUnloadOperationComplete(AsyncOperation ao) {
        Debug.Log("Unload Complete.");
    }

    void InstantiateSystemPrefabs() {
        GameObject prefabInstance;
        for (int i = 0; i < SystemPrefabs.Length; i++) {
            prefabInstance = Instantiate(SystemPrefabs[i]);
            _instancedSystemPrefabs.Add(prefabInstance);
        }
    }

    public void LoadLevel(string  levelName) {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if (ao == null) {
            Debug.LogError("[GameManager] Error loading level " + levelName);
            return;
        }
        ao.completed += OnLoadOperationCompleted;
        _loadOperations.Add(ao);
        _currentLevelName = levelName;
    }

    public void UnloadLevel(string levelName) {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
         if (ao == null) {
            Debug.LogError("[GameManager] Error unloading level " + levelName);
            return;
        }
        ao.completed += OnUnloadOperationComplete;
    }

    protected override void OnDestroy() {
        base.OnDestroy();
        for (int i = 0; i < _instancedSystemPrefabs.Count; i++) {
            Destroy(_instancedSystemPrefabs[i]);
        }
    }
}
