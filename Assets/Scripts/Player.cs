using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public LogicManager logic;
    public GameObject shield;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            logic.AddScore(1);
            logic.SpawnObjects();
        }
        else if(other.CompareTag("Spawn shield"))
        {
            Destroy(other.gameObject);
            shield.SetActive(true);
        }
        else if (other.CompareTag("Moose") || other.CompareTag("Doe") || other.CompareTag("Fox"))
        {
            if (shield.activeSelf)
            {
                shield.SetActive(false);
                Destroy(other.gameObject) ;
            }
            else
            {
                logic.Addlife(-1);
            }
        }
    }
}
