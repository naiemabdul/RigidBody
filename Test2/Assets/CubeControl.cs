using UnityEngine;

public class CubeControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {

            transform.position += Vector3.forward * Time.deltaTime;
        }
    }
}
