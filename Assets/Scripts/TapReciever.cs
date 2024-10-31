using TMPro;
using UnityEngine;

public class TapReciever : MonoBehaviour
{
	Camera cam;
	int score = 0;
	public Color correctColor;
	private bool isRunning = true;
	public TextMeshProUGUI scoreText, GameOverPanelScoreText;
	public GameObject GameOverPanel;

	// Start is called before the first frame update
	void Start()
	{
		cam = Camera.main;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0) && isRunning)
		{
			var collision = Physics2D.OverlapCircle(cam.ScreenToWorldPoint(Input.mousePosition), 0.001f);
			if (collision == null)
			{
				return;
			}
			if (collision.gameObject.GetComponent<SpriteRenderer>().color == Color.black)
			{
				collision.gameObject.GetComponent<SpriteRenderer>().color = correctColor;
				//add score;
				scoreText.text = (++score).ToString();
			}
			else if (collision.gameObject.GetComponent<SpriteRenderer>().color != correctColor)
			{
				collision.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
				isRunning = false;
				GameOverPanel.SetActive(true);
				GameOverPanelScoreText.text = scoreText.text;
			}
		}
	}
}
