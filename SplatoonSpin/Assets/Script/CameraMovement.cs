using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform targetTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targetTransform);
        //Mathf.Sin(); Mathf.Cos();
    }
}
