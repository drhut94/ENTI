using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class DataPersistanceManager 
{
    public static void SaveJson(Player data, string jsonPath) {
        string json = JsonUtility.ToJson(data);
        System.IO.File.WriteAllText(jsonPath, json);
    }

    public static void LoadJson<T>(string jsonPath) {
        string text = System.IO.File.ReadAllText(jsonPath);
        Debug.Log(text);
    }

    public static void SaveJson(Object[] data, string jsonPath) {
        
    }
}
