﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BLL.DTO_S
{
    public class BaseDTO
    {
        [JsonIgnore]
        public int Id { get; set; }
    }
}
