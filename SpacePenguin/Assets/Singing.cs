using System.Collections;
using UnityEngine;

public class Singing : MonoBehaviour
{
    [SerializeField] private float singDistance;
    [SerializeField] private float singRadius;
    [SerializeField] private GameObject singVolume;
    [SerializeField] private GameObject singRay;
    [SerializeField] private AudioSource voice;
    [SerializeField] private AudioClip voiceClip;

    private bool isShowingRay;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SingleSinging();
            if (!isShowingRay)
            {
                StartCoroutine(ShowRay());
                voice.PlayOneShot(voiceClip);
            }
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            MultipleSinging();
        }

        singVolume.SetActive(Input.GetKey(KeyCode.X));
    }

    private void SingleSinging()
    {
        RaycastHit hit;
        bool result = Physics.Raycast(transform.position, transform.forward, out hit, singDistance);

        if (result)
        {
            Health health = hit.collider.GetComponent<Health>();
            if (health != null)
            {
                health.TakeDamage(50);
            }
        }
    }

    private void MultipleSinging()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, singRadius);
        foreach (Collider hitCollider in hitColliders)
        {
            if (hitCollider.GetComponent<Health>() != null)
            {
                Health health = hitCollider.GetComponent<Health>();
                health.TakeDamage(10);
            }
        }
    }

    private IEnumerator ShowRay()
    {
        isShowingRay = true;
        singRay.SetActive(true);
        yield return new WaitForSeconds(1);
        singRay.SetActive(false);
        isShowingRay = false;
    }
}
