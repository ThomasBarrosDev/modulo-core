using System.Collections;
using UnityEngine;
using RiseStudio.Essentials.Http;
using RiseStudio.Essentials.Debbuger;
using VirtualTown.Facade;

namespace VirtualTown.Modules
{
    public abstract partial class ModuleManager : MonoBehaviour
    {
        protected IUIFacade m_uiManager;

        public virtual IEnumerator Initialize(HttpRequest.HttpOptions httpOptions, IUIFacade uIFacade)
        {
             Debugger.Log("Projeto VT - ModuleManager");
        
            m_uiManager = uIFacade;

            yield return null;
        }
    }
}