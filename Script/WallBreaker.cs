﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBreaker : MonoBehaviour {

    public WallControl.WallType forWallType;
    public bool ignoreBreakable;
    public bool destroyOnBreak;
    public GameObject activateOnBreak;
    public bool checkTrophy;

    HoldPrefab holdPrefab;
    WallControl wallCon;
    Transform trans;

    const string tag_Wall = "Wall";
    const string tag_Breakable = "Breakable";

    private void Awake() {
        trans = transform;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag(tag_Wall)) {
            wallCon = other.GetComponent<WallControl>();
            if (wallCon && wallCon.isBreakable && forWallType == wallCon.wallType) {
                wallCon.DestroyAndReformAround();
                if (AudioSourcePool.Instance) {
                    AudioSourcePool.Instance.Play(AudioSourcePool.AudioName.WallBreak, trans.position);
                }
                if (activateOnBreak) {
                    activateOnBreak.SetActive(true);
                }
                if (destroyOnBreak) {
                    Destroy(gameObject);
                }
                if (checkTrophy && CharacterManager.Instance) {
                    CharacterManager.Instance.CheckTrophy_Moose();
                }
            }
        } else if (!ignoreBreakable && other.CompareTag(tag_Breakable)) {
            holdPrefab = other.GetComponent<HoldPrefab>();
            if (holdPrefab) {
                holdPrefab.InstantiatePrefab();
            }
            Destroy(other.gameObject);
        }
    }

}
