using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
   public Ball ball; // Call the reference variable
   public Paddle playerPaddle;
   public Paddle enemyPaddle;
   [SerializeField] TextMeshProUGUI playerScoreText;
   [SerializeField] TextMeshProUGUI EnemyScoreText;
   private int _playerScore;
   private int _enemyScore;

   public void PlayerScores(){
       _playerScore++; // Increase the player score
       Debug.Log(_playerScore);
       this.playerScoreText.text = _playerScore.ToString(); // Displays the player score in the UI
       ResetRound();
   }
   
   public void EnemyScores(){
       _enemyScore++; // Increase the enemy score  
        Debug.Log(_enemyScore);
       this.EnemyScoreText.text = _enemyScore.ToString(); // Displays the enemy score in the UI 
       ResetRound();
    
   }

   private void ResetRound(){
       this.playerPaddle.ResetPosition();// Resets the position of the Player Paddle
       this.enemyPaddle.ResetPosition(); // Resets the position of the Enemy Paddle
       this.ball.ResetPosition(); // Resets the position of the ball
       this.ball.AddStartingForce(); // Again add the the force of the ball
   }
}
