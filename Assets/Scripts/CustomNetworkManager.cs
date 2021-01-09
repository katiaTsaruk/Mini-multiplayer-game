using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class CustomNetworkManager : NetworkManager
{
 /*public override void OnServerAddPlayer(NetworkConnection conn)
 {
  print("aSS hole");
  GameObject player = Instantiate(playerPrefab);
  NetworkServer.AddPlayerForConnection(conn, player);
  player.GetComponent<Shooting>().Rpc_InitShootingComponent();
 }*/
}
