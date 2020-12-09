using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Net.Sockets;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public static GameStart GameStartOnly;
    public bool GameState = false;
    public bool LogSwitch = true;
    private GameStart() { }

    public static GameStart GetGameStart()
    {
        if (GameStartOnly == null)
        {
            GameStartOnly = new GameStart();
        }
        return GameStartOnly;
    }

    private void Awake()
    {
        GameStartOnly = this;
    }

    // Use this for initialization
    void Start () {
        GameState = true;
        //DontDestroyOnLoad(transform);
        DebugLog("starttorun", LogType.log);

        //ShareprintScreen printScene = new ShareprintScreen(transform.GetComponent<Rect>());
        //printScene.RunPrintScreen();

        // to do  socket
        //LinkSocket("127.0.0.1", "26");
    }
	
    public void LinkSocket(string ip, string port)
    {
        Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(ip), int.Parse(port));
        try
        {
            ClientSocket.Connect(iPEndPoint);
            if (ClientSocket.Connected == true)
            {
                DebugLog("linksuccess", LogType.log);
                transform.gameObject.AddComponent<GameHall>();
            }
            else
            {
                DebugLog("linkfalse", LogType.error);
                return;
            }
        }
        catch (System.Exception)
        {

            throw;
        }
    }


    public void DebugLog(string content, LogType logType)
    {
        if (LogSwitch == false)
        {
            return;
        }
        else
        {
            switch (logType)
            {
                case LogType.log:
                    Debug.Log(content);
                    break;
                case LogType.warn:
                    Debug.LogWarning(content);
                    break;
                case LogType.error:
                    Debug.LogError(content);
                    break;
                default:
                    break;
            }
        }
    }

    public enum LogType
    {
        log,
        warn,
        error
    }
}
