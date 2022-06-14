using FishNet;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientServerManager : MonoBehaviour
{
    [SerializeField] private bool isServer;
    private void Awake()
    {
        if (isServer) InstanceFinder.ServerManager.StartConnection();
        else InstanceFinder.ClientManager.StartConnection();
    }
}
