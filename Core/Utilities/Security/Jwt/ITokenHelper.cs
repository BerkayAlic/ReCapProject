using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    //Token Uretimi icin, interface nedeni farkli tekniklerle yapmaya acik olmak (Mevcut teknik Jwt)
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
