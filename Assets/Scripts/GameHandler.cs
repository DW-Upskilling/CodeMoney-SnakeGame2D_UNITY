using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private Head head;
    private SignalSpawner signalSpawner;
    // Start is called before the first frame update
    void Start()
    {
        // GameObject head = new GameObject();
        // SpriteRenderer headSpriteRenderer = head.AddComponent<SpriteRenderer>();
        // headSpriteRenderer.sprite = GameComponents.componentsInstance.headSprite;

        signalSpawner = new SignalSpawner(20,20);
        head.Setup(signalSpawner);
        signalSpawner.Setup(head);
    }

    // Update is called once per frame
    void Update()
    {
        // signalSpawner.spawn();
    }
}
