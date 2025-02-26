using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public ScoreManager sm;

    public bool canScore;
    public SafeZone oppositeZone;

    private void OnTriggerEnter(Collider other)
    {
        if (sm == null) return;

        if (canScore)
        {
            sm.AddScore(1);
            canScore = false;
            oppositeZone.canScore = true;
        }
    }
}
