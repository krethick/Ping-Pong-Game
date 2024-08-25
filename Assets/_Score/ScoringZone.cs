using UnityEngine;
using UnityEngine.EventSystems; // Create unity events
public class ScoringZone : MonoBehaviour
{
   public EventTrigger.TriggerEvent scoreTrigger;

    // Collision when the ball hits the four sides of the wall
   private void OnCollisionEnter2D(Collision2D collision) {
      Ball ball = collision.gameObject.GetComponent<Ball>();

      if(ball != null){
         BaseEventData eventData = new BaseEventData(EventSystem.current);
         this.scoreTrigger.Invoke(eventData);
      }
   }
}
