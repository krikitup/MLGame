using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointUnique : MonoBehaviour
{
    // Start is called before the first frame update
    private TrackCheckpoints trackCheckpoints;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Checkpoint");
            trackCheckpoints.PlayerThroughCheckpoint(this);
        }
    }

    public void SetTrackChecpoints(TrackCheckpoints trackCheckpoints)
    {
        this.trackCheckpoints = trackCheckpoints;
    }
}
