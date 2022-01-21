using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    //private animator anim

    private NavMeshAgent agent;
    private Animator anim;
    public float speed = 1;

    void Awake()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }
    
    private void Update()
    {
        //movimiento de objeto con el teclado
        float horInput = Input.GetAxis("Horizontal") * speed;
        float verInput = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(horInput, 0f, verInput);
        Vector3 moveDestination = transform.position + movement;
        agent.destination = moveDestination;
        //GetComponent<NavMeshAgent>().destination = moveDestination;
        //animacion de objeto Hero
        anim.SetFloat("Speed", agent.velocity.magnitude);
    }
    /*
    private void MovePlayer()
    {
        agent.speed = speed;
        float horizontalMovement = Input.GetAxis("Horizontal") * speed;
        float verticalMovement = Input.GetAxis("Vertical") * speed;

        agent.SetDestination(Vector3.forward * verticalMovement);
        agent.SetDestination(Vector3.right * horizontalMovement);

    }
    */
}
