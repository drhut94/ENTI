using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    Player player;

    public void Start() {
        player = new Player();
        Debug.Log(Application.dataPath);
        DataPersistanceManager.SaveJson(player, Application.dataPath + "/player.json");
        DataPersistanceManager.LoadJson<Player>(Application.dataPath + "/player.json");
    }
}
