using UnityEngine;

public class PlayerPaddle : Paddle
{ 
   // Takes care of the Paddle Direction
   private Vector2 _direction;

   // It is called every single frame when the game is running. For eg(running/jumping)
   private void Update(){
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            _direction = Vector2.up;
        }
        
        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
             _direction = Vector2.down;
        }

        else{
              _direction = Vector2.zero;
        }
   }
   
   // It is associated with physics. Physics should be simulated at a fixed time interval
   private void FixedUpdate() {
      // we are using the unity phyisc engine
       if(_direction.sqrMagnitude !=  0){
            _rigidbody.AddForce(_direction * this.speed);
       }
   }
}
