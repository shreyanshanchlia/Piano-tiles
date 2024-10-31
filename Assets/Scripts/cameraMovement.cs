using UnityEngine;

public class cameraMovement : MonoBehaviour
{
	public float speed;
	public float speedIncrease = 0.02f;
	Vector3 newPos = Vector3.zero;
	bool started = false;

	// Update is called once per frame
	void Update()
	{
		if (started)
		{
			newPos = this.transform.position;
			newPos.y += Time.deltaTime * speed;
			this.transform.position = newPos;
		}
		if (Input.GetMouseButtonDown(0))
		{
			if (!started)
			{
				started = true;
			}
			else
			{
				speed += speedIncrease;
			}
		}
	}
}
