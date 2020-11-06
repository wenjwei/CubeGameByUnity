using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHall : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        GameStart.GetGameStart().DebugLog("enterhall", GameStart.LogType.log);

    }
	

}
