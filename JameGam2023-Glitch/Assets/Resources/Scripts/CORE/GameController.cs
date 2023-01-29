using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public float timer = 2f;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        mainGameLoop = StartCoroutine(_mainGameLoop());
    }


    Coroutine mainGameLoop = null;
    IEnumerator _mainGameLoop()
    {
        while (true)
        {

            EventSpawner.instance.spawnEvent();

            yield return new WaitForSeconds(timer);

        }
    }
}