using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalSpawner
{
    private GameObject signal;
    private Vector2Int foodPosition;
    private int width,height;
    private Head head;

    public SignalSpawner(int width,int height){
        this.width = width;
        this.height = height;
    }

    public void Setup(Head head){
        this.head = head;
        spawn();
    }

    private void spawn(){
        foodPosition = new Vector2Int(Random.Range(0,width),Random.Range(0,height));

        
        signal = new GameObject();
        SpriteRenderer signalSpriteRenderer = signal.AddComponent<SpriteRenderer>();
        signalSpriteRenderer.sprite = GameComponents.componentsInstance.signalSprite;
        signal.transform.position = new Vector3(foodPosition.x,foodPosition.y);
    }

    public void consume(Vector2Int headPosition){
        if(headPosition == foodPosition){
            Object.Destroy(signal);
            this.spawn();
        }
    }
}
