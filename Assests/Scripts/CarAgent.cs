using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using Unity.Sentis.Layers;

public class CarAgent : Agent
{

    private Vector3 spawnPosition;
    [SerializeField] private Rigidbody car;
    [SerializeField] private Rigidbody carbody;
    private CarController controller;
    public float velocityAlpha = 0.1f;
    private int numStay;
    public int lastcheckpointidx;
    public int num_checkpoint; 
    //private int wallCollisionSteps = 0;
    protected override void Awake()
    {
        controller = GetComponent<CarController>();
        car = GetComponent<Rigidbody>();
        carbody = GetComponent<Rigidbody>();
        lastcheckpointidx = 0;
        num_checkpoint = 14;

    }
    //setup car driver which controls forward and turn, and send that information
    private void ChecpointCollision()
    {

    }

    private void TrackCheckpoint_OnCorrectCheckpoint()
    {
            lastcheckpointidx = (lastcheckpointidx + 1)% num_checkpoint;
            AddReward(1f);   
    }

    private void TrackCheckpoint_OnWrongCheckpoint()
    {      
            AddReward(-1f);
    }

    private void Start()
    {
        TrackCheckpoints.Instance.OnPlayerWrongcheckpoint   += TrackCheckpoint_OnWrongCheckpoint;
        TrackCheckpoints.Instance.OnPlayerCorrectcheckpoint += TrackCheckpoint_OnCorrectCheckpoint;

    }

    private void FixedUpdate()
    {
        float carspeed = car.velocity.magnitude;
        float speedreward = carspeed* velocityAlpha;
        AddReward(speedreward);
        //reset if falls
        if (car.transform.position.y < -1f)
        {
            AddReward(-1000f);
            OnEpisodeBegin();
        }
    }

    public override void OnEpisodeBegin()

    {
        //Debug.Log(lastcheckpointidx);
        TrackCheckpoints.Instance.OnEpisodeBegin(8);
        //Debug.Log(TrackCheckpoints.Instance.nextcheckpointidx);
        spawnPosition = TrackCheckpoints.Instance.nextCheckpoint.transform.position;
        transform.forward = - TrackCheckpoints.Instance.nextCheckpoint.transform.right;
        transform.position = spawnPosition - new Vector3(0,0,5f);
        //transform.rotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
       
        //transform.rotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
        
        controller.GetInput(1f, 0f);
        numStay = 0;
        // setup spawn position
        //set up forward
        // stop car completely
    }


    public override void OnActionReceived(ActionBuffers actions)
    {
        float forwardAmount = 0f;
        float turnAmount = 0f;

        switch (actions.DiscreteActions[0]) {
            case 0: forwardAmount = 0f; break;
            case 1: forwardAmount = 1f; break;
            case 2: forwardAmount = -1f; break;
        }

        switch (actions.DiscreteActions[1]) {
            case 0: turnAmount = 0f; break;
            case 1: turnAmount = 1f; break;
            case 2: turnAmount = -1f; break;
        }
        controller.GetInput(forwardAmount, turnAmount);

    }

    public override void CollectObservations(VectorSensor sensor)
    {
        
        Vector3 checkpointForward = TrackCheckpoints.Instance.nextCheckpoint.transform.forward;
        float dot_prod = Vector3.Dot(checkpointForward, transform.forward);
        sensor.AddObservation(dot_prod);
        //sensor.AddObservation(car.velocity);
        sensor.AddObservation(car.velocity.magnitude);


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            Debug.Log("Hit wall");
            AddReward(-100f);
            OnEpisodeBegin();
        }
       
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        int forwardAction = 0;
        if (Input.GetKey(KeyCode.W)) { forwardAction = 1; }
        if (Input.GetKey(KeyCode.S)) { forwardAction = 2; }

        int turnAction = 0;
        if (Input.GetKey(KeyCode.D)) { turnAction = 1; }
        if (Input.GetKey(KeyCode.A)) { turnAction = 2; }

        ActionSegment<int> discreateActios = actionsOut.DiscreteActions;
        discreateActios[0] = forwardAction;
        discreateActios[1] = turnAction;
        
        //controller.GetInput(forwardAction, turnAction);
    }


        private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            Debug.Log("Stay wall");
            AddReward(-0.02f);
            numStay++;
            if (numStay > 1000)
            {
                OnEpisodeBegin();
            }
            
        }

        if (collision.gameObject.CompareTag("pit"))
        {
            Debug.Log("In pit");
        }
    }
}
