using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target_transform;
	public Transform camera_object;

    void
	Start()
    {
        
    }

    void
	Update()
    {
        camera_object.transform.LookAt(target_transform);
    }
}
