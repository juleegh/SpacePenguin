using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceSoundMixer : MonoBehaviour
{
    [SerializeField] private AudioSource galaxySound;
    [SerializeField] private AudioSource choirSound;
    // Start is called before the first frame update
    void Start()
    {
        EnemyManager.EnemyKilled += MixVolumes;
        MixVolumes();
    }

    // Update is called once per frame
    private void MixVolumes()
    {
        float percentage = EnemyManager.GetInstance().GetKillPercentage();
        choirSound.volume = percentage;
        galaxySound.volume = 1 - percentage;
    }

    private void OnDestroy()
    {
        EnemyManager.EnemyKilled -= MixVolumes;
    }
}
