using UnityEngine;

public class candleLightHandler : MonoBehaviour
{
    public GameObject candleFlame;


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision with candle");
        if (other.gameObject.CompareTag("lighterFlame"))
        {
            Debug.Log("Collision with candle has lighterFlameTag");
            candleFlame.SetActive(true);
        }
    }
}
