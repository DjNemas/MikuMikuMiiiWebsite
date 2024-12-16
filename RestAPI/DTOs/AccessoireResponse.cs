﻿using RestAPI.Database.Enums;
using RestAPI.Database.Models;

namespace RestAPI.DTOs
{
    public class AccessoireResponse : ItemResponse
    {
        [System.ComponentModel.DefaultValue(null)]
        public uint? MinValue { get; set; } = null;

        [System.ComponentModel.DefaultValue(null)]
        public uint? MaxValue { get; set; } = null;

        [System.ComponentModel.DefaultValue(null)]
        public uint? UpgradeToAccessoireId { get; set; } = null;
    }
}