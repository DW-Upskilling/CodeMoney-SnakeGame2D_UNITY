using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    private Vector2Int gridPosition,direction,gridMaxSize;
    private float timer,timerMax;
    private float angle;
    private SignalSpawner spawner;

    private void Awake() {
        gridPosition = new Vector2Int(0,0);
        gridMaxSize = new Vector2Int(50,50);
        direction = new Vector2Int(1,0);
        timerMax = 0.1f;
        timer = timerMax;
        angle = 270;
    }

    public void Setup(SignalSpawner spawner)
    {
        this.spawner = spawner;
    }

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            if(direction.y == 0){
                direction.x = 0;
                direction.y = 1;
                angle = 0;
            }
        }
        
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            if(direction.y == 0){
                direction.x = 0;
                direction.y = -1;
                angle = 180;
            }
        }
        
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            if(direction.x == 0){
                direction.x = -1;
                direction.y = 0;
                angle = 90;
            }
        }
        
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            if(direction.x == 0){
                direction.x = 1;
                direction.y = 0;
                angle = 270;
            }
        }

        timer += Time.deltaTime;
        if(timer >= timerMax){
            timer -= timerMax;
            gridPosition += direction;
        }

        

        transform.position = new Vector3(gridPosition.x, gridPosition.y);
        transform.eulerAngles = new Vector3(0,0,angle);

        spawner.consume(gridPosition);
    }
}
