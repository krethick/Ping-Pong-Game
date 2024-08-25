using UnityEngine;
public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody; // We are putting private because we are not breaking the encapsulation rules
    public float speed = 200.0f;
    // For initialisation
    private void Awake(){
       _rigidbody = GetComponent<Rigidbody2D>(); // Checks whether RigidBody is present in the Inspector of the player
    }
    // Start calls the first frame. i.e shooting a gun without pressing the trigger for the first time
    private void Start(){
        ResetPosition();
        AddStartingForce();
    }
      
      // Reset the position of the ball
      public void ResetPosition(){
        _rigidbody.position  = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
    }


    public void AddStartingForce(){
        // If it is less than half it'll be negative or it'll be positive
        // This is for direction of the ball
        float x  = Random.value < 0.5f ? -1.0f : 1.0f; // This is for direction x axis
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f); // This is for direction y axis
         
         Vector2 direction = new Vector2(x,y);
        _rigidbody.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force){
        // The ball determine the force.
        _rigidbody.AddForce(force);
    }

}


