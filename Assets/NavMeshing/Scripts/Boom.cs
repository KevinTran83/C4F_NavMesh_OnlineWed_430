using UnityEngine;

public class Boom : MonoBehaviour
{
    public GameObject target;

    private Vector3 localPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        localPos = target.transform
            .InverseTransformPoint(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + localPos;
    }
}
