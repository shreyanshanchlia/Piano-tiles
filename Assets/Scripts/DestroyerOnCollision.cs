using UnityEngine;

public class DestroyerOnCollision : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		Destroy(collision.collider.gameObject);
	}
}
