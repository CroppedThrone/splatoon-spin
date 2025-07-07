using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
	public Transform target_transform;
	public Transform camera_object;

	public Vector2 mouse_input;

	public void
	OnLookCamera(InputValue input)
	{
		mouse_input = input.Get<Vector2>();
	}

	void
	Update()
	{
		camera_object.transform.LookAt(target_transform);
		//camera_object.transform.y += player_input.Look.x;
	}
}
