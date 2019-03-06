using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class menu : NetworkBehaviour
{
    public InputField lobby;
    //public lobbymanager manage;
    public NetworkLobbyManager manage;
    
    public void oncliclHost()
    {
        manage.StartMatchMaker();
        manage.matchMaker.CreateMatch(lobby.text,(uint)manage.maxPlayers,true,"","","",0,0,manage.OnMatchCreate);

    }
}
