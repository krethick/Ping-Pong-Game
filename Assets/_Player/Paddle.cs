using UnityEngine;

public class Paddle : MonoBehaviour
{ 
    // The player_paddle and enemy_paddle can access this
    public float speed = 10.0f;
    protected Rigidbody2D _rigidbody; // which stores the reference to the rigid body

    // Called only once and Awake is used for initialisation work
    private void Awake() 
    {
      // Checks whether RigidBody is present in the Inspector of the player
      _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition(){
      _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
      _rigidbody.velocity = Vector2.zero;
    }
}


