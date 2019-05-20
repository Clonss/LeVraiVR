using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Valve.VR;
using Valve.VR.InteractionSystem;

//[RequireComponent(typeof(SteamVR_TrackedController))]
public class PlayerMoves : MonoBehaviour
{
    public Transform target;
    public GameObject player;
    private NavMeshAgent myNMA;

    public SteamVR_Input_ActionSet_WDCOF actionSetEnable;
    public SteamVR_Action_Boolean playerMoves;

    public Valve.VR.Extras.SteamVR_LaserPointer pointer;

    [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
        myNMA = GetComponent<NavMeshAgent>();
        actionSetEnable.Activate(SteamVR_Input_Sources.Any, 0, false);
        pointer = gameObject.GetComponent<Valve.VR.Extras.SteamVR_LaserPointer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Actions.WDCOF.PlayerMoves.GetStateDown(SteamVR_Input_Sources.Any) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            Walk();
            Debug.Log("oui");
        }
    }


    private void Walk()
    {
        /*RaycastHit hit;
        Ray ray = new Ray(transform.position, (target.transform.position - transform.position).normalized);


        if (Physics.Raycast(ray, out hit, 5f))
        {
            pointerObj.position = hit.point;
            myNMA.destination = hit.point;
        }*/
        myNMA.destination = pointer.hit.point;
    }
}
