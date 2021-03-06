﻿using UnityEngine;
using UnityEngine.EventSystems;

namespace Game
{
    public class UI_secureLock : MonoBehaviour
    {
        private GameObject lastselect;

        void Start()
        {
            lastselect = new GameObject();
        }

        void Update()
        {
            if (EventSystem.current != null)
            {
                if (EventSystem.current.currentSelectedGameObject == null)
                {
                    EventSystem.current.SetSelectedGameObject(lastselect);
                }
                else if (lastselect != EventSystem.current.currentSelectedGameObject)
                {
                    lastselect = EventSystem.current.currentSelectedGameObject;
                }
            }
        }
    }
}