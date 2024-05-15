using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCheckpoints : MonoBehaviour
{
    public static TrackCheckpoints Instance { get; private set; }
    public List<CheckpointUnique> checkpointUniqueList;
    public int nextcheckpointidx;
    public event Action OnPlayerCorrectcheckpoint;
    public event Action OnPlayerWrongcheckpoint;
    
    public CheckpointUnique nextCheckpoint { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(this);
        }

        GameObject checkpointsObject = GameObject.Find("Checkpoints");

        checkpointUniqueList = new List<CheckpointUnique>();
        if (checkpointsObject == null)
        {
            Debug.LogError("Checkpoints object not found!");
            return;
        }
        foreach (Transform checkpointTransform in checkpointsObject.transform) {
            CheckpointUnique checkpointunique = checkpointTransform.GetComponent<CheckpointUnique>();
            checkpointunique.SetTrackChecpoints(this);
            checkpointUniqueList.Add(checkpointunique);
        }
        
    }

    public void OnEpisodeBegin(int lastcheckpoint)
    {
        nextcheckpointidx = lastcheckpoint;
        nextCheckpoint = checkpointUniqueList[nextcheckpointidx];
    }

    public void PlayerThroughCheckpoint(CheckpointUnique checkpointunique)
    {
        if (nextcheckpointidx == checkpointUniqueList.IndexOf(checkpointunique)) {
            // correct checkopoint
            Debug.Log("correct checkpoint");
            OnPlayerCorrectcheckpoint?.Invoke();
            nextcheckpointidx = (1 + nextcheckpointidx) % checkpointUniqueList.Count;
            nextCheckpoint = checkpointUniqueList[nextcheckpointidx];

        }
        else
        {
            //wrong checkpoint
            Debug.Log("wrong checkpoint");
            OnPlayerWrongcheckpoint?.Invoke();
        }

       
    }
}
