using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using VirtualTown.View;

namespace VirtualTown.Facade
{
    public interface IUIFacade
    {
        public delegate void FadeCallback();

        public V AddView<V>(UIView uIView) where V : UIView;
        public void RemoveView();
        public void ClearStack();
        public void ReleaseView(UIView lView);
        public void FadeIn(float lDuration, FadeCallback lFadeCallback);
        public void FadeIn(float lDuration, bool lFadeScreenIsRaycastTarget, FadeCallback lFadeCallback);
        public void FadeOut(float lDuration, FadeCallback lFadeCallback);
        public void FadeOut(float lDuration, bool lFadeScreenIsRaycastTarget, FadeCallback lFadeCallback);
        public void HideOrderTransform(UIView lView);
        public void ShowOrderTransform(UIView lView);
        public IEnumerator PlayAudioClip(AudioClip lClip, AudioMixerGroup lOutput, float lVolume, float lPitch, bool loop = false);
        public IEnumerator PlayAudioOneShot(AudioClip lClip, AudioMixerGroup lOutput, float lVolume, float lPitch, bool loop = false);
    }
}