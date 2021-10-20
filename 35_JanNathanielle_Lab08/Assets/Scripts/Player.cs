using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player instance = null;
    private float score;
    public Text scoreText;

    public float minY, maxY;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = $"Score: {score}";

        float verticalInput = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;

        if (pos.y < minY)
        {
            pos.y = minY;
        }

        if (pos.y > maxY)
        {
            pos.y = maxY;
        }

        transform.position = pos + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Obstacle"))
        {
            SceneManager.LoadScene(1);
        }
    }

    public void AddScore()
    {
        score += 1;
        scoreText.text = $"Score: {score}";
    }
}
