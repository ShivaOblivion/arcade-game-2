using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public float speed;
    private GameObject m_explosionPrefab = null;

    private Animator m_animator;

    private void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    public void Explosion()
    {
        if (m_explosionPrefab != null)
        {
            Instantiate(m_explosionPrefab, transform.position, transform.rotation);
        }
    }

    public Animator GetAnimator()
    {
        return m_animator;
    }
}

