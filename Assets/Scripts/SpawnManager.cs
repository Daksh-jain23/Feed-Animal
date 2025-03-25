using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject[] animals;
    private float spawnrangex = 16.0f;
    private float spawnrangez = 16.0f;
    private float spawnposz = 20.0f;
    private float spawnposx = 20.0f;
    private float startdelay = 2.0f;
    private float spawnrate = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startdelay, spawnrate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        // Up spawm
        Vector3 spawnposition_up = new Vector3(Random.Range(-spawnrangex, spawnrangex), 0, spawnposz);
        int animalindex = Random.Range(0, animals.Length);
        Instantiate(animals[animalindex], spawnposition_up, animals[animalindex].transform.rotation);

        //Left Spawn
        Vector3 spawnposition_left = new Vector3(spawnposx, 0, Random.Range(-2, spawnrangez));
        Vector3 rotation_left = new Vector3(0, -90, 0);
        int animalindex_left = Random.Range(0, animals.Length);
        Instantiate(animals[animalindex_left], spawnposition_left, Quaternion.Euler(rotation_left));

        // right spawn
        Vector3 spawnposition_right = new Vector3(-spawnposx, 0, Random.Range(-2, spawnrangez));
        Vector3 rotation_right = new Vector3(0, 90, 0);
        int animalindex_right = Random.Range(0, animals.Length);
        Instantiate(animals[animalindex_right], spawnposition_right, Quaternion.Euler(rotation_right));
    }
}
