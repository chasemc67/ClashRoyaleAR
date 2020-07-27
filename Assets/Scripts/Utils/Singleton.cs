using UnityEngine;

// the extra where the type that is passed in is a type that extends singleton (not just a random type) 
public class Singleton<T> : MonoBehaviour where T : Singleton<T> {
    private static T instance;
    
    // public accessor with a getter
    public static T Instance {
        get {return instance;}
    }

    public static bool IsInitialized{
        get { return instance != null; }
    }

    // virtual means this can be overridden;
    // protected means this can still be called by subclasses
    protected virtual void Awake() {
        if (instance != null) {
            Debug.LogError("[Singletone] Trying to instantiate a second instance of singleton class");
        } else {
            instance = (T) this;
        }
    }

    protected virtual void OnDestroy() {
        if (instance == this) {
            instance = null;
        }
    }
}