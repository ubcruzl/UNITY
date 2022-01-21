using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CapsuleCollider playerCollider;
    public float moveSpeed = 5f;

    //private GameObject enemy;
    private Enemy enemyScript;

    private RaycastHit hit;
    private Ray ray;
    public float rayDistance = 4f;

    // Start is called before the first frame update
    void Start()
    {
        playerCollider = this.GetComponent<CapsuleCollider>();
        playerCollider.height = 1f;
        playerCollider.center = new Vector3(0f, 0.5f, .0f);

        //enemy = GameObject.Find("Battle_Dummy");
        //enemyScript = enemy.GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        //Move the player character
        transform.Translate(movement * Time.deltaTime * moveSpeed);
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            enemyScript.enemyHealth--;
        }
        */
        ray = new Ray(transform.position + new Vector3(0f, playerCollider.center.y, 0f), transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.red);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.distance < rayDistance) //si golpe, la distancia es menor a la distancia del rayo
            {
                //print("We hit something!");
                if (hit.collider.gameObject.tag == "Enemy")
                {
                    print("There is an enemy ahead!");
                }
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            enemyScript = collision.gameObject.GetComponent<Enemy>();
            enemyScript.enemyHealth--;
        }
    }
}
