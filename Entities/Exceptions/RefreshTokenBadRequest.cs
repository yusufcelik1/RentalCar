﻿using Microsoft.IdentityModel.SecurityTokenService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    internal class RefreshTokenBadRequest : BadRequestException
    {
        public RefreshTokenBadRequest()
            : base($"Invalid client request. The tokenDto has some invalid values.")
        {

        }
    }
}
