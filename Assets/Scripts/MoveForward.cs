using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    private float deadzoneup = 40.0f;
    private float deadzonedown = -15.0f;
    private float deadzoneleft = -20.0f;
    private float deadzoneright = 20.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.z < deadzonedown)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > deadzoneup)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > deadzoneright)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < deadzoneleft)
        {
            Destroy(gameObject);
        }
    }

}
