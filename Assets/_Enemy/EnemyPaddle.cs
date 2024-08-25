using UnityEngine;

public class EnemyPaddle : Paddle
{ 
    public Rigidbody2D ball;
    // Used for physics related logic
    private void FixedUpdate()
    {
        if(this.ball.velocity.x > 0.0f)
        {
            // This logic if the ball is coming towards us
            if(this.ball.position.y > this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
            else if(this.ball.velocity.y < this.transform.position.y){
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        } 
        else
        {
            // This logic if the ball is going away from us
            if(this.transform.position.y > 0.0f){
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
            else if(this.transform.position.y < 0.0f){
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
