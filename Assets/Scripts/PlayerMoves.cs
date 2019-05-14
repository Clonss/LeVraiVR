using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Valve.VR;
using Valve.VR.InteractionSystem;

//[RequireComponent(typeof(SteamVR_TrackedController))]
public class PlayerMoves : MonoBehaviour
{
    //public VRTK.VRTK_ControllerEvents controllerEvent;
    public Transform pointerObj;
    public Transform target;
    public GameObject player;
    private NavMeshAgent myNMA;

    public SteamVR_Input_ActionSet_WDCOF actionSetEnable;
    public SteamVR_Action_Boolean playerMoves;

    [SerializeField]

    //private SteamVR_TrackedController trackedController;

    // Start is called before the first frame update
    void Start()
    {
        myNMA = GetComponent<NavMeshAgent>();
        //trackedController = GetComponent<SteamVR_TrackedController>();
        //trackedController.PadClicked += Walk;

        actionSetEnable.Activate(SteamVR_Input_Sources.Any, 0, false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMoves.GetState(SteamVR_Input_Sources.Any) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            Walk();
        }
        //Walk();
    }


    private void Walk()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, (target.transform.position - transform.position).normalized);


        if (Physics.Raycast(ray, out hit, 5f))
        {
            pointerObj.position = hit.point;
            myNMA.destination = hit.point;
        }
    }
}
