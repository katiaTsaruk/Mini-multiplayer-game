using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class Shooting : NetworkBehaviour
{
    public ShowingMessage showingMessage;
    public GameObject playerCamera;


    private void Start()
    {
        this.showingMessage = GameObject.FindWithTag("ShowingMessage").GetComponent<ShowingMessage>();

    }

    private void Update()
    {
        if (!isLocalPlayer) 
            return;
        
        if(Input.GetMouseButtonDown(0))                                                                                                                     
        {
            Shoot();            
        }           
    }
    
    void Shoot()                
    {
        Ray CameraRay = new Ray(playerCamera.transform.position, playerCamera.transform.rotation*Vector3.forward);
        if (Physics.Raycast(CameraRay, out RaycastHit hit))
        {
            Debug.DrawRay(CameraRay.origin, CameraRay.direction);
            showingMessage.CreateLogTextFromType("you hit Les ", textType.level_0);
            if (hit.transform.CompareTag("Enemy_1"))
            {
                showingMessage.CreateLogTextFromType("you hit " + hit.transform.tag, textType.level_0);
            }
            else if (hit.transform.tag == "Enemy_3")
                showingMessage.CreateLogTextFromType("you hit " + hit.transform.tag, textType.level_1);
            else if (hit.transform.tag == "Enemy_2")
                showingMessage.CreateLogTextFromType("you hit "+hit.transform.tag, textType.level_2);
           
        }
    }

    [ClientRpc]
    public void Rpc_InitShootingComponent()
    {
        Debug.Log("vhhghhhhg");
        this.showingMessage = GameObject.FindWithTag("ShowingMessage").GetComponent<ShowingMessage>();
        print(isServer);

    }

    /*private void OnConnectedToServer()
    {
        this.showingMessage = GameObject.FindWithTag("ShowingMessage").GetComponent<ShowingMessage>();

    }*/
}