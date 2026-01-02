using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate=4;
    public float timer=0;
    public float ahead=10;
    public float minHeight=-3;
    public float maxHeight=7;
    public int initialCloudCount=5;

    void Start()
    {
        float spacingX = (ahead - (-50)) / initialCloudCount;

        for (int i = 0; i < initialCloudCount; i++)
        {
            float baseX = -50 + (i * spacingX);
            float randomOffsetX = Random.Range(-spacingX/3, spacingX/3);
            float spawnX = baseX + randomOffsetX;

            float randomY = Random.Range(minHeight, maxHeight);
            Instantiate(cloud, new Vector3(spawnX, randomY, transform.position.z), transform.rotation);
        }
    }

    void Update()
    {
        if (timer<spawnRate)
        {
            timer=timer+Time.deltaTime;
        }
        else
        {
            float randomY = Random.Range(minHeight, maxHeight);
            Instantiate(cloud, new Vector3(transform.position.x + ahead, randomY, transform.position.z), transform.rotation);
            timer=0;
        }
    }
}
