﻿using AutoMapper;
using OrchardCore.Security;

namespace EasyOC.OrchardCore.OpenApi.Dto
{
    [AutoMap(typeof(IRole), ReverseMap = true)]
    public class RoleDto
    {
        public string RoleName
        {
            get; set;
        }

        public string RoleDescription
        {
            get; set;
        }
    }
}
