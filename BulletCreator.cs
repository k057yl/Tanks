using UnityEngine;

public class BulletCreator : MonoBehaviour
{
    public AudioSource bang;
    public GameObject bulletPrefab;
    public float bulletVelocity;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            bang.Play();
            GameObject newBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletVelocity;
        }
    }
}
