using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate=2;
    public float timer=5;
    public float ahead=10;
    public float heightOffset=3;
    public float gapVariation=1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer<spawnRate)
        {
            timer=timer+Time.deltaTime;
        }
        else
        {
            float randomY = Random.Range(-heightOffset, heightOffset);
            GameObject newPipe = Instantiate(pipe, new Vector3(transform.position.x + ahead, randomY, transform.position.z), transform.rotation);

            float randomGap = Random.Range(-gapVariation, gapVariation);
            Transform topPipe = newPipe.transform.Find("Top Pipe");
            Transform bottomPipe = newPipe.transform.Find("Bottom Pipe");

            if (topPipe != null)
            {
                topPipe.position = topPipe.position + new Vector3(0, randomGap, 0);
            }
            if (bottomPipe != null)
            {
                bottomPipe.position = bottomPipe.position - new Vector3(0, randomGap, 0);
            }

            timer=0;
        }
    }
}
