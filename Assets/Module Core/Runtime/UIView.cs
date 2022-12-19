using VirtualTown.Facade;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace VirtualTown.View
{
    public abstract class UIView : MonoBehaviour
    {
        private bool m_Showing = false;
        private bool m_OnStack = false;
        private bool m_Focused = false;

        public bool Showing { get { return m_Showing; } }
        public bool OnStack { get { return m_OnStack; } }
        public bool Focued { get { return m_Focused; } }
        public static IUIFacade IUIFacade { get; set; }

        public void Pushed()
        {
            m_OnStack = true;
            OnAddedToStack();
        }

        public void Popped()
        {
            m_OnStack = false;
            m_Showing = false;
            m_Focused = false;
            IUIFacade.ReleaseView(this);
            OnRemovedFromStack();
        }

        public void Show()
        {
            m_Showing = true;
            IUIFacade.ShowOrderTransform(this);
            OnShow();
        }

        public void Hide()
        {
            m_Showing = false;
            m_Focused = false;
            IUIFacade.HideOrderTransform(this);
            OnHide();
        }

        public void GainedFocus()
        {
            m_Focused = true;
            OnGainedFocus();
        }

        public void LostFocus()
        {
            m_Focused = false;
            OnLostFocus();
        }

        protected abstract void OnAddedToStack();

        protected abstract void OnRemovedFromStack();

        protected abstract void OnShow();

        protected abstract void OnHide();

        protected abstract void OnGainedFocus();

        protected abstract void OnLostFocus();
    }
}
