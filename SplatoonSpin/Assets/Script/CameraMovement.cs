using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	public PlayerInput player_input;
    public Transform target_transform;
	public Transform camera_object;

    void
	Update()
    {
        camera_object.transform.LookAt(target_transform);
		camera_object.transform.y += player_input.Look.x;
    }
}
