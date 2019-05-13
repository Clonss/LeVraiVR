using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.AI;


public class EssaiDeplacement : MonoBehaviour
{
    public SteamVR_Action_Single nom; //on a besoin du type d'action (vector2,3 par ex) → changer le type

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Actions._default.nomDeLaction.GetStateDown(SteamVR_Input_Sources.Any)) // besoin d'enregistrer l'action dans le set default de steam vr inputs
        {
            //remplir ici
        }

        float triggerValue = nom.GetAxis(SteamVR_Input_Sources.Any); 

        if (triggerValue > 0.0f) 
        {
            //changer les valeurs pour pouvoir déplacer le joueur dans la direction pointée
        }
    }
}
