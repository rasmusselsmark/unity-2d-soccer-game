using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] // to make it visible in editor
    private int _groundHitCount;

    [SerializeField] // to make it visible in editor
    private int _streakScore;

    private void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.collider.gameObject.name)
        {
            case "Ground":
                _streakScore = 0;
                _groundHitCount++;
                if (_groundHitCount == 2)
                {
                    // game over when ball has hit ground twice
                    Debug.Log("Game over!");
                }
                break;

            case "PlayerHead":
                // we reset the ground hit count because we hit the player's head
                _groundHitCount = 0;
                _streakScore++;
                break;
        }
    }
}
