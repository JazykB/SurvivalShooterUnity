using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public float speedMultiplier = 2.0f;
    private PlayerMovement playerMovement;

    private void Awake()
    {
        transform.Translate(0, 0.5f, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        PowerUpCollected(other.gameObject);
    }

    private void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    void PowerUpCollected(GameObject gameObjectCollectingPowerUp)
    {
        playerMovement = gameObjectCollectingPowerUp.GetComponent<PlayerMovement>();

        // We only care if we've been collected by the player
        if (gameObjectCollectingPowerUp.tag == "Player")
        {
            playerMovement.SetSpeedBoostOn(speedMultiplier);

            Debug.Log("Power Up collected, issuing payload for: " + gameObject.name);

            Destroy(gameObject);
        }
    }
}
