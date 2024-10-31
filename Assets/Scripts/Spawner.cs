using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject lowestSpawnPoint;
	public Vector2 offset;
	public GameObject tilePrefab;

	Vector3 tempVector3;
	private void Start()
	{
		for (int i = 0; i < 15; i++)
		{
			Spawn();
		}
	}
	void Spawn()
	{
		lowestSpawnPoint.transform.position += new Vector3(0, offset.y, 0);
		tempVector3 = lowestSpawnPoint.transform.position;

		int random = Random.Range(0, 4);

		GameObject tile;
		tempVector3.x += offset.x * 1.5f;

		tile = Instantiate(tilePrefab, tempVector3, Quaternion.identity);
		if (random == 0)
		{
			tile.GetComponent<SpriteRenderer>().color = Color.black;
		}
		tempVector3.x -= offset.x;
		tile = Instantiate(tilePrefab, tempVector3, Quaternion.identity);
		if (random == 1)
		{
			tile.GetComponent<SpriteRenderer>().color = Color.black;
		}
		tempVector3.x -= offset.x;
		tile = Instantiate(tilePrefab, tempVector3, Quaternion.identity);
		if (random == 2)
		{
			tile.GetComponent<SpriteRenderer>().color = Color.black;
		}
		tempVector3.x -= offset.x;
		tile = Instantiate(tilePrefab, tempVector3, Quaternion.identity);
		if (random == 3)
		{
			tile.GetComponent<SpriteRenderer>().color = Color.black;
		}
	}
	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Spawn();
		}
	}
}
