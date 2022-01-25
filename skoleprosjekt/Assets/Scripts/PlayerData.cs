using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData{
    public float sensX;
    public float sensY;
    public float[] position;

    public PlayerData(Movement player)
    {
        sensX = player.look.sensX;
        sensY = player.look.sensY;
        
        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }
}
