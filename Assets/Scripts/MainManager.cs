using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now
    public static MainManager Instance;

    public Color TeamColor; // new variable declared
    private void Awake()
    {
        // Start of now code
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of the new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    [System.Serializable]
    class SaveData
    {
        public Color TeamColor;
    }
}
