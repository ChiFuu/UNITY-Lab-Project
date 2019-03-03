///////// Script Spawn Player pour Udemy //////////////////
///////////////////////////////////////////////////////////
////////  Instructeur Parein Jean-philippe ////////////////
///////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;

public class ScriptSpawn : MonoBehaviour {
    
   	void OnTriggerEnter (Collider Other)
    {
        if(Other.gameObject.name== "FPSController")
        {
            Other.gameObject.transform.position = GameObject.Find("SpawnPoint").transform.position;
            
        }	
	}		
}
