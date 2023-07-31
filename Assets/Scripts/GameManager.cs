using UnityEngine;
using System.Collections;
using TMPro;


public class GameManager : MonoBehaviour
{

    public GameObject obstacle;
    public Transform spawnPoint;
    int score = 0;

    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject player;

    void Start()
    {
        player.SetActive(false);
    }

    void Update()
    {
        
    }


    IEnumerator SpawnObstacles() {
        while (true) {
            float waitTime = Random.Range(0.5f, 2f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(obstacle, spawnPoint.position, Quaternion.identity);
        }
    }

    void ScoreUp() {
        score++;
        scoreText.text = score.ToString();
    }

    public void GameStart() {
        player.SetActive(true);
        playButton.SetActive(false);
        StartCoroutine(SpawnObstacles());
        InvokeRepeating("ScoreUp", 2f, 2f);
    }

    void OnBecameInvisible() {
        Destroy(obstacle.gameObject);
    }
}
