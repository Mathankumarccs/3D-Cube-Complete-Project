using UnityEngine;

public class playercolletion : MonoBehaviour {

    public Playermovement movement;
    



    void OnCollisionEnter(Collision collisioninfo)
    {
        if(collisioninfo.collider.tag == "block")
        {
            movement.enabled = false;
            
            FindObjectOfType<GameManager>().EndGame();
           
        }

    }   
	
}
