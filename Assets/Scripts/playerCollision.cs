using UnityEngine;

public class playerCollision : MonoBehaviour{

    public playerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);
        if(collisionInfo.collider.tag == "obstacle")
        {
            //Debug.Log("We have hit an obstacle");
            movement.enabled = false;
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
