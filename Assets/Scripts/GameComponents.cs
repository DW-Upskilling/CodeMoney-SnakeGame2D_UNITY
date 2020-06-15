using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameComponents : MonoBehaviour
{
    public static GameComponents componentsInstance;

    private void Awake(){
        componentsInstance = this;
    }

    public Sprite headSprite;
    public Sprite bodySprite;
    public Sprite signalSprite;
}
