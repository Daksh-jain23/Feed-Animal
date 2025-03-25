using UnityEngine;
using UnityEngine.UIElements;

public class Coin : MonoBehaviour
{
    private float coinrotatevelocity = 150.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0), coinrotatevelocity * Time.deltaTime);
    }
}
