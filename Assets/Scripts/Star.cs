using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField] private float _speed;
    void Update()
    {
        transform.Translate(new Vector3(0,-1,-2) * Time.deltaTime *_speed);
        if (transform.position.y <= 35)
        {
            Destroy(gameObject);
        }
    }
}
