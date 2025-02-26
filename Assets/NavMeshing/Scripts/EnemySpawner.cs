using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public int count=300;

    public float minX, maxX, minY, maxY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < count; i++)
            Instantiate ( enemy, transform.position, 
                                 transform.rotation
                        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
