﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.AuthorDTOs
{
    public class AuthorListDTO : BaseDTO
    {
        public string Name { get; set; }
    }
}
