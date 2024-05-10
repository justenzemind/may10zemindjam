using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Fan : MonoBehaviour
{
    bool isPowered;

    public void PowerOn() {
        isPowered = true;
        Animator component = GetComponentInChildren<Animator>();
        component.SetBool("Spin", true);
    }

    public void PowerOff() {
        isPowered = false;
        Animator component = GetComponentInChildren<Animator>();
        component.SetBool("Spin", false);
    }

    public void Toggle() {
        if (isPowered) {
            PowerOff();
        } else {
            PowerOn();
        }
    }
}
