using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonalizedLibraryAPI.Models;

namespace PersonalizedLibraryAPI.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}