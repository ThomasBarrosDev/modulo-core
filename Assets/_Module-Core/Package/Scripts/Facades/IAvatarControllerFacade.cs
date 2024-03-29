﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VirtualTown.Enums;

namespace VirtualTown.Avatar
{
    public interface IAvatarControllerFacade
    {
        /*
        public class AvatarData
        {
            public GenderType genderType;

            //Cor
            //Itens equipados (ItemData)
        }*/
        /*
        public AvatarData AvatarSettings { get; }*/
        //public bool CheckIfAvatarIsSetted();

        //public GameObject Model { get; }
        public enum AvailableModels
        {
            None,
            RegularMale,
            RegularFamale,
            AnãoMale,
            AnãoFamale,
            Robo
        }

        [Serializable]
        public struct ItemDataDTO
        {
            public struct MaterialSettings
            {
                public string albedo;
                public string smoothmap;
                public string basemap;
                public string normalmap;
            }

            public struct GenderSettings
            {
                public string gender_type;
                public MaterialSettings settings;

                public ItemGenderType GenderType { get { return (ItemGenderType)Enum.Parse(typeof(ItemGenderType), gender_type, true); } }
            }

            public string sku;
            public string item_type;
            public string subtype;
            public string color;
            public GenderSettings[] gender_settings;
        }

        public bool NewAvatar { get; set; }
        public string[] EquipedsItems();
        public IEnumerator SetCurrentAvatar(AvailableModels available_Model, Vector3 instantiatePosition, Action<float> progressBar = null);
        public IEnumerator EquipItem(ItemDataDTO item, Action<float> progressBar = null);
        public void EquipItem(object item);
        public void UnequipItem(object item);

        public IEnumerator SaveAvatarData(Action<float> progressBar = null);

    }
}
