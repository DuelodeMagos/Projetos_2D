using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public float health = 2;
    public float Health {
        get {
            return health;
        }
        set {
            health = Mathf.Clamp(value, 0, healthMax);
        }
    }
    public float healthMax = 14;

    public Image healthBar;

    private void Update() {
        Health = PlayerControl.vida;
        UpdateHealthBar();
    }

    private void UpdateHealthBar() {
        healthBar.fillAmount = Health / healthMax;
    }
}
