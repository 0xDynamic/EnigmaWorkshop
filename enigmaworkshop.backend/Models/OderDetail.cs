﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using NTJson = Newtonsoft.Json;

namespace enigmaworkshop.backend.Models;

public partial class OderDetail
{
    public string Oder { get; set; } = null!;

    public string Product { get; set; } = null!;

    [JsonIgnore]
    [NTJson.JsonIgnore]
    public virtual Order OderNavigation { get; set; } = null!;

    [JsonIgnore]
    [NTJson.JsonIgnore]
    public virtual Product ProductNavigation { get; set; } = null!;
}
