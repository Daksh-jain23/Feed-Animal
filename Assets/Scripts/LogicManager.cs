using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score = 0;
    public int life = 3;
    private int index = 0;
    public Text scoretext;
    public GameObject gameoverscreen;
    public GameObject[] lifes;

    // Coin and Shield and Life
    private float rangex = 15.5f;
    private float rangez = 14.5f;
    public GameObject coin;
    public GameObject shield_spawn;
    private int shield_timer = 0;
    private int shield_max_time = 0;
    public void GameOver()
    {
        gameoverscreen.SetActive(true);
        Time.timeScale = 0.0f;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }
    public void AddScore(int value)
    {
        score += value;
        scoretext.text = score.ToString();
    }
    public void Addlife(int val)
    {
        life += val;
        if (val < 0)
        {
            lifes[index].SetActive(false);
            index = (index + 1) % lifes.Length;
        }
        if (life == 0) GameOver();
    }
    
    public void SpawnObjects()
    {
        float spawnposx = Random.Range(-rangex, rangex);
        float spawnposz = Random.Range(-0.5f, rangez);
        float spawnposy = 1.2f;
        if (shield_max_time == 0) shield_max_time = Random.Range(5, 8);
        if (shield_timer < shield_max_time)
        {
            Instantiate(coin, new Vector3(spawnposx, spawnposy, spawnposz), transform.rotation);
            shield_timer++;
        }
        else
        {
            Instantiate(shield_spawn, new Vector3(spawnposx, spawnposy, spawnposz), transform.rotation);
            shield_timer = 0;
            shield_max_time = Random.Range(5, 10);
        }
    }
}
