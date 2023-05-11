using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //hexagon game object
    [Header("Shape Objects")]
    public GameObject[] shapePrefabs;
    //Spawn rate for how many 
    //objects are spawned
    [Header("Default Spawn Delay Time")]
    public float spawnDelay = 2f;
    [Header("Default Spawn Time")]
    public float spawnTime = 3f;

    //game over canvas object
    [Header("Game Over UI Object")]
    public GameObject gameOverCanvas;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //spawn function
    void Spawn()
    {
        //random range for shape objects to be spawned
        int randomInt = Random.Range(0, shapePrefabs.Length);
        //spawn new hexagon at position
        Instantiate(shapePrefabs[randomInt], Vector3.zero, Quaternion.identity);
    }

    //game over function
    public void GameOver()
    {
        //stops the spawn function
        CancelInvoke("Spawn");
        //game over canvas is visible
        gameOverCanvas.SetActive(true);
        //game is at stopping state
        Time.timeScale = 0;

    }

}

