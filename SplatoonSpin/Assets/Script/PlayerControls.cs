using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
	public Transform target_transform;
	public Transform camera_object;

	void
	OnMove(InputValue input)
	{
		Vector2 move_input = input.Get<Vector2>();
	}

	void
	OnLook(InputValue input)
	{
		Vector2 mouse_input = input.Get<Vector2>();
	}

	void
	Start()
	{
	}

	void
	Update()
	{
	}
}
